using System;
using System.Collections.Generic;
using System.Linq;

namespace BiletRezervasyon.Varlıklar
{
    public class Sefer
    {
        public int SeferNo { get; set; }
        public DateTime SeferTarihi { get; set; }
        public Ucak Ucak { get; set; }
        public Rota Rota { get; set; }
        public List<KabinMemuru> KabinMemurlari { get; set; }
        public Pilot Pilot { get; set; }
        public List<Koltuk> Koltuklar { get; set; }
        public decimal BaseFiyat { get; set; } // Yeni: Base fiyat
        
        // Dinamik fiyat hesaplama property'si
        public decimal GuncelFiyat
        {
            get
            {
                return FiyatHesapla();
            }
        }

        public Sefer(DateTime tarih, Ucak ucak, Rota rota, List<KabinMemuru> kabinMemurlari, Pilot pilot, decimal baseFiyat = 1000)
        {
            Random rnd = new Random();
            this.SeferNo = rnd.Next(1000, 9999);
            this.SeferTarihi = tarih;
            this.Ucak = ucak;
            this.Rota = rota;
            this.KabinMemurlari = kabinMemurlari;
            this.Pilot = pilot;
            this.BaseFiyat = baseFiyat;
            this.Koltuklar = new List<Koltuk>();
            
            for (int i = 1; i <= ucak.Kapasite; i++)
            {
                Koltuk koltuk = new Koltuk(i);
                this.Koltuklar.Add(koltuk);
            }
        }

        public Sefer()
        {
        }

        // Dinamik fiyatlandırma
        private decimal FiyatHesapla()
        {
            decimal fiyat = BaseFiyat;
            
            //Kalan koltuk sayısına göre fiyat artışı
            int kalanKoltukSayisi = Koltuklar.Count(k => !k.DoluMu);
            int toplamKapasite = Ucak.Kapasite;
            decimal dolulukOrani = 1 - ((decimal)kalanKoltukSayisi / toplamKapasite);
            
            // %0-50 doluluk: normal fiyat
            // %50-75 doluluk: %20 artış
            // %75-90 doluluk: %40 artış
            // %90+ doluluk: %60 artış
            if (dolulukOrani > 0.90m)
                fiyat *= 1.60m;
            else if (dolulukOrani > 0.75m)
                fiyat *= 1.40m;
            else if (dolulukOrani > 0.50m)
                fiyat *= 1.20m;
            
            //Sefer tarihine kalan gün sayısına göre fiyat
            int kalanGun = (SeferTarihi.Date - DateTime.Now.Date).Days;
            
            // 30+ gün: %10 indirim
            // 15-30 gün: normal fiyat
            // 7-15 gün: %15 artış
            // 3-7 gün: %30 artış
            // 0-3 gün: %50 artış
            if (kalanGun >= 30)
                fiyat *= 0.90m;
            else if (kalanGun >= 15 && kalanGun < 30)
                fiyat *= 1.00m; // Normal fiyat
            else if (kalanGun >= 7 && kalanGun < 15)
                fiyat *= 1.15m;
            else if (kalanGun >= 3 && kalanGun < 7)
                fiyat *= 1.30m;
            else if (kalanGun >= 0 && kalanGun < 3)
                fiyat *= 1.50m;
           
            
            return Math.Round(fiyat, 2);
        }
        
        // Fiyat bilgisini detaylı göstermek için
        public string FiyatDetayiGetir()
        {
            int kalanKoltuk = Koltuklar.Count(k => !k.DoluMu);
            int kalanGun = (SeferTarihi.Date - DateTime.Now.Date).Days;
            decimal dolulukOrani = 1 - ((decimal)kalanKoltuk / Ucak.Kapasite);
            
            return $"Base Fiyat: {BaseFiyat:C2}\n" +
                   $"Güncel Fiyat: {GuncelFiyat:C2}\n" +
                   $"Kalan Koltuk: {kalanKoltuk}/{Ucak.Kapasite}\n" +
                   $"Doluluk Oranı: %{dolulukOrani * 100:F0}\n" +
                   $"Kalan Gün: {kalanGun}";
        }

        public override string ToString()
        {
            return $"{SeferNo}";
        }
    }
}

