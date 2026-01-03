using BiletRezervasyon.Servisler;
using BiletRezervasyon.Varlıklar;
using System.Data;


namespace BiletRezervasyon.Formlar
{
    public partial class AdminPaneli : Form
    {
        Admin curAdmin;
        Sefer seciliSefer;

        public AdminPaneli()
        {
            InitializeComponent();
        }

        public AdminPaneli(Kullanici kullanici)
        {
            this.curAdmin = (Admin)kullanici;
            InitializeComponent();
        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {
            VerileriYukleVeListele();
        }

        // sefer ekleme butonu
        private void btnEkle_Click(object sender, EventArgs e)
        {
            List<KabinMemuru> seciliKabinMemurlari = kabinMLB.Items.Cast<KabinMemuru>().ToList();

            if (Input_Kontrol())
            {
                DateTime tarih = datePicker.Value.Date + (TimeSpan)timePicker.Value.TimeOfDay;

                // Base fiyatı metinden al, yoksa varsayılanı kullan
                decimal baseFiyat = 1000m;
                if (!string.IsNullOrEmpty(fiyatTB.Text))
                {
                    if (decimal.TryParse(fiyatTB.Text, out decimal girilenFiyat))
                    {
                        baseFiyat = girilenFiyat;
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz fiyat formatı!");
                        return;
                    }
                }

                Sefer yeniSefer = new Sefer(
                    tarih,
                    Veriler.ucaklar.First(a => cmbUcak.Text == a.KuyrukNo),
                    new Rota(cmbKalkis.Text, cmbVaris.Text),
                    seciliKabinMemurlari,
                    (Pilot)cmbPilot.SelectedItem,
                    baseFiyat);

                curAdmin.SeferEkle(yeniSefer);
                VerileriGuncelle();
                MessageBox.Show($"Sefer {yeniSefer.SeferNo} başarıyla eklendi.\nBase Fiyat: {baseFiyat:C2}");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!Input_Kontrol())
                return;

            List<KabinMemuru> seciliKabinMemurlari = kabinMLB.Items.Cast<KabinMemuru>().ToList();

            // Base fiyat geçerlilik kontrolü
            decimal baseFiyat = 1000m;
            if (!string.IsNullOrEmpty(fiyatTB.Text))
            {
                if (decimal.TryParse(fiyatTB.Text, out decimal girilenFiyat))
                {
                    baseFiyat = girilenFiyat;
                }
                else
                {
                    MessageBox.Show("Geçersiz fiyat formatı!");
                    return;
                }
            }

            Sefer yeniSefer = new Sefer(
                datePicker.Value.Date + (TimeSpan)timePicker.Value.TimeOfDay,
                (Ucak)cmbUcak.SelectedItem,
                new Rota(cmbKalkis.Text, cmbVaris.Text),
                seciliKabinMemurlari,
                (Pilot)cmbPilot.SelectedItem,
                baseFiyat);

            curAdmin.SeferGuncelle(seciliSefer, yeniSefer);
            int seferNo = seciliSefer.SeferNo;
            VerileriGuncelle();
            MessageBox.Show($"Sefer {seferNo} başarıyla güncellendi.\nYeni Base Fiyat: {baseFiyat:C2}");
        }

        // sefer silme butonu
        private void btnSil_Click(object sender, EventArgs e)
        {
            int seferNo = seciliSefer.SeferNo;
            curAdmin.SeferSil(seciliSefer);
            VerileriGuncelle();
            MessageBox.Show($"Sefer {seferNo} başarıyla silindi.");
        }

        // kabin memuru çıkarmak için tıklama
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kabinMLB.Items.Remove(kabinMLB.SelectedItem);
        }

        // kabin memuru ekleme butonu
        private void kabinMEkle_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbKabinM.SelectedIndex;

            if (selectedIndex != -1)
            {
                KabinMemuru a = (KabinMemuru)VeriYonetimiServisi.PersonelleriYukle()
                    .Where(p => p is KabinMemuru).ToArray()[selectedIndex];

                if (!kabinMLB.Items.OfType<KabinMemuru>().Any(k => k.ID == a.ID))
                    kabinMLB.Items.Add(a);
            }
        }

        private void BtnVeriYonetimi_Click(object sender, EventArgs e)
        {
            FormVeriYonetimi veriYonetim = new FormVeriYonetimi();
            veriYonetim.Show();
            this.Hide();
        }

        // uçak seçildiğinde kapasite ve model bilgilerini doldur
        private void cmbUcak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUcak.SelectedItem != null)
            {
                int selectedIndex = cmbUcak.SelectedIndex;
                ucakKapasiteTB.Text = VeriYonetimiServisi.UcaklariYukle()[selectedIndex].Kapasite.ToString();
                ucakModelTB.Text = VeriYonetimiServisi.UcaklariYukle()[selectedIndex].Model.ToString();
            }
        }

        // input kontrol
        private bool Input_Kontrol()
        {
            bool kontrol = (kabinMLB.Items.Count > 0) && (cmbPilot.Text != "") &&
                          (cmbKalkis.Text != "") && (cmbVaris.Text != "") && (cmbUcak.Text != "");
            if (!kontrol)
            {
                MessageBox.Show("Boş alanlar var!");
            }
            else if (cmbKalkis.Text == cmbVaris.Text)
            {
                MessageBox.Show("Kalkış - Varış aynı olamaz!");
                return false;
            }

            return kontrol;
        }

        // verileri yükle ve listele, başta bir kere çalışır 
        private void VerileriYukleVeListele()
        {
            cmbKalkis.Items.AddRange(Veriler._sehirler);
            cmbVaris.Items.AddRange(Veriler._sehirler);

            Veriler.personeller = VeriYonetimiServisi.PersonelleriYukle();
            Veriler.ucaklar = VeriYonetimiServisi.UcaklariYukle();
            Veriler.seferler = VeriYonetimiServisi.SeferleriYukle();
            VerileriGuncelle();

            cmbKabinM.Items.AddRange(
                Veriler.personeller.Where(p => p is KabinMemuru).ToArray()
            );
            cmbPilot.Items.AddRange(
                Veriler.personeller.Where(p => p is Pilot).ToArray()
            );
            cmbUcak.Items.AddRange(
                Veriler.ucaklar.ToArray()
            );
        }

        void Temizle() //cmblerdeki seçili nesneleri temizler
        {
            cmbUcak.SelectedItem = null;
            cmbPilot.SelectedItem = null;
            kabinMLB.Items.Clear();
            cmbKalkis.SelectedItem = null;
            cmbVaris.SelectedItem = null;
            ucakKapasiteTB.Text = "";
            ucakModelTB.Text = "";
            seferNoTB.Text = "";
            fiyatTB.Text = "";
            datePicker.Text = null;
            timePicker.Text = null;
        }

        // sefer seçildiğinde çalışır
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                seciliSefer = null;
                EklemeModu();
                VerileriGuncelle();
                return;
            }
            seciliSefer = (Sefer)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            if (seciliSefer != null)
            {
                SilmeModu(e);
            }
        }

        // sefer ekleme moduna alır
        void EklemeModu()
        {
            seferNoTB.Text = "";
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            btnEkle.Enabled = true;
        }

        // seçili seferi silme ve guncelleme moduna alır - DÜZELTİLDİ
        void SilmeModu(DataGridViewCellEventArgs e)
        {
            Sefer seciliSefer = (Sefer)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            seferNoTB.Text = seciliSefer.SeferNo.ToString();
            datePicker.Value = seciliSefer.SeferTarihi;
            timePicker.Value = seciliSefer.SeferTarihi;

            cmbPilot.Text = seciliSefer.Pilot.ToString();
            cmbUcak.Text = seciliSefer.Ucak.KuyrukNo;
            cmbKalkis.Text = seciliSefer.Rota.KalkisYeri;
            cmbVaris.Text = seciliSefer.Rota.VarisYeri;

            fiyatTB.Text = seciliSefer.BaseFiyat.ToString();

            kabinMLB.Items.Clear();
            foreach (Personel p in seciliSefer.KabinMemurlari)
            {
                kabinMLB.Items.Add(p);
            }

            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
            btnEkle.Enabled = false;
        }

        void VerileriGuncelle()
        {
            // Sefer listesini yenile ve formu temizle
            seciliSefer = null;
            EklemeModu();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Veriler.seferler;
            dataGridView1.ClearSelection();
            Temizle();
        }

        private void cksBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGiris girisForm = new FormGiris();
            girisForm.Show();
        }
    }
}
