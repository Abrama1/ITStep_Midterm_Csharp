﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Translator
{
    public partial class Form1 : Form
    {
        string firstString, secondString;
        public Form1()
        {
            InitializeComponent();
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

        private void btnTransate_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {

        }
    }
}
