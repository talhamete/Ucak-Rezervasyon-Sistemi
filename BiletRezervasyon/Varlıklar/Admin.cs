using BiletRezervasyon.Servisler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletRezervasyon.Varlıklar
{
    public class Admin : Kullanici
    {

        public void SeferEkle(Sefer sefer)
        {

                Veriler.seferler.Add(sefer);
                VeriYonetimiServisi.SeferleriKaydet(Veriler.seferler);

        }

        public void SeferSil(Sefer sefer)
        {

            Veriler.seferler.Remove(sefer);
            VeriYonetimiServisi.SeferleriKaydet(Veriler.seferler);
            Veriler.kullanicilar.ForEach(k =>
            {
                if(k is Musteri)
                if (((Musteri)k).Rezervasyonlar != null)            //Sefer silindiğin o sefere rezervasyon alanların rezervasyonlarını da siler
                    {                                                       
                        ((Musteri)k).Rezervasyonlar.RemoveAll(r => r.Sefer.SeferNo == sefer.SeferNo); 
                }
            });
            VeriYonetimiServisi.KullanicilariKaydet(Veriler.kullanicilar);


        }

        public void SeferGuncelle(Sefer sefer , Sefer yeniSefer)
        {

            sefer.SeferTarihi = yeniSefer.SeferTarihi;
            sefer.Ucak = yeniSefer.Ucak;
            sefer.Rota = yeniSefer.Rota;
            sefer.KabinMemurlari = yeniSefer.KabinMemurlari;
            sefer.Pilot = yeniSefer.Pilot;
            sefer.BaseFiyat = yeniSefer.BaseFiyat;
            VeriYonetimiServisi.SeferleriKaydet(Veriler.seferler);
        }






    }




    }

