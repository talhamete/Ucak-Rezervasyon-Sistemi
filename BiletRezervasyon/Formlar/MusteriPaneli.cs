using BiletRezervasyon.Varlıklar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletRezervasyon.Formlar
{
    public partial class MusteriPaneli : Form
    {
        Kullanici kullanici;
        public MusteriPaneli(Kullanici kullanici)
        {
            this.kullanici = kullanici;
            InitializeComponent();
            pencereyikisisellestir();
        }


        void pencereyikisisellestir()
        {
            this.Text = $"Hoşgeldiniz, Sayın {kullanici.Ad}";
        }

        private void MusteriPencere_Load(object sender, EventArgs e)
        {
        }
    }
}
