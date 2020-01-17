using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int bayan = 0, erkek = 0;
            foreach (Seyirci seyirci in Form1.seyirciler)
            {
                lstIzleyiciler.Items.Add(seyirci.adSoyad);
                if (seyirci.cinsiyet)
                {
                    bayan++;
                }
                else
                {
                    erkek++;
                }
                lblBayanIzleyici.Text = bayan.ToString();
                lblErkekIzleyici.Text = erkek.ToString();
                lblToplamIzleyici.Text = Form1.seyirciler.Count.ToString();
            }
        }
    }
}
