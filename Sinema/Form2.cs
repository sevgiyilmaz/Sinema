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
    public partial class Form2 : Form
    {
        public Form2(PictureBox koltuk)
        {
            InitializeComponent();
            Koltuk = koltuk;
        }
        PictureBox Koltuk;
        private void Form2_Load(object sender, EventArgs e)
        {
            if (Koltuk.Tag != null)
            {
                txtAdSoyad.Text = (Koltuk.Tag as Seyirci).adSoyad;
                txtTCNo.Text = (Koltuk.Tag as Seyirci).TcNo;
                if ((Koltuk.Tag as Seyirci).cinsiyet)
                {
                    rbBayan.Checked = true;
                }
                else
                {
                    rbBay.Checked = true;
                }
            }
        }
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdSoyad.Text) || string.IsNullOrEmpty(txtTCNo.Text) || (!rbBay.Checked && !rbBayan.Checked))
            {
                MessageBox.Show("Bilgilerinizi Eksiksiz Girildiğinden Emin Olunuz...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Seyirci yeniseyirci = new Seyirci();
                yeniseyirci.adSoyad = txtAdSoyad.Text;
                try
                {
                    yeniseyirci.TcNo = txtTCNo.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("Tc Kimlik Numaranız 11 haneli olmalıdır....", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                yeniseyirci.cinsiyet = rbBayan.Checked;
                Koltuk.Tag = yeniseyirci;
                Koltuk.Image = Image.FromFile(@"..\..\Images\dolu.jpg");
                this.Close();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (Koltuk.Tag != null)
            {
                DialogResult iptal = MessageBox.Show("İptal Etmek İstediğinize Emin Misiniz...", "İPTAL,Bu İşlem Geri Alınamaz...", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (iptal == DialogResult.Yes)
                {
                    Koltuk.Tag = null;
                    Koltuk.Image = Image.FromFile(@"..\..\Images\bos.jpg");
                    this.Close();
                }
            }
        }

        private void txtTCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
