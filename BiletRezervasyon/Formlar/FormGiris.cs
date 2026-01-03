using BiletRezervasyon.Servisler;
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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();

            VeriYonetimiServisi.VeriTabaniniBaslat();
            Veriler.personeller = VeriYonetimiServisi.PersonelleriYukle();
            Veriler.seferler = VeriYonetimiServisi.SeferleriYukle();
            Veriler.ucaklar = VeriYonetimiServisi.UcaklariYukle();
            Veriler.kullanicilar = VeriYonetimiServisi.KullanicilariYukle();

            // Tarihi geçmiş seferleri temizle
            GecmisSeferleriSil();
        }

        private void GecmisSeferleriSil()
        {
            DateTime bugun = DateTime.Now;
            List<Sefer> gecmisSeferler = Veriler.seferler.Where(s => s.SeferTarihi < bugun).ToList();

            foreach (Sefer sefer in gecmisSeferler)
            {
                // Rezervasyonları temizle
                Veriler.kullanicilar.ForEach(k =>
                {
                    if (k is Musteri musteri && musteri.Rezervasyonlar != null)
                    {
                        musteri.Rezervasyonlar.RemoveAll(r => r.Sefer.SeferNo == sefer.SeferNo);
                    }
                });

                // Seferi sil
                Veriler.seferler.Remove(sefer);
            }

            // Kaydet
            if (gecmisSeferler.Count > 0)
            {
                VeriYonetimiServisi.SeferleriKaydet(Veriler.seferler);
                VeriYonetimiServisi.KullanicilariKaydet(Veriler.kullanicilar);
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // Textbox'lardan verileri al
            string girilenKullaniciAdi = txtKullaniciAdi.Text;
            string girilenSifre = txtSifre.Text;

            //  Listemizde bu kullanıcıyı ara
            Kullanici bulunanKullanici = Veriler.kullanicilar.FirstOrDefault(k =>
                k.KullaniciAdi == girilenKullaniciAdi &&
                k.Sifre == girilenSifre);

            //  Kullanıcı bulundu mu?
            if (bulunanKullanici != null)
            {


                // rol kontrolü

                if (bulunanKullanici is Admin)
                {
                    // adminse
                    MessageBox.Show("Admin girişi başarılı!");
                    AdminPaneli adminForm = new AdminPaneli(bulunanKullanici as Admin);
                    adminForm.Show();
                    this.Hide();
                }
                else if (bulunanKullanici is Musteri)
                {
                    // müşteriyse
                    MessageBox.Show("Müşteri girişi başarılı!");
                    MusteriPaneli musteriForm = new MusteriPaneli(bulunanKullanici as Musteri); // Müşteri bilgisini diğer forma yolla
                    musteriForm.Show();
                    this.Hide();
                }
            }
            else
            {
                // Kullanıcı bulunamadı veya şifre yanlış
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {
            FormKayıt kayitForm = new FormKayıt();
            kayitForm.Show();
            this.Hide();
        }
    }


}

