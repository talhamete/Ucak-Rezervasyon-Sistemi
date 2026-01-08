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

        // kayıt ol: alanları kontrol et, müşteri oluştur, kaydet, girişe dön
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            // boş alan var mı
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

            // kullanıcı adı daha önce alınmış mı
            if (Veriler.kullanicilar.Any(k => k.KullaniciAdi == txtKullaniciAdi.Text))
            {
                MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // yeni müşteri oluştur
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

                // listeye ekle ve kaydet
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

                // girişe dön
                FormGiris girisForm = new FormGiris();
                girisForm.Show();
                this.Close();
            }
            catch (ArgumentException ex)
            {
                // alan doğrulama hatası
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // beklenmeyen hata
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // geri dön: giriş formunu aç
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            FormGiris girisForm = new FormGiris();
            girisForm.Show();
            this.Close();
        }
    }
}
