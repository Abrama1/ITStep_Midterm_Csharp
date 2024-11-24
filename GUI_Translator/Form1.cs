using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Translator
{
    public partial class Form1 : Form
    {
        private const string baseUrl = "http://api.mymemory.translated.net";
        private HttpClient httpClient;

        private readonly Dictionary<string, string> languageMap = new Dictionary<string, string>
        {
            { "English", "en" },
            { "Spanish", "es" },
            { "French", "fr" },
            { "German", "de" },
            { "Arabic", "ar" },
            { "Chinese", "zh" },
            { "Russian", "ru" },
            { "Italian", "it" },
            { "Japanese", "ja" },
            { "Korean", "ko" },
            { "Hindi", "hi" },
            { "Portuguese", "pt" },
            { "Dutch", "nl" },
            { "Polish", "pl" },
            { "Swedish", "sv" },
            { "Turkish", "tr" },
            { "Greek", "el" },
            { "Czech", "cs" },
            { "Hebrew", "he" },
            { "Romanian", "ro" },
            { "Danish", "da" },
            { "Finnish", "fi" },
            { "Norwegian", "no" },
            { "Vietnamese", "vi" }
        };


        public Form1()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }

        private async Task<string> TranslateAsync(string text, string sourceLang, string targetLang)
        {
            string url = $"{baseUrl}/get?q={Uri.EscapeDataString(text)}&langpair={sourceLang}|{targetLang}";

            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            var translationResult = JsonConvert.DeserializeObject<TranslationResponse>(responseJson);

            if (translationResult.ResponseStatus == 200)
            {
                return translationResult.TranslatedText;
            }

            return string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSourceLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTargetLanguage.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbSourceLanguage.Items.AddRange(languageMap.Keys.ToArray());
            cmbTargetLanguage.Items.AddRange(languageMap.Keys.ToArray());

            cmbSourceLanguage.SelectedIndex = cmbSourceLanguage.Items.IndexOf("English");
            cmbTargetLanguage.SelectedIndex = cmbTargetLanguage.Items.IndexOf("Spanish");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnTransate_Click(object sender, EventArgs e)
        {
            try
            {
                string sourceLang = languageMap[cmbSourceLanguage.SelectedItem.ToString()];
                string targetLang = languageMap[cmbTargetLanguage.SelectedItem.ToString()];

                string translatedText = await TranslateAsync(txtDisplay1.Text, sourceLang, targetLang);
                txtDisplay2.Text = translatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Translation failed. Please try again. Error: \r\n" + ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            string tempText = txtDisplay1.Text;
            txtDisplay1.Text = txtDisplay2.Text;
            txtDisplay2.Text = tempText;

            int tempIndex = cmbSourceLanguage.SelectedIndex;
            cmbSourceLanguage.SelectedIndex = cmbTargetLanguage.SelectedIndex;
            cmbTargetLanguage.SelectedIndex = tempIndex;
        }
    }

    public class TranslationResponse
    {
        [JsonProperty("responseStatus")]
        public int ResponseStatus { get; set; }

        [JsonProperty("responseData")]
        public TranslationData ResponseData { get; set; }

        public string TranslatedText => ResponseData?.TranslatedText;
    }

    public class TranslationData
    {
        [JsonProperty("translatedText")]
        public string TranslatedText { get; set; }
    }
}
