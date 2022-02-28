using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA
{
    public class KullaniciYoneticisi
    {
        public static readonly string path = Environment.CurrentDirectory.Replace("Kutuphane07.UI\\bin\\Debug", "") + "kullaniciveri.json";
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
            if(parola == parolaTekrar)
            {
                Kullanicilar.Add(new Kullanici()
                {
                    AdSoyad = adSoyad,
                    KullaniciAdi = kullaniciAdi,
                    Parola = parola,
                });
                return true;
            }
            else
            {
                return false;
            }          
       
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
