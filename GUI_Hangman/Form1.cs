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
        List<string> words = new List<string>
        {
            "banana",
            "apple",
            "orange"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void lblWordDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
