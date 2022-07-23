using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notatnik
{
    public partial class Notatnik : Form
    {

        String plik = "";
        String znajdz = "";
        int index_znajdz = 0;
        public Notatnik()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }
        void document_PrintPage(object senter, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textbox1.Text, textbox1.Font, Brushes.Black, 20, 20);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zawijanieWierszyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zawijanieWierszyToolStripMenuItem.Checked == true)
            {
                textbox1.WordWrap = true;
            }
            else
            {
                textbox1.WordWrap = false;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void edycjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void plikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox1.Clear();
            plik = "";
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                plik = openFileDialog1.FileName;
                textbox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void notatnikInformacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            O_programie obiekt_o_programie = new O_programie();
            obiekt_o_programie.ShowDialog();
        }

        private void noweOknoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notatnik obiekt_Notatnik = new Notatnik();
            obiekt_Notatnik.Show();
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                plik = saveFileDialog1.FileName;
                textbox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (plik == "")
            {
                zapiszJakoToolStripMenuItem_Click(sender, e);
            }
            else
            {
                textbox1.SaveFile(plik, RichTextBoxStreamType.PlainText);
            }
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox1.SelectAll();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (textbox1.SelectedText != "")
            {
                textbox1.Copy();
            }
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox1.Paste();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textbox1.SelectedText != "")
            {
                wytnijToolStripMenuItem.Enabled = true;

                textbox1.Cut();
            }
           
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (textbox1.SelectedText != "")
                {
                    textbox1.SelectionFont = fontDialog1.Font;
                }
                else
                {
                    textbox1.Font = fontDialog1.Font;
                }
            }

        }

        private void ustawieniaStronyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1 = pageSetupDialog1.Document;
            }
        }

        private void godzinadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox1.Text = textbox1.Text.Insert(textbox1.SelectionStart, DateTime.Now.ToShortDateString() + " / " + DateTime.Now.ToShortTimeString());
        }

        private void znajdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Znajdz obiekt_Znajdź = new Znajdz();
            obiekt_Znajdź.ShowDialog();

            if (obiekt_Znajdź.rezultat == true)
            {
                znajdz = obiekt_Znajdź.tekst_do_szukania;
            }
            textbox1.Find(znajdz);
            index_znajdz = textbox1.SelectionStart;
        }
        private void znajdźNastępnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
                textbox1.Find(znajdz, index_znajdz + 1, RichTextBoxFinds.None);
                index_znajdz = textbox1.SelectionStart;
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox1.SelectedText = "";
        }

        private void drukujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void znajdźPoprzednieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox1.Find(znajdz, index_znajdz - 1, RichTextBoxFinds.None);
            index_znajdz = textbox1.SelectionStart;


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            liczba_znakow.Text = textbox1.TextLength.ToString();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            pozycja_kursora.Text = textbox1.SelectionStart.ToString();
        }

        private void pasekStanuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pasekStanuToolStripMenuItem.Checked == true)
            {
                Stopka.Show();
            }
            else if (pasekStanuToolStripMenuItem.Checked == false)
            {
                Stopka.Hide();
            }
        }

        private void znajdźOstatniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index_znajdz = textbox1.SelectionStart;
            textbox1.Find(znajdz, index_znajdz, RichTextBoxFinds.Reverse);
            index_znajdz = textbox1.SelectionStart;
        }

      
    }
}