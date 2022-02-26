using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA
{
    public class KutuphaneYoneticisi
    {
        public KutuphaneYoneticisi()
        {
            Kitaplar = new List<Kitap>();
        }
        public List<Kitap> Kitaplar { get; set; }
        public void KitapBagisYap(string ad,DateTime basimTarihi,KitapTurEnum kitapTur,string yazarAd,int sayfaSayisi,string aciklama)
        {

        }
        public void KitapImhaEt(Guid kitapId)
        {

        }
        public void KitapOduncAl(Kullanici kullanici,Guid kitapId)
        {
            // TODO kutuphaneden kitabı silip,kullanıcının oduncAlinanKitaplarına ekleyecez.
        }

    }
}
