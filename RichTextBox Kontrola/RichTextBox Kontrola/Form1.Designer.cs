namespace RichTextBox_Kontrola
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
            this.RichTekstBox = new System.Windows.Forms.RichTextBox();
            this.ButtonCitaj = new System.Windows.Forms.Button();
            this.Button_Brisi = new System.Windows.Forms.Button();
            this.ButtonSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RichTekstBox
            // 
            this.RichTekstBox.Location = new System.Drawing.Point(13, 32);
            this.RichTekstBox.Name = "RichTekstBox";
            this.RichTekstBox.Size = new System.Drawing.Size(209, 159);
            this.RichTekstBox.TabIndex = 0;
            this.RichTekstBox.Text = "";
            // 
            // ButtonCitaj
            // 
            this.ButtonCitaj.Location = new System.Drawing.Point(13, 3);
            this.ButtonCitaj.Name = "ButtonCitaj";
            this.ButtonCitaj.Size = new System.Drawing.Size(75, 23);
            this.ButtonCitaj.TabIndex = 1;
            this.ButtonCitaj.Text = "Čitaj";
            this.ButtonCitaj.UseVisualStyleBackColor = true;
            this.ButtonCitaj.Click += new System.EventHandler(this.ButtonCitaj_Click);
            // 
            // Button_Brisi
            // 
            this.Button_Brisi.Location = new System.Drawing.Point(147, 3);
            this.Button_Brisi.Name = "Button_Brisi";
            this.Button_Brisi.Size = new System.Drawing.Size(75, 23);
            this.Button_Brisi.TabIndex = 2;
            this.Button_Brisi.Text = "Briši";
            this.Button_Brisi.UseVisualStyleBackColor = true;
            this.Button_Brisi.Click += new System.EventHandler(this.Button_Brisi_Click);
            // 
            // ButtonSpremi
            // 
            this.ButtonSpremi.Location = new System.Drawing.Point(13, 198);
            this.ButtonSpremi.Name = "ButtonSpremi";
            this.ButtonSpremi.Size = new System.Drawing.Size(75, 23);
            this.ButtonSpremi.TabIndex = 3;
            this.ButtonSpremi.Text = "Spremi";
            this.ButtonSpremi.UseVisualStyleBackColor = true;
            this.ButtonSpremi.Click += new System.EventHandler(this.ButtonSpremi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonSpremi);
            this.Controls.Add(this.Button_Brisi);
            this.Controls.Add(this.ButtonCitaj);
            this.Controls.Add(this.RichTekstBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTekstBox;
        private System.Windows.Forms.Button ButtonCitaj;
        private System.Windows.Forms.Button Button_Brisi;
        private System.Windows.Forms.Button ButtonSpremi;
    }
}

