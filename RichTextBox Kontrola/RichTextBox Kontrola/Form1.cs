using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBox_Kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSpremi_Click(object sender, EventArgs e)
        {
            RichTekstBox.SaveFile(@"C:Tempproba.rtf");
            MessageBox.Show("Tekst spremljen");
        }

        private void ButtonCitaj_Click(object sender, EventArgs e)
        {
            RichTekstBox.LoadFile(@"C:Tempproba.rtf");
        }

        private void Button_Brisi_Click(object sender, EventArgs e)
        {
            RichTekstBox.Clear();
        }
    }
}
