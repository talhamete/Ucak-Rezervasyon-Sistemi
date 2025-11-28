using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Varlıklar
{
    public class Koltuk
    {

        public bool DoluMu { get; set; } = false;

        public int KoltukNo { get; set; }

        public Koltuk(int koltukNo)
        {
            this.KoltukNo = koltukNo;
        }

        public override string ToString()
        {
            return KoltukNo.ToString();
        }
        
    }
}
