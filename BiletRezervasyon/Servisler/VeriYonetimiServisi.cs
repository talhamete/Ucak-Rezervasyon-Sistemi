// Bu 'using' satırlarını dosyanın en üstüne eklemelisiniz.
using BiletRezervasyon.Varlıklar; // Admin, Musteri gibi sınıflarımız için
using System.Collections.Generic; // List<> için
using System.IO; // Dosya işlemleri (Okuma/Yazma) için
using System.Text.Json; // JSON işlemleri için

namespace BiletRezervasyon.Servisler
{
    public class VeriYonetimiServisi
    {
        // Kullanıcı verilerini saklayacağımız dosyanın adı.
        // Bu dosya .exe'nin yanına oluşturulacak.
        private const string _kullanicilarDosyaYolu = "kullanicilar.json";

        // İleride buraya uçuşlar için de bir yol ekleyeceğiz:
        // private const string _seferlerDosyaYolu = "seferler.json";


        // 1. VERİ KAYDETME METODU
        public void KullanicilariKaydet(List<Kullanici> kullanicilar)
        {
            // JsonSerializer, listemizi alır ve onu JSON formatında bir metne dönüştürür.
            string jsonString = JsonSerializer.Serialize(kullanicilar, new JsonSerializerOptions { WriteIndented = true });

            // Bu metni dosyaya yazar.
            File.WriteAllText(_kullanicilarDosyaYolu, jsonString);
        }

        // 2. VERİ YÜKLEME METODU
        public List<Kullanici> KullanicilariYukle()
        {
            // Program ilk kez çalışıyorsa ve dosya henüz yoksa?
            if (!File.Exists(_kullanicilarDosyaYolu))
            {
                // Dosya yoksa, bizim test verimizi oluştur
                List<Kullanici> testKullanicilari = new List<Kullanici>();
                testKullanicilari.Add(new Admin
                {
                    ID = 1,
                    KullaniciAdi = "admin",
                    Sifre = "123",
                    Ad = "Yönetici",
                    Soyad = "Sistem"
                });
                testKullanicilari.Add(new Musteri
                {
                    ID = 2,
                    KullaniciAdi = "musteri",
                    Sifre = "456",
                    Ad = "Ahmet",
                    Soyad = "Yılmaz",
                    TcNo = "11111111111"
                });

                // Bu test verisini hemen dosyaya kaydet (bir sonraki açılış için)
                KullanicilariKaydet(testKullanicilari);

                // Ve bu yeni listeyi geri döndür
                return testKullanicilari;
            }

            // Eğer dosya varsa:
            // Dosyadaki tüm JSON metnini oku
            string jsonString = File.ReadAllText(_kullanicilarDosyaYolu);

            // JSON metnini al ve onu tekrar List<Kullanici> nesnesine dönüştür
            return JsonSerializer.Deserialize<List<Kullanici>>(jsonString);
        }
    }
}