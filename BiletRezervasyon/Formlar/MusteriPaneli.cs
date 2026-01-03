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

        void pencereyikisisellestir()
        {
            // Pencere başlığını kullanıcıya göre ayarla
            this.Text = $"Hoşgeldiniz, Sayın {curMusteri.Ad}";
        }

        private void seferlerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Geçersiz satır tıklaması
            if (e.RowIndex < 0)
            {
                rezerveEtBtn.Enabled = false;
                seciliSefer = null;
                koltukCMB.Items.Clear();
                seferlerDGV.ClearSelection();
                FiyatBilgileriniTemizle();
                return;
            }

            seciliSefer = (Sefer)seferlerDGV.Rows[e.RowIndex].DataBoundItem;

            if (seciliSefer != null)
            {
                rezerveEtBtn.Enabled = true;
                koltukCMB.Items.Clear();
                koltukCMB.Items.AddRange(seciliSefer.Koltuklar.Where(a => !a.DoluMu).ToArray());
                rezervasyonGuncelleBtn.Enabled = false;
                rezerveSilBtn.Enabled = false;
                rezervasyonlarGDV.ClearSelection();

                // Seçilen sefere göre fiyat panelini güncelle
                FiyatBilgileriniGuncelle(seciliSefer);
            }
        }

        private void rezerveEtBtn_Click(object sender, EventArgs e) // rezervasyon ekleme butonu
        {
            if (koltukCMB.SelectedItem == null || seciliSefer == null)
            {
                MessageBox.Show("Lütfen bir koltuk seçin ve sefer seçtiğinizden emin olun.");
                return;
            }

            // Kullanıcıdan fiyat onayı al
            DialogResult onay = MessageBox.Show(
                $"Sefer: {seciliSefer.Rota}\n" +
                $"Koltuk: {koltukCMB.SelectedItem}\n" +
                $"Fiyat: {seciliSefer.GuncelFiyat:C2}\n\n" +
                $"Rezervasyonu onaylıyor musunuz?",
                "Rezervasyon Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                Rezervasyon yeniRezerve = new Rezervasyon(curMusteri, seciliSefer, (Koltuk)koltukCMB.SelectedItem);
                curMusteri.RezerveEt(yeniRezerve);
                VerileriGuncelle();

                // Sefer seçimi korunuyorsa fiyat panelini yenile
                if (seciliSefer != null)
                {
                    FiyatBilgileriniGuncelle(seciliSefer);
                }

                MessageBox.Show($"{yeniRezerve.Sefer} - {yeniRezerve.Koltuk}\n" +
                    $"Ödenen Fiyat: {yeniRezerve.OdenenFiyat:C2}\n" +
                    $"Rezervasyon başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            FiyatBilgileriniTemizle(); // Fiyat bilgilerini de temizle
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
                // Var olan rezervasyona göre koltukları ve fiyat panelini hazırla
                rezervasyonGuncelleBtn.Enabled = true;
                rezerveSilBtn.Enabled = true;
                rezerveEtBtn.Enabled = false;
                koltukCMB.Items.Clear();
                koltukCMB.Items.AddRange(seciliRezervasyon.Sefer.Koltuklar.Where(a => !a.DoluMu).ToArray());
                koltukCMB.Items.Add(seciliRezervasyon.Koltuk);
                koltukCMB.SelectedItem = seciliRezervasyon.Koltuk;
                seferlerDGV.ClearSelection();

                // Rezervasyondaki seferin fiyat bilgilerini göster
                FiyatBilgileriniGuncelle(seciliRezervasyon.Sefer);
            }
        }

        void VerileriGuncelle()
        {
            // Basit senkronizasyon: liste ve gridleri tazele
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
                koltukCMB.Items.AddRange(seciliSefer.Koltuklar.Where(a => !a.DoluMu).ToArray());
                FiyatBilgileriniGuncelle(seciliSefer); // Fiyat bilgilerini güncelle
            }
            else
            {
                koltukCMB.Items.Clear();
            }
        }

        private void FiyatBilgileriniGuncelle(Sefer sefer)
        {
            if (sefer != null)
            {
                int kalanKoltuk = sefer.Koltuklar.Count(k => !k.DoluMu);
                int kalanGun = (sefer.SeferTarihi.Date - DateTime.Now.Date).Days;

                // Fiyat etiketini kısa ve bilgilendirici tutalım
                fiyatlbl.Text = $"Fiyat: {sefer.GuncelFiyat:C2}\n" +
                                $"Base: {sefer.BaseFiyat:C2}\n" +
                                $"Koltuk: {kalanKoltuk}/{sefer.Ucak.Kapasite}\n" +
                                $"Gün: {kalanGun}";

                // Doluluk durumuna göre basit renk geri bildirimi
                if (kalanKoltuk <= 5)
                {
                    fiyatlbl.ForeColor = Color.FromArgb(245, 108, 108);
                }
                else if (kalanKoltuk <= 20)
                {
                    fiyatlbl.ForeColor = Color.FromArgb(230, 162, 60);
                }
                else
                {
                    fiyatlbl.ForeColor = Color.FromArgb(103, 194, 58);
                }
            }
        }

        private void FiyatBilgileriniTemizle()
        {
            fiyatlbl.Text = "Fiyat";
            fiyatlbl.ForeColor = Color.FromArgb(48, 49, 51);
        }

        private void hopeButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGiris girisForm = new FormGiris();
            girisForm.Show();
        }
    }
}
