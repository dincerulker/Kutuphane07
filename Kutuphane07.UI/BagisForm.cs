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
    public partial class BagisForm : Form
    {
        private readonly KutuphaneYoneticisi kutuphaneYoneticisi;

        public BagisForm(KutuphaneYoneticisi kutuphaneYoneticisi)
        {
            InitializeComponent();
            this.kutuphaneYoneticisi = kutuphaneYoneticisi;
            KitapTurYukle();
        }

        private void KitapTurYukle()
        {
            cmbTur.DataSource = Enum.GetValues(typeof(KitapTurEnum));
        }

        private void btnBagisYap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKitapAdi.Text) && !string.IsNullOrEmpty(txtYazar.Text))
            {
                kutuphaneYoneticisi.KitapBagisYap(
                    txtKitapAdi.Text,
                    dtpBasimTarihi.Value,
                    (KitapTurEnum)cmbTur.SelectedItem,
                    txtYazar.Text,
                    (int)nudSayfaSayisi.Value,
                    txtAciklama.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Kitap adı ve yazar adı yazmak zorunludur.");
            }
        }
    }
}
