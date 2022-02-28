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
    public partial class KutuphaneForm : Form
    {
        private readonly Kullanici girisYapan;
        KutuphaneYoneticisi kutuphaneYoneticisi;

        public KutuphaneForm(Kullanici girisYapan)
        {
            InitializeComponent();
            this.girisYapan = girisYapan;
            TurleriYukle();

        }
        private void dgvKitaplar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int position = dgvKitaplar.HitTest(e.X, e.Y).RowIndex; // mouse ile bstığımız yerdeki konum bilgisini veriyor. Row da satırın indexini veriyor.
                if (position >= 0)
                {
                    contextMenuStrip1.Show(dgvKitaplar, new Point(e.X, e.Y));
                    dgvKitaplar.Rows[position].Selected = true; // sağ clik yaptığımız satır seçili olsun diye yazdık.
                }
            }
        }
        private void TurleriYukle()
        {
            cmbTurler.Items.Add("Hepsi");
            cmbTurler.Items.AddRange(Enum.GetValues(typeof(KitapTurEnum)).Cast<object>().ToArray());
            cmbTurler.SelectedIndex = 0;
        }
        private void KutuphaneForm_Load(object sender, EventArgs e)
        {
            kutuphaneYoneticisi = new KutuphaneYoneticisi();
            Listele();
        }

        private void Listele()
        {
            dgvKitaplar.DataSource = null;
            dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar.Where(x=>x.OduncAlinmaTarihi == null).ToList(); // ödünç alınmayanları getirdik
            dgvKitaplar.Columns[0].Visible = false;
            dgvKitaplar.Columns[1].HeaderText = "Kitap Adı";
            dgvKitaplar.Columns[2].HeaderText = "Basım Tarihi";
            dgvKitaplar.Columns[3].HeaderText = "Kitap Türü";
            dgvKitaplar.Columns[4].HeaderText = "Yazar Ad";
            dgvKitaplar.Columns[5].HeaderText = "Sayfa Sayısı";
            dgvKitaplar.Columns[6].HeaderText = "Açıklama";
            dgvKitaplar.Columns[7].Visible = false;



        }
        private void tsmiHesabim_Click(object sender, EventArgs e)
        {
            //TODO hesabımform aç
            HesabimForm hesabimForm = new HesabimForm(girisYapan);
            hesabimForm.ShowDialog();
        }

        private void tsmiBagisYap_Click(object sender, EventArgs e)
        {
            //TODO bagisyap form aç
        }

        private void tsmiCıkısYap_Click(object sender, EventArgs e)
        {
            // TODO kutuphaneyoneticisini kaydet
            Close();
        }

        private void tsmiKitapOduncAl_Click(object sender, EventArgs e)
        {
            //TODO kitap ödünç alma islemleri
        }

        private void tsmiKitapImhaEt_Click(object sender, EventArgs e)
        {
            //TODO listeden kitabı bularak silecez.
        }
    }
}
