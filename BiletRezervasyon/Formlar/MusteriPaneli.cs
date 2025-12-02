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
        private void MusteriPencere_Load(object sender, EventArgs e)
        {
            seferlerDGV.DataSource = null;
            seferlerDGV.DataSource = Veriler.seferler;
            rezervasyonlarGDV.DataSource = null;
            rezervasyonlarGDV.DataSource = curMusteri.Rezervasyonlar;


        }

        void pencereyikisisellestir()
        {
            this.Text = $"Hoşgeldiniz, Sayın {curMusteri.Ad}";
        }

        private void rezerveEtBtn_Click(object sender, EventArgs e)
        {
            RezerveEt();
        }
       
        private void rezerveSilBtn_Click(object sender, EventArgs e)
        {
            RezervasyonSil();
        }
        
        private void rezervasyonGuncelleBtn_Click(object sender, EventArgs e)
        {
            RezervasyonGuncelle();
        }



       

        void RezerveEt()
        {
            if (koltukCMB.SelectedItem == null || seciliSefer == null)
            {
                MessageBox.Show("Lütfen bir koltuk seçin ve sefer seçtiğinizden emin olun.");
                return;
            }
            Rezervasyon yeniRezerve = new Rezervasyon(curMusteri, seciliSefer, (Koltuk)koltukCMB.SelectedItem);
            curMusteri.Rezervasyonlar.Add(yeniRezerve);
            ((Koltuk)koltukCMB.SelectedItem).DoluMu = true;

            VerileriGuncelle();

            MessageBox.Show($"{yeniRezerve.Sefer}-{yeniRezerve.Koltuk}\r\nRezervasyon başarılı!");
        }

        void RezervasyonSil()
        {
            Rezervasyon silinenRez = seciliRezervasyon;
            curMusteri.Rezervasyonlar.Remove(seciliRezervasyon);
            seciliRezervasyon.Koltuk.DoluMu = false;
            VerileriGuncelle();
            MessageBox.Show($"{silinenRez.Sefer}-{silinenRez.Koltuk}\r\nRezervasyon silindi!");
        }


        void RezervasyonGuncelle()
        {
            seciliRezervasyon.Koltuk.DoluMu = false;
            Koltuk eskiKoltuk = seciliRezervasyon.Koltuk;
            seciliRezervasyon.Koltuk = (Koltuk)koltukCMB.SelectedItem;
            seciliRezervasyon.Koltuk.DoluMu = true;
            VerileriGuncelle();
            MessageBox.Show($"{eskiKoltuk} -> {seciliRezervasyon.Koltuk}\r\nKoltuğunuz Güncellendi.");


        }

        private void rezervasyonlarGDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                seciliRezervasyon = null;
                rezerveSilBtn.Enabled = false;
                rezervasyonGuncelleBtn.Enabled = false;
                return;
            }
            seciliRezervasyon = (Rezervasyon)rezervasyonlarGDV.Rows[e.RowIndex].DataBoundItem;

            if (seciliRezervasyon != null)
            {
                rezervasyonGuncelleBtn.Enabled = true;
                rezerveSilBtn.Enabled = true;
                rezerveEtBtn.Enabled = false;
                koltukCMB.Items.Clear();
                koltukCMB.Items.AddRange(seciliRezervasyon.Sefer.Koltuklar.Where(a => !a.DoluMu).ToArray());
                koltukCMB.Items.Add(seciliRezervasyon.Koltuk);
                koltukCMB.SelectedItem = seciliRezervasyon.Koltuk;


            }
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
                koltukCMB.Items.Clear();
                koltukCMB.Items.AddRange(seciliSefer.Koltuklar.Where(a => !a.DoluMu).ToArray()); //bos koltuklari comboboxa ekle
                rezervasyonGuncelleBtn.Enabled = false;
                rezerveSilBtn.Enabled = false;

            }
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

       
        
    }
}
