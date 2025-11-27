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
    public partial class AdminPaneli : Form
    {
        Kullanici kullanici;
        private string[] _sehirler = {
        "İstanbul", "Ankara", "İzmir", "Antalya",
        "Adana", "Trabzon", "Bursa", "Gaziantep", "Konya"
    };
        public AdminPaneli()
        {
            InitializeComponent();
        }
        private void KutulariDoldur()
        {
            // ComboBox'lara şehirleri yükle
            cmbKalkis.Items.AddRange(_sehirler);
            cmbVaris.Items.AddRange(_sehirler);

            // İlk sıradakiler seçili gelsin (opsiyonel)
            cmbKalkis.SelectedIndex = 0;
            cmbVaris.SelectedIndex = 1;
        }
        public AdminPaneli(Kullanici kullanici)
        {
            this.kullanici = kullanici;
            InitializeComponent();
            pencereyiKisisellestir();
            KutulariDoldur();
        }

        void pencereyiKisisellestir()
        {
            this.Text = $"Hoşgeldiniz {kullanici.Ad} bey";
        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
