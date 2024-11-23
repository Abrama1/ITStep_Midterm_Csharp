using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Hangman
{
    public partial class Form1 : Form
    {
        #region Variables
        List<string> words = new List<string>
        {
            "banana",
            "apple",
            "orange"
        };
        int incorrectGuess;
        Random random;
        string selectedWord;
        char[] displayWord;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void lblWordDisplay_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            incorrectGuess = 0;
            random = new Random();
            selectedWord = words[random.Next(words.Count)];
            displayWord = new string('_', selectedWord.Length).ToCharArray();
            string formattedDisplayWord = string.Join(" ", displayWord);
            lblWordDisplay.Text = formattedDisplayWord;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            char guess = tbGuess.Text.ToLower()[0];
            bool correctGuess = false;
            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (selectedWord[i] == guess)
                {
                    displayWord[i] = guess;
                    correctGuess = true;
                }
            }

            lblWordDisplay.Text = string.Join(" ", displayWord);
            if (!correctGuess)
            {
                UpdateHangmanImage();
            }

            if (!lblWordDisplay.Text.Contains('_'))
            {
                MessageBox.Show("Congratulations! You've won");
                Application.Restart();
            }
        }
    }
}
