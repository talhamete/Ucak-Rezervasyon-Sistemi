using BiletRezervasyon.Servisler;
using System.Linq;

namespace BiletRezervasyon.Varlıklar
{
    public class Admin : Kullanici
    {
        // Sefer işlemleri
        public void SeferEkle(Sefer sefer)
        {
            Veriler.seferler.Add(sefer);
            VeriYonetimiServisi.SeferleriKaydet(Veriler.seferler);
        }

        public void SeferSil(Sefer sefer)
        {
            Veriler.seferler.Remove(sefer);
            VeriYonetimiServisi.SeferleriKaydet(Veriler.seferler);

            // Sefer silinince müşterilerdeki rezervasyonları temizle
            Veriler.kullanicilar.ForEach(k =>
            {
                if (k is Musteri m && m.Rezervasyonlar != null)
                {
                    m.Rezervasyonlar.RemoveAll(r => r.Sefer.SeferNo == sefer.SeferNo);
                }
            });
            VeriYonetimiServisi.KullanicilariKaydet(Veriler.kullanicilar);
        }

        public void SeferGuncelle(Sefer sefer, Sefer yeniSefer)
        {
            sefer.SeferTarihi = yeniSefer.SeferTarihi;
            sefer.Ucak = yeniSefer.Ucak;
            sefer.Rota = yeniSefer.Rota;
            sefer.KabinMemurlari = yeniSefer.KabinMemurlari;
            sefer.Pilot = yeniSefer.Pilot;
            sefer.BaseFiyat = yeniSefer.BaseFiyat;
            VeriYonetimiServisi.SeferleriKaydet(Veriler.seferler);
        }

        // Kullanıcı işlemleri
        public void KullaniciEkle(Kullanici kullanici)
        {
            var list = VeriYonetimiServisi.KullanicilariYukle();
            list.Add(kullanici);
            VeriYonetimiServisi.KullanicilariKaydet(list);
            Veriler.kullanicilar = list;
        }

        public void KullaniciSil(Kullanici hedef)
        {
            // Müşteri ise rezervasyonları ve koltukları temizle
            if (hedef is Musteri musteri && musteri.Rezervasyonlar != null)
            {
                foreach (var rezervasyon in musteri.Rezervasyonlar.ToList())
                {
                    if (rezervasyon.Koltuk != null && rezervasyon.Sefer != null)
                    {
                        var sefer = Veriler.seferler.FirstOrDefault(s => s.SeferNo == rezervasyon.Sefer.SeferNo);
                        if (sefer != null)
                        {
                            var koltuk = sefer.Koltuklar.FirstOrDefault(k => k.KoltukNo == rezervasyon.Koltuk.KoltukNo);
                            if (koltuk != null)
                            {
                                koltuk.DoluMu = false;
                            }
                        }
                    }
                }
                musteri.Rezervasyonlar.Clear();
            }

            // Kullanıcıyı doğrudan Veriler.kullanicilar'dan sil
            Veriler.kullanicilar.Remove(hedef);
            VeriYonetimiServisi.KullanicilariKaydet(Veriler.kullanicilar);
            VeriYonetimiServisi.SeferleriKaydet(Veriler.seferler);
        }

        // Uçak işlemleri
        public void UcakEkle(Ucak ucak)
        {
            var list = VeriYonetimiServisi.UcaklariYukle();
            list.Add(ucak);
            VeriYonetimiServisi.UcaklariKaydet(list);
            Veriler.ucaklar = list;
        }

        public void UcakGuncelle(Ucak hedef, string model, int kapasite, string kuyrukNo)
        {
            hedef.Model = model;
            hedef.Kapasite = kapasite;
            hedef.KuyrukNo = kuyrukNo;
            VeriYonetimiServisi.UcaklariKaydet(Veriler.ucaklar);
        }

        public void UcakSil(Ucak ucak)
        {
            // Bu uçağa bağlı seferleri bul ve rezervasyonları temizle
            var etkilenenSeferler = Veriler.seferler.Where(s => s.Ucak.UcakID == ucak.UcakID).ToList();

            foreach (var sefer in etkilenenSeferler)
            {
                // Müşterilerdeki bu sefere ait rezervasyonları kaldır
                foreach (var musteri in Veriler.kullanicilar.OfType<Musteri>())
                {
                    musteri.Rezervasyonlar?.RemoveAll(r => r.Sefer.SeferNo == sefer.SeferNo);
                }

                // Koltukları boşalt
                foreach (var koltuk in sefer.Koltuklar)
                {
                    koltuk.DoluMu = false;
                }
            }

            // Seferleri sil
            foreach (var sefer in etkilenenSeferler)
            {
                Veriler.seferler.Remove(sefer);
            }
            VeriYonetimiServisi.SeferleriKaydet(Veriler.seferler);

            // Uçağı sil
            Veriler.ucaklar.Remove(ucak);
            VeriYonetimiServisi.UcaklariKaydet(Veriler.ucaklar);

            // Kullanıcı kayıtlarını güncelle
            VeriYonetimiServisi.KullanicilariKaydet(Veriler.kullanicilar);
        }

        // Personel işlemleri
        public void PersonelEkle(Personel personel)
        {
            var list = VeriYonetimiServisi.PersonelleriYukle();
            list.Add(personel);
            VeriYonetimiServisi.PersonelleriKaydet(list);
            Veriler.personeller = list;
        }

        public void PersonelGuncelle(Personel hedef, string ad, string soyad)
        {
            hedef.Ad = ad;
            hedef.Soyad = soyad;
            VeriYonetimiServisi.PersonelleriKaydet(Veriler.personeller);
        }

        public void PersonelSil(Personel personel)
        {
            Veriler.personeller.Remove(personel);
            VeriYonetimiServisi.PersonelleriKaydet(Veriler.personeller);
        }
    }
}

