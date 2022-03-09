using Kutuphane07.DATA;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane07.UI
{
    public partial class LoginForm : Form
    {
        KullaniciYoneticisi kullaniciYoneticisi;
        public LoginForm()
        {

            InitializeComponent();
            //Debug.WriteLine("*****************");
            //Debug.WriteLine(KullaniciYoneticisi.path);
            //Debug.WriteLine("*****************");


        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtParola.Text))
            {
                Kullanici girisYapanKullanici = kullaniciYoneticisi.GirisYap(txtKullaniciAdi.Text, txtParola.Text); // burada yeni kullanci oluşturup..
                if (girisYapanKullanici != null)
                {
                    KutuphaneForm kutuphaneForm = new KutuphaneForm(girisYapanKullanici); // ..burada kutuphane forma
                                                                                          // gönderiyoruz
                    kutuphaneForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı yada parola hatalı!.");
                }

            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adı yada parolanızı giriniz!");
            }
            txtParola.Text = "";

        }

        private void lnklblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(kullaniciYoneticisi); // yeni oluşturduğumuz
                                                                               // kullaniciYoneticisini gönderiyoruz
            registerForm.ShowDialog();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(kullaniciYoneticisi);
            File.WriteAllText(KullaniciYoneticisi.path, json);
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                string json = File.ReadAllText(KullaniciYoneticisi.path);
                kullaniciYoneticisi = JsonConvert.DeserializeObject<KullaniciYoneticisi>(json);
            }
            catch (Exception)
            {
                kullaniciYoneticisi = new KullaniciYoneticisi();
            }
        }
    }
}
