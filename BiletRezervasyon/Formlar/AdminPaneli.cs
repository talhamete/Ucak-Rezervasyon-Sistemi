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

                Sefer yeniSefer = new Sefer(tarih, Veriler.ucaklar.First(a => cmbUcak.Text == a.KuyrukNo),
                    new Rota(cmbKalkis.Text, cmbVaris.Text),
                    seciliKabinMemurlari, (Pilot)cmbPilot.SelectedItem);

                curAdmin.SeferEkle(yeniSefer);
                VerileriGuncelle();
                MessageBox.Show($"Sefer {yeniSefer.SeferNo} başarıyla eklendi.");

            }
        }

        // sefer güncelleme butonu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            List<KabinMemuru> seciliKabinMemurlari = kabinMLB.Items.Cast<KabinMemuru>().ToList();
            Sefer yeniSefer = new Sefer(datePicker.Value.Date + (TimeSpan)timePicker.Value.TimeOfDay, (Ucak)cmbUcak.SelectedItem,
                new Rota(cmbKalkis.Text, cmbVaris.Text), seciliKabinMemurlari, (Pilot)cmbPilot.SelectedItem);
            
            
            curAdmin.SeferGuncelle(seciliSefer,yeniSefer);
            int seferNo = seciliSefer.SeferNo; // message box için geçiçi değişken
            VerileriGuncelle();
            MessageBox.Show($"Sefer {seferNo} başarıyla güncellendi.");



        }
        // sefer silme butonu
        private void btnSil_Click(object sender, EventArgs e)
        {
            int seferNo = seciliSefer.SeferNo; // message box için geçiçi değişken
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

                KabinMemuru a = (KabinMemuru)VeriYonetimiServisi.PersonelleriYukle().Where(p => p is KabinMemuru).ToArray()[selectedIndex];

                if (!kabinMLB.Items.OfType<KabinMemuru>().Any(k => k.ID == a.ID)) //eşleşen yoksa ekle

                    kabinMLB.Items.Add(a);

            }
        }

        // uçak seçildiğinde kapasite ve model bilgilerini doldur
        private void cmbUcak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUcak.SelectedItem != null) { 
            int selectedIndex = cmbUcak.SelectedIndex;
            ucakKapasiteTB.Text = VeriYonetimiServisi.UcaklariYukle()[selectedIndex].Kapasite.ToString();
            ucakModelTB.Text = VeriYonetimiServisi.UcaklariYukle()[selectedIndex].Model.ToString();
        }
        }


        // input kontrol
        private bool Input_Kontrol()
        {
            bool kontrol = (kabinMLB.Items.Count > 0) && (cmbPilot.Text != "") && (cmbKalkis.Text != "") && (cmbVaris.Text != "") && (cmbUcak.Text != "");
            if (!kontrol)
            {
                MessageBox.Show("Boş alanlar var!");
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
            datePicker.Text = null;
            timePicker.Text = null;

        }



        // sefer seçildiğinde çalışır. Ona göre düğmelerin aktifliğini ayarlayan fonksiyonları çağırı ve secili seferi atar
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

        // seçili seferi silme ve guncelleme moduna alır
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



            kabinMLB.Items.Clear();

            foreach (Personel p in seciliSefer.KabinMemurlari)
            {
                kabinMLB.Items.Add(p);
            }

            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
            btnEkle.Enabled = false;



        }



        
       

       // Seferler tablosunu günceller

        void VerileriGuncelle()
        {
            seciliSefer = null;
            EklemeModu();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Veriler.seferler;
            dataGridView1.ClearSelection();
            Temizle();

        }

    }
}
