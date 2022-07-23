using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notatnik
{
    public partial class Opinia : Form
    {

        string opinion = "";
       

        public Opinia()
        {
            InitializeComponent();
        }

        private void Zamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dodaj_opinie_Click(object sender, EventArgs e)
        {
           

            if (okno_opinia.Text != "")
            {
                saveFileDialog2.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                
                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    opinion = saveFileDialog2.FileName;
                  okno_opinia.SaveFile(saveFileDialog2.FileName, RichTextBoxStreamType.PlainText);
                   
                }
                string message = "      Dziękujemy za dodanie opinii        ";
                MessageBox.Show(message);
                okno_opinia.Clear();
            }
            else
            {
                string message = "      Dodaj opinię !      ";
                MessageBox.Show(message);
            }
            
        }

       
    }
}
