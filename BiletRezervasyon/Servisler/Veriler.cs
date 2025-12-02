using BiletRezervasyon.Varlıklar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Servisler
{
    public static class Veriler
    {
        public static List<Personel> personeller = new List<Personel>();
        public static List<Sefer> seferler = new List<Sefer>();
        public static List<Ucak> ucaklar = new List<Ucak>();
        public static List<Kullanici> kullanicilar = new List<Kullanici>();
        public static string[] _sehirler = {
        "İstanbul", "Ankara", "İzmir", "Antalya",       // örnek şehirler
        "Adana", "Trabzon", "Bursa", "Gaziantep", "Konya"
    };


    }
}
