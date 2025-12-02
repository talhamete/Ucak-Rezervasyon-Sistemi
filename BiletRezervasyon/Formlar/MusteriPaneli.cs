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
            VerileriGuncelle();


        }

        void pencereyikisisellestir() // kişiselleştiren fonksiyon
        {
            this.Text = $"Hoşgeldiniz, Sayın {curMusteri.Ad}";
        }

        private void rezerveEtBtn_Click(object sender, EventArgs e) // rezervasyon ekleme butonu
        {

            if (koltukCMB.SelectedItem == null || seciliSefer == null)
            {
                MessageBox.Show("Lütfen bir koltuk seçin ve sefer seçtiğinizden emin olun.");
                return;
            }
            
            Rezervasyon yeniRezerve = new Rezervasyon(curMusteri, seciliSefer, (Koltuk)koltukCMB.SelectedItem);
            
            curMusteri.RezerveEt(yeniRezerve);
            VerileriGuncelle();
            MessageBox.Show($"{yeniRezerve.Sefer}-{yeniRezerve.Koltuk}\r\nRezervasyon başarılı!");

        }
       
        private void rezerveSilBtn_Click(object sender, EventArgs e) // rezervasyon silme butonu
        {
            Rezervasyon silinenRez = seciliRezervasyon;

            curMusteri.RezervasyonSil(silinenRez);
            VerileriGuncelle();
            MessageBox.Show($"{silinenRez.Sefer}-{silinenRez.Koltuk}\r\nRezervasyon silindi!");
        }
        
        private void rezervasyonGuncelleBtn_Click(object sender, EventArgs e) // rezervasyon güncelleme butonu
        {
            Koltuk eskiKoltuk = seciliRezervasyon.Koltuk;
            curMusteri.RezervasyonGuncelle(seciliRezervasyon, (Koltuk)koltukCMB.SelectedItem);
            VerileriGuncelle();
            MessageBox.Show($"{eskiKoltuk} -> {seciliRezervasyon.Koltuk}\r\nKoltuğunuz Güncellendi.");


        }


        void Temizle() // cmbleri temizler
        {
            koltukCMB.SelectedItem = null;

        }
       


        private void rezervasyonlarGDV_CellClick(object sender, DataGridViewCellEventArgs e) // rezervasyon seçildiğinde çalışan, secili rezervasyonu atayan ve ona göre koltukCMB yi dolduran fonksiyon
        {
            if (e.RowIndex < 0)
            {
                seciliRezervasyon = null;
                rezerveSilBtn.Enabled = false;
                rezervasyonGuncelleBtn.Enabled = false;
                rezervasyonlarGDV.ClearSelection();
               
            }
            else
            {
                seciliRezervasyon = (Rezervasyon)rezervasyonlarGDV.Rows[e.RowIndex].DataBoundItem;

            }

            if (seciliRezervasyon != null)
            {
                rezervasyonGuncelleBtn.Enabled = true;
                rezerveSilBtn.Enabled = true;
                rezerveEtBtn.Enabled = false;
                koltukCMB.Items.Clear();
                koltukCMB.Items.AddRange(seciliRezervasyon.Sefer.Koltuklar.Where(a => !a.DoluMu).ToArray());
                koltukCMB.Items.Add(seciliRezervasyon.Koltuk);
                koltukCMB.SelectedItem = seciliRezervasyon.Koltuk;
                seferlerDGV.ClearSelection();


            }
        }

        private void seferlerDGV_CellClick(object sender, DataGridViewCellEventArgs e) // sefer seçildiğinde çalışan, secili seferi atayan ve ona göre koltukCMB yi dolduran fonksiyon
        {
            if (e.RowIndex < 0)
            {

                rezerveEtBtn.Enabled = false;
                seciliSefer = null;
                koltukCMB.Items.Clear();
                seferlerDGV.ClearSelection();

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
                rezervasyonlarGDV.ClearSelection();

            }
        }


        void VerileriGuncelle()
        {
            VeriYonetimiServisi.KullanicilariKaydet(Veriler.kullanicilar);
            VeriYonetimiServisi.SeferleriKaydet(Veriler.seferler);
            seferlerDGV.DataSource = null;
            seferlerDGV.DataSource = Veriler.seferler;
            seferlerDGV.ClearSelection();
            rezervasyonlarGDV.DataSource = null;
            rezervasyonlarGDV.DataSource = curMusteri.Rezervasyonlar;
            rezervasyonlarGDV.ClearSelection();
            Temizle();

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
