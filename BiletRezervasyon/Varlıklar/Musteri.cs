using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Varlıklar
{
    public class Musteri : Kullanici
    {
        private string _tcNo;

        private string _telefonNo;

        public void RezerveEt(Rezervasyon rezervasyon)
        {
        
            Rezervasyonlar.Add(rezervasyon);
            rezervasyon.Koltuk.DoluMu = true;

        }

        public void RezervasyonSil(Rezervasyon rezervasyon)
        {
            Rezervasyonlar.Remove(rezervasyon);
            rezervasyon.Koltuk.DoluMu = false;
           
        }

        public void RezervasyonGuncelle(Rezervasyon rezervasyon , Koltuk yeniKoltuk)
        {
            rezervasyon.Koltuk.DoluMu = false;
            rezervasyon.Koltuk = yeniKoltuk;
            rezervasyon.Koltuk.DoluMu = true;
            


        }


        public string TcNo
        {
            get { return _tcNo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("TC Kimlik Numarası boş olamaz!");
                }
                else if (value.Length != 11)
                {
                    throw new ArgumentException("TC Kimlik Numarası 11 haneli olmalıdır!");
                }
                else if (!value.All(char.IsDigit))
                {
                    throw new ArgumentException("TC Kimlik Numarası rakamlardan oluşmalıdır!");
                }
                else { _tcNo = value; }
                
     
            }
        }

        public string TelefonNo
        {
            get { return _telefonNo; }
            set
            {
                // boşsa hata
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Telefon numarası boş olamaz!");
                }

                // sadece rakam olmalı
                if (!value.All(char.IsDigit))
                {
                    throw new ArgumentException("Telefon numarası sadece rakamlardan oluşmalıdır!");
                }

                
                // 11 hane olmalı
                if (value.Length != 11)
                {
                    throw new ArgumentException("Telefon numarası başında '0' ile birlikte 11 haneli olmalıdır! (Örn: 05xxxxxxxxx)");
                }

                // hepsini geçtiyse ata
                _telefonNo = value;
            }
        }

        public List<Rezervasyon> Rezervasyonlar { get; set; } = new List<Rezervasyon>();


    }
}
