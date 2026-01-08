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
        // form açılışı: bileşenleri hazırla, verileri yükle, geçmiş seferleri temizle
        public FormGiris()
        {
            InitializeComponent();

            VeriYonetimiServisi.VeriTabaniniBaslat();
            Veriler.personeller = VeriYonetimiServisi.PersonelleriYukle();
            Veriler.seferler = VeriYonetimiServisi.SeferleriYukle();
            Veriler.ucaklar = VeriYonetimiServisi.UcaklariYukle();
            Veriler.kullanicilar = VeriYonetimiServisi.KullanicilariYukle();

            // geçmiş seferleri sil
            GecmisSeferleriSil();
        }

        // tarihi geçmiş seferleri ve onlara bağlı rezervasyonları kaldır
        private void GecmisSeferleriSil()
        {
            DateTime bugun = DateTime.Now;
            List<Sefer> gecmisSeferler = Veriler.seferler.Where(s => s.SeferTarihi < bugun).ToList();

            foreach (Sefer sefer in gecmisSeferler)
            {
                // kullanıcılardaki ilgili rezervasyonları sil
                Veriler.kullanicilar.ForEach(k =>
                {
                    if (k is Musteri musteri && musteri.Rezervasyonlar != null)
                    {
                        musteri.Rezervasyonlar.RemoveAll(r => r.Sefer.SeferNo == sefer.SeferNo);
                    }
                });

                // seferi listeden kaldır
                Veriler.seferler.Remove(sefer);
            }

            // değişiklik varsa dosyaya yaz
            if (gecmisSeferler.Count > 0)
            {
                VeriYonetimiServisi.SeferleriKaydet(Veriler.seferler);
                VeriYonetimiServisi.KullanicilariKaydet(Veriler.kullanicilar);
            }
        }

        // giriş butonu: kullanıcıyı bul ve uygun panele geç
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string girilenKullaniciAdi = txtKullaniciAdi.Text;
            string girilenSifre = txtSifre.Text;

            Kullanici bulunanKullanici = Veriler.kullanicilar.FirstOrDefault(k =>
                k.KullaniciAdi == girilenKullaniciAdi &&
                k.Sifre == girilenSifre);

            if (bulunanKullanici != null)
            {
                // admin ise
                if (bulunanKullanici is Admin)
                {
                    MessageBox.Show("Admin girişi başarılı!");
                    AdminPaneli adminForm = new AdminPaneli(bulunanKullanici as Admin);
                    adminForm.Show();
                    this.Hide();
                }
                // müşteri ise
                else if (bulunanKullanici is Musteri)
                {
                    MessageBox.Show("Müşteri girişi başarılı!");
                    MusteriPaneli musteriForm = new MusteriPaneli(bulunanKullanici as Musteri);
                    musteriForm.Show();
                    this.Hide();
                }
            }
            else
            {
                // hatalı giriş
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // kayıt butonu: kayıt formunu aç
        private void kayitBtn_Click(object sender, EventArgs e)
        {
            FormKayıt kayitForm = new FormKayıt();
            kayitForm.Show();
            this.Hide();
        }
    }
}

