namespace GUI_Translator
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
            this.cmbSourceLanguage = new System.Windows.Forms.ComboBox();
            this.cmbTargetLanguage = new System.Windows.Forms.ComboBox();
            this.btnTransate = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.txtDisplay1 = new System.Windows.Forms.TextBox();
            this.txtDisplay2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbSourceLanguage
            // 
            this.cmbSourceLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbSourceLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSourceLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSourceLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSourceLanguage.ForeColor = System.Drawing.SystemColors.Menu;
            this.cmbSourceLanguage.FormattingEnabled = true;
            this.cmbSourceLanguage.Location = new System.Drawing.Point(85, 205);
            this.cmbSourceLanguage.Name = "cmbSourceLanguage";
            this.cmbSourceLanguage.Size = new System.Drawing.Size(250, 24);
            this.cmbSourceLanguage.TabIndex = 1;
            // 
            // cmbTargetLanguage
            // 
            this.cmbTargetLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbTargetLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTargetLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTargetLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTargetLanguage.ForeColor = System.Drawing.SystemColors.Menu;
            this.cmbTargetLanguage.FormattingEnabled = true;
            this.cmbTargetLanguage.Location = new System.Drawing.Point(500, 205);
            this.cmbTargetLanguage.Name = "cmbTargetLanguage";
            this.cmbTargetLanguage.Size = new System.Drawing.Size(250, 24);
            this.cmbTargetLanguage.TabIndex = 1;
            // 
            // btnTransate
            // 
            this.btnTransate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTransate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnTransate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransate.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnTransate.Location = new System.Drawing.Point(369, 280);
            this.btnTransate.Name = "btnTransate";
            this.btnTransate.Size = new System.Drawing.Size(100, 40);
            this.btnTransate.TabIndex = 2;
            this.btnTransate.Text = "Translate";
            this.btnTransate.UseVisualStyleBackColor = false;
            this.btnTransate.Click += new System.EventHandler(this.btnTransate_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackgroundImage = global::GUI_Translator.Properties.Resources.intersect;
            this.btnSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.Location = new System.Drawing.Point(393, 205);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(50, 24);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.UseVisualStyleBackColor = true;
            // 
            // txtDisplay1
            // 
            this.txtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay1.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtDisplay1.Location = new System.Drawing.Point(40, 60);
            this.txtDisplay1.Multiline = true;
            this.txtDisplay1.Name = "txtDisplay1";
            this.txtDisplay1.Size = new System.Drawing.Size(350, 130);
            this.txtDisplay1.TabIndex = 0;
            this.txtDisplay1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDisplay2
            // 
            this.txtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay2.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtDisplay2.Location = new System.Drawing.Point(445, 60);
            this.txtDisplay2.Multiline = true;
            this.txtDisplay2.Name = "txtDisplay2";
            this.txtDisplay2.ReadOnly = true;
            this.txtDisplay2.Size = new System.Drawing.Size(350, 130);
            this.txtDisplay2.TabIndex = 0;
            this.txtDisplay2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(834, 361);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnTransate);
            this.Controls.Add(this.cmbTargetLanguage);
            this.Controls.Add(this.cmbSourceLanguage);
            this.Controls.Add(this.txtDisplay2);
            this.Controls.Add(this.txtDisplay1);
            this.Name = "Form1";
            this.Text = "Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSourceLanguage;
        private System.Windows.Forms.ComboBox cmbTargetLanguage;
        private System.Windows.Forms.Button btnTransate;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.TextBox txtDisplay1;
        private System.Windows.Forms.TextBox txtDisplay2;
    }
}

