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
    public partial class FormKayıt : Form
    {
        public FormKayıt()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            // Temel doğrulama: boş alan kalmasın
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(txtTcNo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonNo.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcı adı benzersiz olmalı
            if (Veriler.kullanicilar.Any(k => k.KullaniciAdi == txtKullaniciAdi.Text))
            {
                MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Müşteri nesnesini doldur
                Musteri yeniMusteri = new Musteri
                {
                    ID = Veriler.kullanicilar.Count > 0 ? Veriler.kullanicilar.Max(k => k.ID) + 1 : 1,
                    Ad = txtAd.Text.Trim(),
                    Soyad = txtSoyad.Text.Trim(),
                    KullaniciAdi = txtKullaniciAdi.Text.Trim(),
                    Sifre = txtSifre.Text,
                    TcNo = txtTcNo.Text.Trim(),
                    TelefonNo = txtTelefonNo.Text.Trim()
                };

                // Listeye ekle ve kaydet
                Veriler.kullanicilar.Add(yeniMusteri);
                VeriYonetimiServisi.KullanicilariKaydet(Veriler.kullanicilar);

                MessageBox.Show(
                    $"Kayıt başarılı!\n\n" +
                    $"Hoş geldiniz {yeniMusteri.Ad} {yeniMusteri.Soyad}\n" +
                    $"Kullanıcı Adı: {yeniMusteri.KullaniciAdi}\n\n" +
                    $"Giriş ekranına yönlendiriliyorsunuz...",
                    "Başarılı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Giriş formuna geç
                FormGiris girisForm = new FormGiris();
                girisForm.Show();
                this.Close();
            }
            catch (ArgumentException ex)
            {
                // Girdi doğrulama hataları
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            // Giriş formuna geri dön
            FormGiris girisForm = new FormGiris();
            girisForm.Show();
            this.Close();
        }
    }
}
