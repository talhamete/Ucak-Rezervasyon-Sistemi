using BiletRezervasyon.Varlıklar;
using BiletRezervasyon.Servisler;
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
        Musteri curMusteri;
        Sefer seciliSefer;
        Rezervasyon seciliRezervasyon;
        public MusteriPaneli(Kullanici kullanici)
        {
            this.curMusteri = (Musteri)kullanici;
            InitializeComponent();
            pencereyikisisellestir();
        }


        void pencereyikisisellestir()
        {
            this.Text = $"Hoşgeldiniz, Sayın {curMusteri.Ad}";
        }

        private void MusteriPencere_Load(object sender, EventArgs e)
        {
            seferlerDGV.DataSource = null;
            seferlerDGV.DataSource = Veriler.seferler;
            rezervasyonlarGDV.DataSource = null;
            rezervasyonlarGDV.DataSource = curMusteri.Rezervasyonlar;


        }

        private void seferlerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                
                rezerveEtBtn.Enabled = false;
                seciliSefer = null;
                koltukCMB.Items.Clear();
                return;
            }
            seciliSefer = (Sefer)seferlerDGV.Rows[e.RowIndex].DataBoundItem;

            if (seciliSefer != null)
            {
                rezerveEtBtn.Enabled = true;
                koltukCMB.Items.AddRange(seciliSefer.Koltuklar.Where(a => !a.DoluMu).ToArray()); //bos koltuklari comboboxa ekle


            }
        }

        private void rezerveEtBtn_Click(object sender, EventArgs e)
        {
            if (koltukCMB.SelectedItem == null || seciliSefer == null)
            {
                MessageBox.Show("Lütfen bir koltuk seçin ve sefer seçtiğinizden emin olun.");
                return;
            }
            curMusteri.Rezervasyonlar.Add(new Rezervasyon(curMusteri, seciliSefer, (Koltuk)koltukCMB.SelectedItem));
            ((Koltuk)koltukCMB.SelectedItem).DoluMu = true;

            VerileriGuncelle();

            MessageBox.Show("Rezervasyon başarılı!");




        }
        void VerileriGuncelle()
        {
            VeriYonetimiServisi.KullanicilariKaydet(Veriler.kullanicilar);
            VeriYonetimiServisi.SeferleriKaydet(Veriler.seferler);
            seferlerDGV.DataSource = null;
            seferlerDGV.DataSource = Veriler.seferler;
            rezervasyonlarGDV.DataSource = null;
            rezervasyonlarGDV.DataSource = curMusteri.Rezervasyonlar;
            if (seciliSefer != null)
            {
                koltukCMB.Items.Clear();
                koltukCMB.Items.AddRange(seciliSefer.Koltuklar.Where(a => !a.DoluMu).ToArray()); //bos koltuklari comboboxa ekle

            }
            else
            {
                koltukCMB.Items.Clear();
            }

        }



        private void rezerveSilBtn_Click(object sender, EventArgs e)
        {
            curMusteri.Rezervasyonlar.Remove(seciliRezervasyon);
            seciliRezervasyon.Koltuk.DoluMu = false;
            VerileriGuncelle();
        }

        private void rezervasyonlarGDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                seciliRezervasyon = null;
                rezerveSilBtn.Enabled = false;
                return;
            }
            seciliRezervasyon = (Rezervasyon)rezervasyonlarGDV.Rows[e.RowIndex].DataBoundItem;

            if (seciliRezervasyon != null)
            {
                rezerveSilBtn.Enabled = true;

            }
        }

     
    }
}
