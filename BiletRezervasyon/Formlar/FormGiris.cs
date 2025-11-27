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
        private List<Kullanici> _kullaniciListesi;


        public FormGiris()
        {
            InitializeComponent();

            // 3. Servisimizi başlat
            VeriYonetimiServisi.VeriTabaniniBaslat();

            // 4. Test verisi oluşturmak yerine, VERİYİ YÜKLE!
            _kullaniciListesi = VeriYonetimiServisi.KullanicilariYukle();

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // 1. Textbox'lardan verileri al
            string girilenKullaniciAdi = txtKullaniciAdi.Text;
            string girilenSifre = txtSifre.Text;

            // 2. Listemizde bu kullanıcıyı ara (LINQ kullanıyoruz)
            Kullanici bulunanKullanici = _kullaniciListesi.FirstOrDefault(k =>
                k.KullaniciAdi == girilenKullaniciAdi &&
                k.Sifre == girilenSifre);

            // 3. Kullanıcı bulundu mu?
            if (bulunanKullanici != null)
            {
                // Kullanıcı bulundu! Şimdi ROL KONTROLÜ (Polymorphism)
                // Bu, Personel-Pilot listesindeki mantığın aynısı!

                if (bulunanKullanici is Admin)
                {
                    // BU BİR ADMİN
                    MessageBox.Show("Admin girişi başarılı!");
                    AdminPaneli adminForm = new AdminPaneli(bulunanKullanici as Admin);
                    adminForm.Show();
                    this.Hide(); // Giriş formunu gizle
                }
                else if (bulunanKullanici is Musteri)
                {
                    // BU BİR MÜŞTERİ
                    MessageBox.Show("Müşteri girişi başarılı!");
                    MusteriPaneli musteriForm = new MusteriPaneli(bulunanKullanici as Musteri); // Müşteri bilgisini diğer forma yolla
                     musteriForm.Show();
                     this.Hide(); // Giriş formunu gizle
                }
            }
            else
            {
                // Kullanıcı bulunamadı veya şifre yanlış
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}

