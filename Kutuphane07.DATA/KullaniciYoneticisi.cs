using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA
{
    public class KullaniciYoneticisi
    {
        public KullaniciYoneticisi()
        {
            Kullanicilar = new List<Kullanici>()
            {
                new Kullanici(){AdSoyad = "Dinçer Ülker",
                KullaniciAdi = "ulkerdincer",
                Parola = "1234"}
            };
        }
        public List<Kullanici> Kullanicilar { get; set; }
        
        public bool KayitOl(string adSoyad, string kullaniciAdi,string parola, string parolaTekrar)
        {
            return true;
            
        }
        public Kullanici GirisYap(string kullaniciAdi,string parola)
        {

            return Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi && x.Parola == parola);
        }
        public bool KullaniciVarMi(string kullaniciAdi)
        {
            
            return  Kullanicilar.Any(x => x.KullaniciAdi == kullaniciAdi);
        }
    }
    
}
