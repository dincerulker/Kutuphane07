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
    public partial class HesabimForm : Form
    {
        private readonly Kullanici kullanici;
        private readonly KutuphaneYoneticisi kutuphaneYoneticisi;

        public HesabimForm(Kullanici kullanici, KutuphaneYoneticisi kutuphaneYoneticisi)
        {
            InitializeComponent();
            this.kullanici = kullanici;
            this.kutuphaneYoneticisi = kutuphaneYoneticisi;
            KullaniciBilgiDoldur();
            Listele();
        }

        private void KullaniciBilgiDoldur()
        {
            lblId.Text += $"\r\n {kullanici.Id}";
            lblAdSoyad.Text += $"\r\n {kullanici.AdSoyad}";
            lblKullaniciAdi.Text += $"\r\n {kullanici.KullaniciAdi}";
            lblParola.Text += $"\r\n {kullanici.Parola}";
            Listele();
        }

        private void Listele()
        {
            dgvKitaplar.DataSource = null;
            dgvKitaplar.DataSource = kullanici.OduncAlinanKitaplar != null ? kullanici.OduncAlinanKitaplar : null;
            dgvKitaplar.Columns[0].Visible = false;
            dgvKitaplar.Columns[1].HeaderText = "Kitap Adı";
            dgvKitaplar.Columns[2].Visible = false;
            dgvKitaplar.Columns[3].HeaderText = "Kitap Türü";
            dgvKitaplar.Columns[4].Visible = false;
            dgvKitaplar.Columns[5].Visible = false;
            dgvKitaplar.Columns[6].Visible = false;
            dgvKitaplar.Columns[7].HeaderText = "Ödünç Alma Tarihi";
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            Guid kitapId = ((Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem).Id;
            kutuphaneYoneticisi.KitapTeslimEt(kullanici, kitapId);
            Listele();
            // seçili kitabın ödün alma tarihini null yapacaz ve kullanıcının kitaplarından silecez
        }

        private void dgvKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count > 0)
            {
                Kitap kitap = ((Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem);
                dtpTeslimTarihi.Value = ((DateTime)kitap.OduncAlinmaTarihi).AddSeconds(10);
                
            }
        }

        
    }
}
