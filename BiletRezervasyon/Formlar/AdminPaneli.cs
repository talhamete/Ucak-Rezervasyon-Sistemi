using BiletRezervasyon.Servisler;
using BiletRezervasyon.Varlıklar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            cmbKabinM.Items.AddRange(
                VeriYonetimiServisi.PersonelleriYukle()
                    .Where(p => p is KabinMemuru)
                    .Select(p => p.Ad + " " + p.Soyad)
                    .ToArray()
            );
            cmbPilot.Items.AddRange(
                VeriYonetimiServisi.PersonelleriYukle()
                    .Where(p => p is Pilot)
                    .Select(p => p.Ad + " " + p.Soyad)
                    .ToArray()
            );
            cmbUcak.Items.AddRange(
                VeriYonetimiServisi.UcaklariYukle()
                    .Select(u => u.KuyrukNo)
                    .ToArray()
            );




        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kabinMLB.Items.Remove(kabinMLB.SelectedItem);
        }

        private void kabinMEkle_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbKabinM.SelectedIndex;

            if (selectedIndex != -1)
            {
                var a = VeriYonetimiServisi.PersonelleriYukle().Where(p => p is KabinMemuru).ToArray()[selectedIndex];
                kabinMLB.Items.Add(a.Ad + " " + a.Soyad);

            }
        }

        private void cmbUcak_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbUcak.SelectedIndex;
            ucakKapasiteTB.Text = VeriYonetimiServisi.UcaklariYukle()[selectedIndex].Kapasite.ToString();
            ucakModelTB.Text = VeriYonetimiServisi.UcaklariYukle()[selectedIndex].Model.ToString();

        }

      
    }
}
