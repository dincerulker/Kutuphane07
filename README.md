### Yap�lacaklar
- [ ]Data katmanlar�na ilgili classlar�n olu�turulmas�.
  - Kitap
    - Id Guid( constructor'da otomatik de�er atans�n)
    - Ad string
    - Bas�mTarihi DateTime
    - KitapTurEnum KitapTuru
    - YazarAd string
    - SayfaSayisi int
    - Aciklama string
  - KitapTurEnum
    - E�itim,Psikoloji,Korku...
  - Kullan�c�
    - Id Guid( constructor'da otomatik de�er atans�n)
    - AdSoyad string
    - KullaniciAdi string
    - Parola string
    - List< Kitap > OduncAlinanKitaplar
  - Kullan�c�Yoneticisi
    - Kullan�c�lar listesi olmal� ve t�m i�lemler bu liste �zerinden yap�lmal�
    - KayitOl metodu
    - GirisYap metodu
    - KullaniciVarMi metodu
  - K�t�phaneYoneticisi
    - Kitap listesi olmal� ve t�m i�lemler bu liste �zerinden yap�lmal� 
    - KitapBagisYap metodu
    - KitapImhaEt metodu
    - KitapOduncAl metodu parametre kullan�c� ve kitap
- [ ]Register ve Login sayfalar�n�n tasarlanmas�
  - G�rsel tasar�m�n yap�lmas�
  - Register sayfas�nda parola e�le�me kontrol�
  - Ayn� kullan�c� ad�na sahip ki�i var m�?
  - Register ve Login i�lemleri metotlar kullan�larak 
  - Login ba�ar�l�ysa Kutuphane.Form a��ls�n
  - Login form a��l�rken ve kapan�rken KullaniciYoneticisini serialize ve deserialize ediniz

