using Kutuphane07.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane07.UI
{
    public partial class RegisterForm : Form
    {
        private readonly KullaniciYoneticisi kullaniciYoneticisi;

        public RegisterForm(KullaniciYoneticisi kullaniciYoneticisi)
        {
            InitializeComponent();
            this.kullaniciYoneticisi = kullaniciYoneticisi;
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            bool kullaniciParolaKontrol = KullaniciAdiKontrol();
            bool kullaniciAdiKontrol = KullaniciParolaKontrol();
            bool adSoyadKontrol = AdSoyadKontrol();
            if (kullaniciParolaKontrol && kullaniciAdiKontrol && adSoyadKontrol)
            {
                btnKayitOl.Enabled = true;
            }
            else
            {
                btnKayitOl.Enabled = false;
            }
        }

        private bool AdSoyadKontrol()
        {
            if (!string.IsNullOrEmpty(txtAdSoyad.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {
            bool kullaniciAdiKontrol = KullaniciParolaKontrol();
            bool kullaniciParolaKontrol =KullaniciAdiKontrol();
            bool adSoyadKontrol = AdSoyadKontrol();
            if (kullaniciParolaKontrol && kullaniciAdiKontrol && adSoyadKontrol)
            {
                btnKayitOl.Enabled = true;
            }
            else
            {
                btnKayitOl.Enabled = false;
            }
        }
        private bool KullaniciAdiKontrol()
        {
            bool KullaniciVarMi = kullaniciYoneticisi.KullaniciVarMi(txtKullaniciAdi.Text);
            if (KullaniciVarMi || string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                txtKullaniciAdi.ForeColor = Color.Red;
                return false;
            }
            else
            {
                txtKullaniciAdi.ForeColor = Color.Green;
                return true;

            }
        }

        private bool KullaniciParolaKontrol()
        {
            if (txtParola.Text != txtParolaTekrar.Text || string.IsNullOrEmpty(txtParola.Text) || string.IsNullOrEmpty(txtParolaTekrar.Text))
            {
                txtParola.ForeColor = Color.Red;
                lblParolaKontrol.Text = "Parola geçersiz!";
                return false;
            }
            else
            {
                txtParola.ForeColor = Color.Red;
                lblParolaKontrol.Text = "Parola uygun!";
                return true;
            }
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            bool kullaniciAdiKontrol = KullaniciParolaKontrol();
            bool kullaniciParolaKontrol = KullaniciAdiKontrol();
            bool adSoyadKontrol = AdSoyadKontrol();
            if (kullaniciParolaKontrol && kullaniciAdiKontrol && adSoyadKontrol)
            {
                btnKayitOl.Enabled = true;
            }
            else
            {
                btnKayitOl.Enabled = false;
            }

        }
    }
}
