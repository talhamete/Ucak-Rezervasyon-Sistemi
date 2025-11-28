using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Varlıklar
{
    public class Rezervasyon
    {
        public int RezervasyonId { get; set; }
        public Sefer Sefer { get; set; }
        public DateTime RezervasyonTarihi { get; set; }
        public Koltuk Koltuk { get; set; }

        public Rezervasyon() { } 

        public Rezervasyon(Musteri musteri, Sefer sefer, Koltuk koltuk)
        {
            Random rnd = new Random();
            this.RezervasyonId = rnd.Next(10000, 99999);
            this.Sefer = sefer;
            this.RezervasyonTarihi = DateTime.Now;
            this.Koltuk = koltuk;
        }


    }
}
