﻿namespace GUI_Hangman
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWordDisplay = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWordDisplay
            // 
            this.lblWordDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWordDisplay.Font = new System.Drawing.Font("Architect", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordDisplay.Location = new System.Drawing.Point(12, 9);
            this.lblWordDisplay.Name = "lblWordDisplay";
            this.lblWordDisplay.Size = new System.Drawing.Size(360, 50);
            this.lblWordDisplay.TabIndex = 0;
            this.lblWordDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWordDisplay.UseMnemonic = false;
            this.lblWordDisplay.Click += new System.EventHandler(this.lblWordDisplay_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuess.Font = new System.Drawing.Font("Architect", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(41, 295);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(130, 54);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // tbGuess
            // 
            this.tbGuess.BackColor = System.Drawing.SystemColors.Control;
            this.tbGuess.Font = new System.Drawing.Font("Architect", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuess.Location = new System.Drawing.Point(241, 295);
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(100, 54);
            this.tbGuess.TabIndex = 2;
            this.tbGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(41, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblWordDisplay);
            this.Name = "Form1";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWordDisplay;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

