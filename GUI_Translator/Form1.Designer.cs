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
            this.txtDisplay1 = new System.Windows.Forms.TextBox();
            this.txtDisplay2 = new System.Windows.Forms.TextBox();
            this.cmbBoxList1 = new System.Windows.Forms.ComboBox();
            this.cmbBoxList2 = new System.Windows.Forms.ComboBox();
            this.btnTransate = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.txtDisplay2.Size = new System.Drawing.Size(350, 130);
            this.txtDisplay2.TabIndex = 0;
            this.txtDisplay2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmbBoxList1
            // 
            this.cmbBoxList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbBoxList1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBoxList1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxList1.ForeColor = System.Drawing.SystemColors.Menu;
            this.cmbBoxList1.FormattingEnabled = true;
            this.cmbBoxList1.Location = new System.Drawing.Point(85, 205);
            this.cmbBoxList1.Name = "cmbBoxList1";
            this.cmbBoxList1.Size = new System.Drawing.Size(250, 24);
            this.cmbBoxList1.Sorted = true;
            this.cmbBoxList1.TabIndex = 1;
            // 
            // cmbBoxList2
            // 
            this.cmbBoxList2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbBoxList2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBoxList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxList2.ForeColor = System.Drawing.SystemColors.Menu;
            this.cmbBoxList2.FormattingEnabled = true;
            this.cmbBoxList2.Location = new System.Drawing.Point(500, 205);
            this.cmbBoxList2.Name = "cmbBoxList2";
            this.cmbBoxList2.Size = new System.Drawing.Size(250, 24);
            this.cmbBoxList2.Sorted = true;
            this.cmbBoxList2.TabIndex = 1;
            // 
            // btnTransate
            // 
            this.btnTransate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTransate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnTransate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransate.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnTransate.Location = new System.Drawing.Point(370, 279);
            this.btnTransate.Name = "btnTransate";
            this.btnTransate.Size = new System.Drawing.Size(100, 40);
            this.btnTransate.TabIndex = 2;
            this.btnTransate.Text = "Translate";
            this.btnTransate.UseVisualStyleBackColor = false;
            this.btnTransate.Click += new System.EventHandler(this.btnTransate_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShuffle.BackColor = System.Drawing.Color.Transparent;
            this.btnShuffle.BackgroundImage = global::GUI_Translator.Properties.Resources.shuffle3;
            this.btnShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShuffle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Location = new System.Drawing.Point(382, 205);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnShuffle.Size = new System.Drawing.Size(75, 32);
            this.btnShuffle.TabIndex = 3;
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(834, 361);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnTransate);
            this.Controls.Add(this.cmbBoxList2);
            this.Controls.Add(this.cmbBoxList1);
            this.Controls.Add(this.txtDisplay2);
            this.Controls.Add(this.txtDisplay1);
            this.Name = "Form1";
            this.Text = "Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay1;
        private System.Windows.Forms.TextBox txtDisplay2;
        private System.Windows.Forms.ComboBox cmbBoxList1;
        private System.Windows.Forms.ComboBox cmbBoxList2;
        private System.Windows.Forms.Button btnTransate;
        private System.Windows.Forms.Button btnShuffle;
    }
}

