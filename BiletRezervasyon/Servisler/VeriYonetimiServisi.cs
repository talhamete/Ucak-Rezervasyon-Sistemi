using BiletRezervasyon.Varlıklar;
using System.Diagnostics.Metrics;
using System.IO;
using System.Text.Json;

namespace BiletRezervasyon.Servisler
{
    public static class VeriYonetimiServisi
    {
        
        private static readonly string _klasorYolu;
        private static readonly string _kullanicilarYolu;
        private static readonly string _personellerYolu;
        private static readonly string _ucaklarYolu;
        private static readonly string _seferlerYolu;

        static VeriYonetimiServisi()
        {
            
            _klasorYolu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "VeriTabani");

           
            if (!Directory.Exists(_klasorYolu))
            {
                Directory.CreateDirectory(_klasorYolu);
            }

          
            _kullanicilarYolu = Path.Combine(_klasorYolu, "Kullanicilar.json");
            _personellerYolu = Path.Combine(_klasorYolu, "Personeller.json");
            _ucaklarYolu = Path.Combine(_klasorYolu, "Ucaklar.json");
            _seferlerYolu = Path.Combine(_klasorYolu, "Seferler.json");
        }

     


        private static void Kaydet<T>(string dosyaYolu, List<T> veri)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(veri, options);
            File.WriteAllText(dosyaYolu, json);
        }

        private static List<T> Yukle<T>(string dosyaYolu)
        {
            if (!File.Exists(dosyaYolu)) return new List<T>();
            string json = File.ReadAllText(dosyaYolu);
            return JsonSerializer.Deserialize<List<T>>(json);
        }

      

        public static void KullanicilariKaydet(List<Kullanici> liste) => Kaydet(_kullanicilarYolu, liste);
        public static List<Kullanici> KullanicilariYukle() => Yukle<Kullanici>(_kullanicilarYolu);

        public static void PersonelleriKaydet(List<Personel> liste) => Kaydet(_personellerYolu, liste);
        public static List<Personel> PersonelleriYukle() => Yukle<Personel>(_personellerYolu);

        public static void UcaklariKaydet(List<Ucak> liste) => Kaydet(_ucaklarYolu, liste);
        public static List<Ucak> UcaklariYukle() => Yukle<Ucak>(_ucaklarYolu);

        public static void SeferleriKaydet(List<Sefer> liste) => Kaydet(_seferlerYolu, liste);
        public static List<Sefer> SeferleriYukle() => Yukle<Sefer>(_seferlerYolu);

     
        public static void VeriTabaniniBaslat()
        {
            
            if (!File.Exists(_ucaklarYolu))
            {
                // 1. UÇAKLARI OLUŞTUR
                var ucaklar = new List<Ucak>
                {
                    new Ucak { UcakID = 1, Model = "Boeing 737-800", Kapasite = 189, KuyrukNo = "TC-JHK" },
                    new Ucak { UcakID = 2, Model = "Airbus A320", Kapasite = 150, KuyrukNo = "TC-DBG" },
                    new Ucak { UcakID = 3, Model = "Boeing 777", Kapasite = 300, KuyrukNo = "TC-JJJ" }
                };
                UcaklariKaydet(ucaklar);

                // 2. PERSONELLERİ OLUŞTUR
                var personeller = new List<Personel>
                {
                    new Pilot { ID=1, Ad="Ahmet", Soyad="Kaptan" },
                    new Pilot { ID=2, Ad="Ayşe", Soyad="Gökçen" },
                    new KabinMemuru { ID=3, Ad="Mehmet", Soyad="Yılmaz" },
                    new KabinMemuru { ID=4, Ad="Zeynep", Soyad="Kaya" },
                    new KabinMemuru { ID=5, Ad="Can", Soyad="Demir" }
                };
                PersonelleriKaydet(personeller);

                // 3. KULLANICILARI OLUŞTUR
                var kullanicilar = new List<Kullanici>
                {
                    new Admin { ID=1, KullaniciAdi="admin", Sifre="123", Ad="System", Soyad="Admin" },
                    new Musteri { ID=2, KullaniciAdi="musteri", Sifre="123", Ad="Ali", Soyad="Veli", TcNo="11111111111" }
                };
                KullanicilariKaydet(kullanicilar);
            }
        }
    }
}