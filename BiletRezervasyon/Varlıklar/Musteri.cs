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

        public List<Rezervasyon> Rezervasyonlar { get; set; } = new List<Rezervasyon>();

    }
}
