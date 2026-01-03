using BiletRezervasyon.Servisler;
using BiletRezervasyon.Varlýklar;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BiletRezervasyon.Formlar
{
    public partial class FormVeriYonetimi : Form
    {
        private Kullanici seciliKullanici;
        private Ucak seciliUcak;
        private Personel seciliPersonel;

        public FormVeriYonetimi()
        {
            InitializeComponent();
        }

        private void FormVeriYonetimi_Load(object sender, EventArgs e)
        {
            VerileriYukleVeListele();
        }

        private void VerileriYukleVeListele()
        {
            // Kullanýcýlar
            Veriler.kullanicilar = VeriYonetimiServisi.KullanicilariYukle();
            dataGridViewKullanicilar.DataSource = null;
            dataGridViewKullanicilar.DataSource = Veriler.kullanicilar;
            dataGridViewKullanicilar.ClearSelection();

            // Uçaklar
            Veriler.ucaklar = VeriYonetimiServisi.UcaklariYukle();
            dataGridViewUcaklar.DataSource = null;
            dataGridViewUcaklar.DataSource = Veriler.ucaklar;
            dataGridViewUcaklar.ClearSelection();

            // Personeller
            Veriler.personeller = VeriYonetimiServisi.PersonelleriYukle();
            dataGridViewPersoneller.DataSource = null;
            dataGridViewPersoneller.DataSource = Veriler.personeller;
            dataGridViewPersoneller.ClearSelection();

            // Varsayýlan seçimler
            if (cmbTip.Items.Count > 0) cmbTip.SelectedIndex = 0;
            if (cmbPersonelTip.Items.Count > 0) cmbPersonelTip.SelectedIndex = 0;
        }

        #region Kullanýcý Yönetimi

        private void VerileriGuncelle()
        {
            seciliKullanici = null;
            EklemeModu();
            dataGridViewKullanicilar.DataSource = null;
            dataGridViewKullanicilar.DataSource = Veriler.kullanicilar;
            dataGridViewKullanicilar.ClearSelection();
            Temizle();
        }

        private void Temizle()
        {
            cmbTip.SelectedIndex = 0;
            kullaniciAdiTB.Text = "";
            sifreTB.Text = "";
            adTB.Text = "";
            soyadTB.Text = "";
            tcNoTB.Text = "";
            telefonNoTB.Text = "";
        }

        private void EklemeModu()
        {
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            btnEkle.Enabled = true;
            Temizle();
        }

        private void GuncellemeModu()
        {
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
            btnEkle.Enabled = false;
        }

        private void dataGridViewKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                seciliKullanici = null;
                EklemeModu();
                return;
            }

            seciliKullanici = (Kullanici)dataGridViewKullanicilar.Rows[e.RowIndex].DataBoundItem;

            if (seciliKullanici != null)
            {
                kullaniciAdiTB.Text = seciliKullanici.KullaniciAdi;
                sifreTB.Text = seciliKullanici.Sifre;
                adTB.Text = seciliKullanici.Ad;
                soyadTB.Text = seciliKullanici.Soyad;

                if (seciliKullanici is Musteri musteri)
                {
                    cmbTip.SelectedItem = "musteri";
                    tcNoTB.Text = musteri.TcNo ?? "";
                    telefonNoTB.Text = musteri.TelefonNo ?? "";
                }
                else
                {
                    cmbTip.SelectedItem = "admin";
                    tcNoTB.Text = "";
                    telefonNoTB.Text = "";
                }

                GuncellemeModu();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!InputKontrol()) return;

                var list = VeriYonetimiServisi.KullanicilariYukle();
                int newId = list.Any() ? list.Max(x => x.ID) + 1 : 1;

                string tip = cmbTip.SelectedItem?.ToString()?.ToLower() ?? "admin";
                Kullanici yeni;

                if (tip == "musteri")
                {
                    yeni = new Musteri
                    {
                        ID = newId,
                        KullaniciAdi = kullaniciAdiTB.Text.Trim(),
                        Sifre = sifreTB.Text.Trim(),
                        Ad = adTB.Text.Trim(),
                        Soyad = soyadTB.Text.Trim(),
                        TcNo = tcNoTB.Text.Trim(),
                        TelefonNo = telefonNoTB.Text.Trim()
                    };
                }
                else
                {
                    yeni = new Admin
                    {
                        ID = newId,
                        KullaniciAdi = kullaniciAdiTB.Text.Trim(),
                        Sifre = sifreTB.Text.Trim(),
                        Ad = adTB.Text.Trim(),
                        Soyad = soyadTB.Text.Trim()
                    };
                }

                list.Add(yeni);
                VeriYonetimiServisi.KullanicilariKaydet(list);
                Veriler.kullanicilar = list;
                MessageBox.Show("Kullanýcý baþarýyla eklendi.");
                VerileriGuncelle();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Doðrulama Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliKullanici == null) return;

            try
            {
                if (!InputKontrol()) return;

                var list = VeriYonetimiServisi.KullanicilariYukle();
                var hedef = list.FirstOrDefault(x => x.ID == seciliKullanici.ID);
                if (hedef == null) return;

                string yeniTip = cmbTip.SelectedItem?.ToString()?.ToLower() ?? "admin";
                string eskiTip = hedef is Musteri ? "musteri" : "admin";

                if (yeniTip != eskiTip)
                {
                    var index = list.IndexOf(hedef);
                    Kullanici yeniKullanici;

                    if (yeniTip == "musteri")
                    {
                        yeniKullanici = new Musteri
                        {
                            ID = hedef.ID,
                            KullaniciAdi = kullaniciAdiTB.Text.Trim(),
                            Sifre = sifreTB.Text.Trim(),
                            Ad = adTB.Text.Trim(),
                            Soyad = soyadTB.Text.Trim(),
                            TcNo = tcNoTB.Text.Trim(),
                            TelefonNo = telefonNoTB.Text.Trim()
                        };
                    }
                    else
                    {
                        yeniKullanici = new Admin
                        {
                            ID = hedef.ID,
                            KullaniciAdi = kullaniciAdiTB.Text.Trim(),
                            Sifre = sifreTB.Text.Trim(),
                            Ad = adTB.Text.Trim(),
                            Soyad = soyadTB.Text.Trim()
                        };
                    }

                    list[index] = yeniKullanici;
                }
                else
                {
                    hedef.KullaniciAdi = kullaniciAdiTB.Text.Trim();
                    hedef.Sifre = sifreTB.Text.Trim();
                    hedef.Ad = adTB.Text.Trim();
                    hedef.Soyad = soyadTB.Text.Trim();

                    if (hedef is Musteri m)
                    {
                        m.TcNo = tcNoTB.Text.Trim();
                        m.TelefonNo = telefonNoTB.Text.Trim();
                    }
                }

                VeriYonetimiServisi.KullanicilariKaydet(list);
                Veriler.kullanicilar = list;
                MessageBox.Show("Kullanýcý baþarýyla güncellendi.");
                VerileriGuncelle();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Doðrulama Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliKullanici == null) return;

            // Eðer müþteri ise rezervasyon sayýsýný kontrol et
            if (seciliKullanici is Musteri musteri)
            {
                int rezervasyonSayisi = musteri.Rezervasyonlar?.Count ?? 0;

                var result = MessageBox.Show(
                    $"'{seciliKullanici.KullaniciAdi}' kullanýcýsýný silmek istediðinizden emin misiniz?\n\n" +
                    $"Bu müþteriye ait {rezervasyonSayisi} rezervasyon silinecek ve koltuklar boþa düþecek!",
                    "Silme Onayý",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Müþterinin rezervasyonlarýný sil ve koltuklarý boþalt
                    if (musteri.Rezervasyonlar != null && musteri.Rezervasyonlar.Any())
                    {
                        // Veriler.seferler içindeki gerçek koltuk nesnelerini güncelle
                        foreach (var rezervasyon in musteri.Rezervasyonlar.ToList())
                        {
                            if (rezervasyon.Koltuk != null && rezervasyon.Sefer != null)
                            {
                                // Ýlgili seferi Veriler.seferler içinde bul
                                var sefer = Veriler.seferler.FirstOrDefault(s => s.SeferNo == rezervasyon.Sefer.SeferNo);
                                if (sefer != null)
                                {
                                    // Seferdeki ilgili koltuðu bul ve boþalt
                                    var koltuk = sefer.Koltuklar.FirstOrDefault(k => k.KoltukNo == rezervasyon.Koltuk.KoltukNo);
                                    if (koltuk != null)
                                    {
                                        koltuk.DoluMu = false;
                                    }
                                }
                            }
                        }

                        musteri.Rezervasyonlar.Clear();
                    }

                    var list = VeriYonetimiServisi.KullanicilariYukle();
                    var hedef = list.FirstOrDefault(x => x.ID == seciliKullanici.ID);
                    if (hedef != null)
                    {
                        // Yüklenen listedeki müþterinin rezervasyonlarýný da temizle
                        if (hedef is Musteri musteriHedef && musteriHedef.Rezervasyonlar != null)
                        {
                            musteriHedef.Rezervasyonlar.Clear();
                        }

                        list.Remove(hedef);
                        VeriYonetimiServisi.KullanicilariKaydet(list);

                        // Seferleri kaydet (koltuk durumlarý güncellendiði için)
                        VeriYonetimiServisi.SeferleriKaydet(Veriler.seferler);

                        Veriler.kullanicilar = list;
                        MessageBox.Show($"Kullanýcý ve {rezervasyonSayisi} rezervasyon baþarýyla silindi.");
                        VerileriGuncelle();
                    }
                }
            }
            else
            {
                // Admin ise normal sil
                var result = MessageBox.Show(
                    $"'{seciliKullanici.KullaniciAdi}' kullanýcýsýný silmek istediðinizden emin misiniz?",
                    "Silme Onayý",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var list = VeriYonetimiServisi.KullanicilariYukle();
                    var hedef = list.FirstOrDefault(x => x.ID == seciliKullanici.ID);
                    if (hedef != null)
                    {
                        list.Remove(hedef);
                        VeriYonetimiServisi.KullanicilariKaydet(list);
                        Veriler.kullanicilar = list;

                        MessageBox.Show("Kullanýcý baþarýyla silindi.");
                        VerileriGuncelle();
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                VeriYonetimiServisi.KullanicilariKaydet(Veriler.kullanicilar);
                VeriYonetimiServisi.UcaklariKaydet(Veriler.ucaklar);
                VeriYonetimiServisi.PersonelleriKaydet(Veriler.personeller);
                VeriYonetimiServisi.SeferleriKaydet(Veriler.seferler);

                MessageBox.Show("Deðiþiklikler kaydedildi ve uygulanýyor...");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayýt hatasý: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool InputKontrol()
        {
            if (string.IsNullOrWhiteSpace(kullaniciAdiTB.Text))
            {
                MessageBox.Show("Kullanýcý adý boþ olamaz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(sifreTB.Text))
            {
                MessageBox.Show("Þifre boþ olamaz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(adTB.Text))
            {
                MessageBox.Show("Ad boþ olamaz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(soyadTB.Text))
            {
                MessageBox.Show("Soyad boþ olamaz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string tip = cmbTip.SelectedItem?.ToString()?.ToLower() ?? "admin";
            if (tip == "musteri")
            {
                if (string.IsNullOrWhiteSpace(tcNoTB.Text))
                {
                    MessageBox.Show("Müþteri için TC No boþ olamaz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(telefonNoTB.Text))
                {
                    MessageBox.Show("Müþteri için Telefon No boþ olamaz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region Uçak Yönetimi

        private void dataGridViewUcaklar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                seciliUcak = null;
                UcakEklemeModu();
                return;
            }

            seciliUcak = (Ucak)dataGridViewUcaklar.Rows[e.RowIndex].DataBoundItem;

            if (seciliUcak != null)
            {
                ucakModelTB.Text = seciliUcak.Model;
                ucakKapasiteTB.Value = seciliUcak.Kapasite;
                ucakKuyrukNoTB.Text = seciliUcak.KuyrukNo;

                UcakGuncellemeModu();
            }
        }

        private void btnUcakEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!UcakInputKontrol()) return;

                var list = VeriYonetimiServisi.UcaklariYukle();
                int newId = list.Any() ? list.Max(x => x.UcakID) + 1 : 1;

                var yeni = new Ucak
                {
                    UcakID = newId,
                    Model = ucakModelTB.Text.Trim(),
                    Kapasite = (int)ucakKapasiteTB.Value,
                    KuyrukNo = ucakKuyrukNoTB.Text.Trim()
                };

                list.Add(yeni);
                VeriYonetimiServisi.UcaklariKaydet(list);
                Veriler.ucaklar = list;
                MessageBox.Show("Uçak baþarýyla eklendi.");
                UcakVerileriGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUcakGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliUcak == null) return;

            try
            {
                if (!UcakInputKontrol()) return;

                var list = VeriYonetimiServisi.UcaklariYukle();
                var hedef = list.FirstOrDefault(x => x.UcakID == seciliUcak.UcakID);
                if (hedef == null) return;

                hedef.Model = ucakModelTB.Text.Trim();
                hedef.Kapasite = (int)ucakKapasiteTB.Value;
                hedef.KuyrukNo = ucakKuyrukNoTB.Text.Trim();

                VeriYonetimiServisi.UcaklariKaydet(list);
                Veriler.ucaklar = list;
                MessageBox.Show("Uçak baþarýyla güncellendi.");
                UcakVerileriGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUcakSil_Click(object sender, EventArgs e)
        {
            if (seciliUcak == null) return;

            // Bu uçaðý kullanan seferleri bul
            var etkilenenSeferler = Veriler.seferler.Where(s => s.Ucak.UcakID == seciliUcak.UcakID).ToList();
            int seferSayisi = etkilenenSeferler.Count;

            // Etkilenen rezervasyonlarý say
            int rezervasyonSayisi = 0;
            foreach (var sefer in etkilenenSeferler)
            {
                rezervasyonSayisi += sefer.Koltuklar.Count(k => k.DoluMu);
            }

            var result = MessageBox.Show(
                $"'{seciliUcak.KuyrukNo}' uçaðýný silmek istediðinizden emin misiniz?\n\n" +
                $"Bu iþlem sonucunda:\n" +
                $"- {seferSayisi} sefer silinecek\n" +
                $"- {rezervasyonSayisi} rezervasyon iptal edilecek\n" +
                $"- Ýlgili koltuklar boþa düþecek\n\n" +
                $"Bu iþlem geri alýnamaz!",
                "Silme Onayý",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Önce etkilenen seferlerdeki rezervasyonlarý temizle
                    foreach (var sefer in etkilenenSeferler)
                    {
                        // Tüm müþterilerin bu seferdeki rezervasyonlarýný temizle
                        foreach (var kullanici in Veriler.kullanicilar.OfType<Musteri>())
                        {
                            var silinecekRezervasyonlar = kullanici.Rezervasyonlar
                                .Where(r => r.Sefer.SeferNo == sefer.SeferNo)
                                .ToList();

                            foreach (var rez in silinecekRezervasyonlar)
                            {
                                kullanici.Rezervasyonlar.Remove(rez);
                            }
                        }

                        // Koltuklarý boþalt
                        foreach (var koltuk in sefer.Koltuklar)
                        {
                            koltuk.DoluMu = false;
                        }
                    }

                    // Seferleri sil
                    foreach (var sefer in etkilenenSeferler)
                    {
                        Veriler.seferler.Remove(sefer);
                    }

                    // Uçaðý sil
                    var ucakList = VeriYonetimiServisi.UcaklariYukle();
                    var hedef = ucakList.FirstOrDefault(x => x.UcakID == seciliUcak.UcakID);
                    if (hedef != null)
                    {
                        ucakList.Remove(hedef);
                        VeriYonetimiServisi.UcaklariKaydet(ucakList);
                        Veriler.ucaklar = ucakList;
                    }

                    // Deðiþiklikleri kaydet
                    VeriYonetimiServisi.SeferleriKaydet(Veriler.seferler);
                    VeriYonetimiServisi.KullanicilariKaydet(Veriler.kullanicilar);

                    MessageBox.Show($"Uçak, {seferSayisi} sefer ve {rezervasyonSayisi} rezervasyon baþarýyla silindi.");
                    UcakVerileriGuncelle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Silme iþlemi sýrasýnda hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UcakVerileriGuncelle()
        {
            seciliUcak = null;
            UcakEklemeModu();
            dataGridViewUcaklar.DataSource = null;
            dataGridViewUcaklar.DataSource = Veriler.ucaklar;
            dataGridViewUcaklar.ClearSelection();
        }

        private void UcakEklemeModu()
        {
            btnUcakGuncelle.Enabled = false;
            btnUcakSil.Enabled = false;
            btnUcakEkle.Enabled = true;
            ucakModelTB.Text = "";
            ucakKapasiteTB.Value = 100;
            ucakKuyrukNoTB.Text = "";
        }

        private void UcakGuncellemeModu()
        {
            btnUcakGuncelle.Enabled = true;
            btnUcakSil.Enabled = true;
            btnUcakEkle.Enabled = false;
        }

        private bool UcakInputKontrol()
        {
            if (string.IsNullOrWhiteSpace(ucakModelTB.Text))
            {
                MessageBox.Show("Model boþ olamaz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(ucakKuyrukNoTB.Text))
            {
                MessageBox.Show("Kuyruk No boþ olamaz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        #endregion

        #region Personel Yönetimi

        private void dataGridViewPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                seciliPersonel = null;
                PersonelEklemeModu();
                return;
            }

            seciliPersonel = (Personel)dataGridViewPersoneller.Rows[e.RowIndex].DataBoundItem;

            if (seciliPersonel != null)
            {
                personelAdTB.Text = seciliPersonel.Ad;
                personelSoyadTB.Text = seciliPersonel.Soyad;

                if (seciliPersonel is Pilot)
                    cmbPersonelTip.SelectedItem = "Pilot";
                else
                    cmbPersonelTip.SelectedItem = "KabinMemuru";

                PersonelGuncellemeModu();
            }
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!PersonelInputKontrol()) return;

                var list = VeriYonetimiServisi.PersonelleriYukle();
                int newId = list.Any() ? list.Max(x => x.ID) + 1 : 1;

                string tip = cmbPersonelTip.SelectedItem?.ToString() ?? "Pilot";
                Personel yeni;

                if (tip == "Pilot")
                {
                    yeni = new Pilot
                    {
                        ID = newId,
                        Ad = personelAdTB.Text.Trim(),
                        Soyad = personelSoyadTB.Text.Trim()
                    };
                }
                else
                {
                    yeni = new KabinMemuru
                    {
                        ID = newId,
                        Ad = personelAdTB.Text.Trim(),
                        Soyad = personelSoyadTB.Text.Trim()
                    };
                }

                list.Add(yeni);
                VeriYonetimiServisi.PersonelleriKaydet(list);
                Veriler.personeller = list;
                MessageBox.Show("Personel baþarýyla eklendi.");
                PersonelVerileriGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliPersonel == null) return;

            try
            {
                if (!PersonelInputKontrol()) return;

                var list = VeriYonetimiServisi.PersonelleriYukle();
                var hedef = list.FirstOrDefault(x => x.ID == seciliPersonel.ID);
                if (hedef == null) return;

                string yeniTip = cmbPersonelTip.SelectedItem?.ToString() ?? "Pilot";
                string eskiTip = hedef is Pilot ? "Pilot" : "KabinMemuru";

                if (yeniTip != eskiTip)
                {
                    var index = list.IndexOf(hedef);
                    Personel yeniPersonel;

                    if (yeniTip == "Pilot")
                    {
                        yeniPersonel = new Pilot
                        {
                            ID = hedef.ID,
                            Ad = personelAdTB.Text.Trim(),
                            Soyad = personelSoyadTB.Text.Trim()
                        };
                    }
                    else
                    {
                        yeniPersonel = new KabinMemuru
                        {
                            ID = hedef.ID,
                            Ad = personelAdTB.Text.Trim(),
                            Soyad = personelSoyadTB.Text.Trim()
                        };
                    }

                    list[index] = yeniPersonel;
                }
                else
                {
                    hedef.Ad = personelAdTB.Text.Trim();
                    hedef.Soyad = personelSoyadTB.Text.Trim();
                }

                VeriYonetimiServisi.PersonelleriKaydet(list);
                Veriler.personeller = list;
                MessageBox.Show("Personel baþarýyla güncellendi.");
                PersonelVerileriGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            if (seciliPersonel == null) return;

            var result = MessageBox.Show(
                $"'{seciliPersonel.Ad} {seciliPersonel.Soyad}' personelini silmek istediðinizden emin misiniz?",
                "Silme Onayý",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var list = VeriYonetimiServisi.PersonelleriYukle();
                var hedef = list.FirstOrDefault(x => x.ID == seciliPersonel.ID);
                if (hedef != null)
                {
                    list.Remove(hedef);
                    VeriYonetimiServisi.PersonelleriKaydet(list);
                    Veriler.personeller = list;
                    MessageBox.Show("Personel baþarýyla silindi.");
                    PersonelVerileriGuncelle();
                }
            }
        }

        private void PersonelVerileriGuncelle()
        {
            seciliPersonel = null;
            PersonelEklemeModu();
            dataGridViewPersoneller.DataSource = null;
            dataGridViewPersoneller.DataSource = Veriler.personeller;
            dataGridViewPersoneller.ClearSelection();
        }

        private void PersonelEklemeModu()
        {
            btnPersonelGuncelle.Enabled = false;
            btnPersonelSil.Enabled = false;
            btnPersonelEkle.Enabled = true;
            personelAdTB.Text = "";
            personelSoyadTB.Text = "";
            if (cmbPersonelTip.Items.Count > 0) cmbPersonelTip.SelectedIndex = 0;
        }

        private void PersonelGuncellemeModu()
        {
            btnPersonelGuncelle.Enabled = true;
            btnPersonelSil.Enabled = true;
            btnPersonelEkle.Enabled = false;
        }

        private bool PersonelInputKontrol()
        {
            if (string.IsNullOrWhiteSpace(personelAdTB.Text))
            {
                MessageBox.Show("Ad boþ olamaz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(personelSoyadTB.Text))
            {
                MessageBox.Show("Soyad boþ olamaz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void cksBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormGiris girisForm = new FormGiris();
            girisForm.Show();

        }


        #endregion

        private void tabKullanici_Click(object sender, EventArgs e)
        {

        }
    }
}
