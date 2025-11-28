namespace BiletRezervasyon.Varlıklar
{
    public class Sefer
    {
        public int SeferNo { get; set; }
        public DateTime SeferTarihi { get; set; }
        public Ucak Ucak { get; set; }
        public Rota Rota { get; set; }
        public List<KabinMemuru> KabinMemurlari{ get; set; }
        public Pilot Pilot { get; set; }

        public List<Koltuk> Koltuklar { get; set; }

        public Sefer(DateTime tarih, Ucak ucak, Rota rota, List<KabinMemuru> kabinMemurlari , Pilot pilot)
        {

            Random rnd = new Random();
            this.SeferNo = rnd.Next(1000, 9999);

            this.SeferTarihi = tarih;
            this.Ucak = ucak;
            this.Rota = rota;
            this.KabinMemurlari = kabinMemurlari;
            this.Pilot = pilot;
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
        public override string ToString()
        {
            return SeferNo.ToString();
        }

    }
}

