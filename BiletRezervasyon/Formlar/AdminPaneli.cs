using BiletRezervasyon.Servisler;
using BiletRezervasyon.Varlıklar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletRezervasyon.Formlar
{
    public partial class AdminPaneli : Form
    {
        Kullanici kullanici;
        private string[] _sehirler = {
        "İstanbul", "Ankara", "İzmir", "Antalya",
        "Adana", "Trabzon", "Bursa", "Gaziantep", "Konya"
    };












        public AdminPaneli()
        {
            InitializeComponent();
        }
       
        public AdminPaneli(Kullanici kullanici)
        {
            this.kullanici = kullanici;
            InitializeComponent();
          
            
        }

       
        private void AdminPaneli_Load(object sender, EventArgs e)
        {
            VerileriYukleVeListele();

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kabinMLB.Items.Remove(kabinMLB.SelectedItem);

        }

        private void kabinMEkle_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbKabinM.SelectedIndex;

            if (selectedIndex != -1)
            {
                
                KabinMemuru a = (KabinMemuru)VeriYonetimiServisi.PersonelleriYukle().Where(p => p is KabinMemuru).ToArray()[selectedIndex];
                
                if(!kabinMLB.Items.OfType<KabinMemuru>().Any(k => k.ID == a.ID)) //eşleşen yoksa ekle
                    
                    kabinMLB.Items.Add(a);

            }
        }

        private void cmbUcak_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbUcak.SelectedIndex;
            ucakKapasiteTB.Text = VeriYonetimiServisi.UcaklariYukle()[selectedIndex].Kapasite.ToString();
            ucakModelTB.Text = VeriYonetimiServisi.UcaklariYukle()[selectedIndex].Model.ToString();

        }
        List<Sefer> _seferler = new List<Sefer>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            List<KabinMemuru> seciliKabinMemurlari = kabinMLB.Items.Cast<KabinMemuru>().ToList();
            _seferler = VeriYonetimiServisi.SeferleriYukle();


            if (Input_Kontrol())
            {
                DateTime tarih = datePicker.Value.Date + (TimeSpan)timePicker.Value.TimeOfDay;


                List<Ucak> _ucaklar = VeriYonetimiServisi.UcaklariYukle();
                Sefer yeniSefer = new Sefer(
                    tarih,
                    _ucaklar.First(a => cmbUcak.Text == a.KuyrukNo),
                    new Rota(cmbKalkis.Text, cmbVaris.Text),
                    seciliKabinMemurlari, (Pilot)cmbPilot.SelectedItem);
                _seferler.Add(yeniSefer);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _seferler;
                VeriYonetimiServisi.SeferleriKaydet(_seferler);

            }
        }

        private bool Input_Kontrol()
        {
            bool kontrol = (kabinMLB.Items.Count > 0);



            return true;
        }

        private void VerileriYukleVeListele()
        {
            cmbKalkis.Items.AddRange(_sehirler);
            cmbVaris.Items.AddRange(_sehirler);

            List<Personel> _personeller = VeriYonetimiServisi.PersonelleriYukle();
            List<Ucak> _ucaklar = VeriYonetimiServisi.UcaklariYukle();
            _seferler = VeriYonetimiServisi.SeferleriYukle();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _seferler;


            cmbKabinM.Items.AddRange(
              _personeller
                  .Where(p => p is KabinMemuru)
                  .ToArray()
          );
            cmbPilot.Items.AddRange(
                _personeller
                    .Where(p => p is Pilot)
                    .ToArray()
            );
            cmbUcak.Items.AddRange(
                _ucaklar

                    .ToArray()
            );





        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                EklemeModu();
                return;
            }
            Sefer seciliSefer = (Sefer)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            if (seciliSefer != null)
            {

                SilmeModu(e);
            
            }




            }
        void EklemeModu()
             {

            seferNoTB.Text = "";
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            btnEkle.Enabled = true;





        }
        void SilmeModu(DataGridViewCellEventArgs e)
        {
           
                
            Sefer seciliSefer = (Sefer)dataGridView1.Rows[e.RowIndex].DataBoundItem;

           
             seferNoTB.Text = seciliSefer.SeferNo.ToString(); 

           
            datePicker.Value = seciliSefer.SeferTarihi;


           
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

    }
}
