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
    public partial class Znajdz : Form
    {
   

        public bool rezultat = false;
            public  string tekst_do_szukania = "";
        public Znajdz()
        {
            InitializeComponent();
        }
          
        private void button3_Click(object sender, EventArgs e)
        {
            
            rezultat = true;
            tekst_do_szukania = szukanie.Text;
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rezultat = false;
            Close();
        }

        private void Znajdź_Load(object sender, EventArgs e)
        {

        }

     
    }
}
