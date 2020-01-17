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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int koltukno = 1;
            int x = 6;
            for (int j = 0; j < 12; j++)
            {
                int y = 19;
                for (int i = 0; i < 6; i++)
                {
                    if ((i % 2 != 0 || (j > 1 && j < 10)))
                    {
                        PictureBox pcb = new PictureBox();
                        pcb.Name = koltukno.ToString();
                        pcb.Height = pcb.Width = 50;
                        pcb.Image = Image.FromFile(@"..\..\Images\bos.jpg");
                        pcb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pcb.Location = new Point(x, y);
                        pcb.Click += Pcb_Click;
                        gbKoltuklar.Controls.Add(pcb);
                        koltukno++;
                    }
                    y += 56;
                }
                x += 56;
            }
        }
        private void Pcb_Click(object sender, EventArgs e)
        {
            PictureBox pcb = (PictureBox)sender;
            Form2 form2 = new Form2(pcb);
            form2.ShowDialog();
        }
        public static List<Seyirci> seyirciler = new List<Seyirci>();
        private void btnAnaliz_Click(object sender, EventArgs e)
        {
            foreach (PictureBox koltuk in gbKoltuklar.Controls)
            {
                if (koltuk.Tag!=null)
                {
                    seyirciler.Add(koltuk.Tag as Seyirci);
                }                
            }
            if (seyirciler.Count > 0)
            {
                Form3 frm = new Form3();
                frm.ShowDialog();
            }
        }
    }
}
