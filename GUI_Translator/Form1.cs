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
            cmbSourceLanguage.Items.AddRange(new string[] { "en", "es", "fr", "de" });
            cmbTargetLanguage.Items.AddRange(new string[] { "en", "es", "fr", "de" });
            cmbSourceLanguage.SelectedIndex = 1;
            cmbTargetLanguage.SelectedIndex = 2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnTransate_Click(object sender, EventArgs e)
        {
            try
            {
                string translatedText = await TranslateAsync(txtDisplay1.Text, cmbSourceLanguage.SelectedItem.ToString(), cmbTargetLanguage.SelectedItem.ToString());
                txtDisplay2.Text = translatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Translation failed. Please try again. Error: \r\n" + ex);
                throw;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {

        }
    }

    public class TranslationResponse
    {
        [JsonProperty("responseStatus")]
        public int responseStatus { get; set; }

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
