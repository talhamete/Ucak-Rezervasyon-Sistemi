namespace BiletRezervasyon.Formlar
{
    partial class FormVeriYonetimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabKullanici = new TabPage();
            cksBtn = new ReaLTaiizor.Controls.HopeButton();
            groupBox1 = new GroupBox();
            labelTip = new Label();
            cmbTip = new ComboBox();
            telefonNoTB = new TextBox();
            labelTelefon = new Label();
            tcNoTB = new TextBox();
            labelTc = new Label();
            soyadTB = new TextBox();
            labelSoyad = new Label();
            adTB = new TextBox();
            labelAd = new Label();
            sifreTB = new TextBox();
            labelSifre = new Label();
            kullaniciAdiTB = new TextBox();
            labelKullaniciAdi = new Label();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnKaydet = new Button();
            dataGridViewKullanicilar = new DataGridView();
            tabUcak = new TabPage();
            groupBox2 = new GroupBox();
            ucakKuyrukNoTB = new TextBox();
            labelKuyrukNo = new Label();
            ucakKapasiteTB = new NumericUpDown();
            labelKapasite = new Label();
            ucakModelTB = new TextBox();
            labelModel = new Label();
            btnUcakEkle = new Button();
            btnUcakGuncelle = new Button();
            btnUcakSil = new Button();
            dataGridViewUcaklar = new DataGridView();
            tabPersonel = new TabPage();
            groupBox3 = new GroupBox();
            labelPersonelTip = new Label();
            cmbPersonelTip = new ComboBox();
            personelSoyadTB = new TextBox();
            labelPersonelSoyad = new Label();
            personelAdTB = new TextBox();
            labelPersonelAd = new Label();
            btnPersonelEkle = new Button();
            btnPersonelGuncelle = new Button();
            btnPersonelSil = new Button();
            dataGridViewPersoneller = new DataGridView();
            hopeButton1 = new ReaLTaiizor.Controls.HopeButton();
            hopeButton2 = new ReaLTaiizor.Controls.HopeButton();
            tabControl.SuspendLayout();
            tabKullanici.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKullanicilar).BeginInit();
            tabUcak.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucakKapasiteTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUcaklar).BeginInit();
            tabPersonel.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersoneller).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabKullanici);
            tabControl.Controls.Add(tabUcak);
            tabControl.Controls.Add(tabPersonel);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1040, 504);
            tabControl.TabIndex = 0;
            tabControl.Click += cksBtn_Click;
            // 
            // tabKullanici
            // 
            tabKullanici.Controls.Add(cksBtn);
            tabKullanici.Controls.Add(groupBox1);
            tabKullanici.Controls.Add(dataGridViewKullanicilar);
            tabKullanici.Location = new Point(4, 29);
            tabKullanici.Name = "tabKullanici";
            tabKullanici.Padding = new Padding(3);
            tabKullanici.Size = new Size(1032, 471);
            tabKullanici.TabIndex = 0;
            tabKullanici.Text = "Kullanýcý Yönetimi";
            tabKullanici.UseVisualStyleBackColor = true;
            // 
            // cksBtn
            // 
            cksBtn.BorderColor = Color.FromArgb(220, 223, 230);
            cksBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            cksBtn.DangerColor = Color.FromArgb(245, 108, 108);
            cksBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            cksBtn.Font = new Font("Segoe UI", 12F);
            cksBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            cksBtn.InfoColor = Color.FromArgb(144, 147, 153);
            cksBtn.Location = new Point(785, 393);
            cksBtn.Name = "cksBtn";
            cksBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            cksBtn.Size = new Size(90, 50);
            cksBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            cksBtn.TabIndex = 33;
            cksBtn.Text = "Çýkýþ";
            cksBtn.TextColor = Color.White;
            cksBtn.WarningColor = Color.FromArgb(230, 162, 60);
            cksBtn.Click += cksBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelTip);
            groupBox1.Controls.Add(cmbTip);
            groupBox1.Controls.Add(telefonNoTB);
            groupBox1.Controls.Add(labelTelefon);
            groupBox1.Controls.Add(tcNoTB);
            groupBox1.Controls.Add(labelTc);
            groupBox1.Controls.Add(soyadTB);
            groupBox1.Controls.Add(labelSoyad);
            groupBox1.Controls.Add(adTB);
            groupBox1.Controls.Add(labelAd);
            groupBox1.Controls.Add(sifreTB);
            groupBox1.Controls.Add(labelSifre);
            groupBox1.Controls.Add(kullaniciAdiTB);
            groupBox1.Controls.Add(labelKullaniciAdi);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Location = new Point(668, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 353);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanýcý Bilgileri";
            // 
            // labelTip
            // 
            labelTip.AutoSize = true;
            labelTip.Location = new Point(16, 28);
            labelTip.Name = "labelTip";
            labelTip.Size = new Size(30, 20);
            labelTip.TabIndex = 0;
            labelTip.Text = "Tip";
            // 
            // cmbTip
            // 
            cmbTip.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTip.FormattingEnabled = true;
            cmbTip.Items.AddRange(new object[] { "admin", "musteri" });
            cmbTip.Location = new Point(120, 25);
            cmbTip.Name = "cmbTip";
            cmbTip.Size = new Size(216, 28);
            cmbTip.TabIndex = 1;
            // 
            // telefonNoTB
            // 
            telefonNoTB.Location = new Point(120, 205);
            telefonNoTB.Name = "telefonNoTB";
            telefonNoTB.Size = new Size(216, 27);
            telefonNoTB.TabIndex = 7;
            // 
            // labelTelefon
            // 
            labelTelefon.AutoSize = true;
            labelTelefon.Location = new Point(16, 208);
            labelTelefon.Name = "labelTelefon";
            labelTelefon.Size = new Size(82, 20);
            labelTelefon.TabIndex = 12;
            labelTelefon.Text = "Telefon No";
            // 
            // tcNoTB
            // 
            tcNoTB.Location = new Point(120, 172);
            tcNoTB.Name = "tcNoTB";
            tcNoTB.Size = new Size(216, 27);
            tcNoTB.TabIndex = 6;
            // 
            // labelTc
            // 
            labelTc.AutoSize = true;
            labelTc.Location = new Point(16, 175);
            labelTc.Name = "labelTc";
            labelTc.Size = new Size(43, 20);
            labelTc.TabIndex = 10;
            labelTc.Text = "TcNo";
            // 
            // soyadTB
            // 
            soyadTB.Location = new Point(120, 139);
            soyadTB.Name = "soyadTB";
            soyadTB.Size = new Size(216, 27);
            soyadTB.TabIndex = 5;
            // 
            // labelSoyad
            // 
            labelSoyad.AutoSize = true;
            labelSoyad.Location = new Point(16, 142);
            labelSoyad.Name = "labelSoyad";
            labelSoyad.Size = new Size(50, 20);
            labelSoyad.TabIndex = 8;
            labelSoyad.Text = "Soyad";
            // 
            // adTB
            // 
            adTB.Location = new Point(120, 106);
            adTB.Name = "adTB";
            adTB.Size = new Size(216, 27);
            adTB.TabIndex = 4;
            // 
            // labelAd
            // 
            labelAd.AutoSize = true;
            labelAd.Location = new Point(16, 109);
            labelAd.Name = "labelAd";
            labelAd.Size = new Size(28, 20);
            labelAd.TabIndex = 6;
            labelAd.Text = "Ad";
            // 
            // sifreTB
            // 
            sifreTB.Location = new Point(120, 73);
            sifreTB.Name = "sifreTB";
            sifreTB.Size = new Size(216, 27);
            sifreTB.TabIndex = 3;
            // 
            // labelSifre
            // 
            labelSifre.AutoSize = true;
            labelSifre.Location = new Point(16, 76);
            labelSifre.Name = "labelSifre";
            labelSifre.Size = new Size(39, 20);
            labelSifre.TabIndex = 4;
            labelSifre.Text = "Þifre";
            // 
            // kullaniciAdiTB
            // 
            kullaniciAdiTB.Location = new Point(120, 59);
            kullaniciAdiTB.Name = "kullaniciAdiTB";
            kullaniciAdiTB.Size = new Size(216, 27);
            kullaniciAdiTB.TabIndex = 2;
            // 
            // labelKullaniciAdi
            // 
            labelKullaniciAdi.AutoSize = true;
            labelKullaniciAdi.Location = new Point(16, 62);
            labelKullaniciAdi.Name = "labelKullaniciAdi";
            labelKullaniciAdi.Size = new Size(92, 20);
            labelKullaniciAdi.TabIndex = 2;
            labelKullaniciAdi.Text = "Kullanýcý Adý";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(16, 255);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(85, 32);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Enabled = false;
            btnGuncelle.Location = new Point(117, 255);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(85, 32);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Enabled = false;
            btnSil.Location = new Point(218, 255);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(85, 32);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(16, 305);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(287, 32);
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "Deðiþiklikleri Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dataGridViewKullanicilar
            // 
            dataGridViewKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKullanicilar.Location = new Point(12, 12);
            dataGridViewKullanicilar.MultiSelect = false;
            dataGridViewKullanicilar.Name = "dataGridViewKullanicilar";
            dataGridViewKullanicilar.ReadOnly = true;
            dataGridViewKullanicilar.RowHeadersWidth = 51;
            dataGridViewKullanicilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKullanicilar.Size = new Size(640, 450);
            dataGridViewKullanicilar.TabIndex = 0;
            dataGridViewKullanicilar.CellClick += dataGridViewKullanicilar_CellClick;
            // 
            // tabUcak
            // 
            tabUcak.Controls.Add(hopeButton2);
            tabUcak.Controls.Add(groupBox2);
            tabUcak.Controls.Add(dataGridViewUcaklar);
            tabUcak.Location = new Point(4, 29);
            tabUcak.Name = "tabUcak";
            tabUcak.Padding = new Padding(3);
            tabUcak.Size = new Size(1032, 471);
            tabUcak.TabIndex = 1;
            tabUcak.Text = "Uçak Yönetimi";
            tabUcak.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ucakKuyrukNoTB);
            groupBox2.Controls.Add(labelKuyrukNo);
            groupBox2.Controls.Add(ucakKapasiteTB);
            groupBox2.Controls.Add(labelKapasite);
            groupBox2.Controls.Add(ucakModelTB);
            groupBox2.Controls.Add(labelModel);
            groupBox2.Controls.Add(btnUcakEkle);
            groupBox2.Controls.Add(btnUcakGuncelle);
            groupBox2.Controls.Add(btnUcakSil);
            groupBox2.Location = new Point(668, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 248);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Uçak Bilgileri";
            // 
            // ucakKuyrukNoTB
            // 
            ucakKuyrukNoTB.Location = new Point(120, 106);
            ucakKuyrukNoTB.Name = "ucakKuyrukNoTB";
            ucakKuyrukNoTB.Size = new Size(216, 27);
            ucakKuyrukNoTB.TabIndex = 3;
            // 
            // labelKuyrukNo
            // 
            labelKuyrukNo.AutoSize = true;
            labelKuyrukNo.Location = new Point(16, 109);
            labelKuyrukNo.Name = "labelKuyrukNo";
            labelKuyrukNo.Size = new Size(77, 20);
            labelKuyrukNo.TabIndex = 6;
            labelKuyrukNo.Text = "Kuyruk No";
            // 
            // ucakKapasiteTB
            // 
            ucakKapasiteTB.Location = new Point(120, 73);
            ucakKapasiteTB.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            ucakKapasiteTB.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ucakKapasiteTB.Name = "ucakKapasiteTB";
            ucakKapasiteTB.Size = new Size(150, 27);
            ucakKapasiteTB.TabIndex = 2;
            ucakKapasiteTB.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelKapasite
            // 
            labelKapasite.AutoSize = true;
            labelKapasite.Location = new Point(16, 76);
            labelKapasite.Name = "labelKapasite";
            labelKapasite.Size = new Size(66, 20);
            labelKapasite.TabIndex = 4;
            labelKapasite.Text = "Kapasite";
            // 
            // ucakModelTB
            // 
            ucakModelTB.Location = new Point(120, 40);
            ucakModelTB.Name = "ucakModelTB";
            ucakModelTB.Size = new Size(216, 27);
            ucakModelTB.TabIndex = 1;
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new Point(16, 43);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(52, 20);
            labelModel.TabIndex = 2;
            labelModel.Text = "Model";
            // 
            // btnUcakEkle
            // 
            btnUcakEkle.Location = new Point(16, 155);
            btnUcakEkle.Name = "btnUcakEkle";
            btnUcakEkle.Size = new Size(85, 32);
            btnUcakEkle.TabIndex = 4;
            btnUcakEkle.Text = "Ekle";
            btnUcakEkle.UseVisualStyleBackColor = true;
            btnUcakEkle.Click += btnUcakEkle_Click;
            // 
            // btnUcakGuncelle
            // 
            btnUcakGuncelle.Enabled = false;
            btnUcakGuncelle.Location = new Point(117, 155);
            btnUcakGuncelle.Name = "btnUcakGuncelle";
            btnUcakGuncelle.Size = new Size(85, 32);
            btnUcakGuncelle.TabIndex = 5;
            btnUcakGuncelle.Text = "Güncelle";
            btnUcakGuncelle.UseVisualStyleBackColor = true;
            btnUcakGuncelle.Click += btnUcakGuncelle_Click;
            // 
            // btnUcakSil
            // 
            btnUcakSil.Enabled = false;
            btnUcakSil.Location = new Point(218, 155);
            btnUcakSil.Name = "btnUcakSil";
            btnUcakSil.Size = new Size(85, 32);
            btnUcakSil.TabIndex = 6;
            btnUcakSil.Text = "Sil";
            btnUcakSil.UseVisualStyleBackColor = true;
            btnUcakSil.Click += btnUcakSil_Click;
            // 
            // dataGridViewUcaklar
            // 
            dataGridViewUcaklar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUcaklar.Location = new Point(12, 12);
            dataGridViewUcaklar.MultiSelect = false;
            dataGridViewUcaklar.Name = "dataGridViewUcaklar";
            dataGridViewUcaklar.ReadOnly = true;
            dataGridViewUcaklar.RowHeadersWidth = 51;
            dataGridViewUcaklar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUcaklar.Size = new Size(640, 450);
            dataGridViewUcaklar.TabIndex = 0;
            dataGridViewUcaklar.CellClick += dataGridViewUcaklar_CellClick;
            // 
            // tabPersonel
            // 
            tabPersonel.Controls.Add(hopeButton1);
            tabPersonel.Controls.Add(groupBox3);
            tabPersonel.Controls.Add(dataGridViewPersoneller);
            tabPersonel.Location = new Point(4, 29);
            tabPersonel.Name = "tabPersonel";
            tabPersonel.Size = new Size(1032, 471);
            tabPersonel.TabIndex = 2;
            tabPersonel.Text = "Personel Yönetimi";
            tabPersonel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelPersonelTip);
            groupBox3.Controls.Add(cmbPersonelTip);
            groupBox3.Controls.Add(personelSoyadTB);
            groupBox3.Controls.Add(labelPersonelSoyad);
            groupBox3.Controls.Add(personelAdTB);
            groupBox3.Controls.Add(labelPersonelAd);
            groupBox3.Controls.Add(btnPersonelEkle);
            groupBox3.Controls.Add(btnPersonelGuncelle);
            groupBox3.Controls.Add(btnPersonelSil);
            groupBox3.Location = new Point(668, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(350, 306);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personel Bilgileri";
            // 
            // labelPersonelTip
            // 
            labelPersonelTip.AutoSize = true;
            labelPersonelTip.Location = new Point(16, 28);
            labelPersonelTip.Name = "labelPersonelTip";
            labelPersonelTip.Size = new Size(30, 20);
            labelPersonelTip.TabIndex = 0;
            labelPersonelTip.Text = "Tip";
            // 
            // cmbPersonelTip
            // 
            cmbPersonelTip.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonelTip.FormattingEnabled = true;
            cmbPersonelTip.Items.AddRange(new object[] { "Pilot", "KabinMemuru" });
            cmbPersonelTip.Location = new Point(120, 25);
            cmbPersonelTip.Name = "cmbPersonelTip";
            cmbPersonelTip.Size = new Size(216, 28);
            cmbPersonelTip.TabIndex = 1;
            // 
            // personelSoyadTB
            // 
            personelSoyadTB.Location = new Point(120, 92);
            personelSoyadTB.Name = "personelSoyadTB";
            personelSoyadTB.Size = new Size(216, 27);
            personelSoyadTB.TabIndex = 3;
            // 
            // labelPersonelSoyad
            // 
            labelPersonelSoyad.AutoSize = true;
            labelPersonelSoyad.Location = new Point(16, 95);
            labelPersonelSoyad.Name = "labelPersonelSoyad";
            labelPersonelSoyad.Size = new Size(50, 20);
            labelPersonelSoyad.TabIndex = 6;
            labelPersonelSoyad.Text = "Soyad";
            // 
            // personelAdTB
            // 
            personelAdTB.Location = new Point(120, 59);
            personelAdTB.Name = "personelAdTB";
            personelAdTB.Size = new Size(216, 27);
            personelAdTB.TabIndex = 2;
            // 
            // labelPersonelAd
            // 
            labelPersonelAd.AutoSize = true;
            labelPersonelAd.Location = new Point(16, 62);
            labelPersonelAd.Name = "labelPersonelAd";
            labelPersonelAd.Size = new Size(28, 20);
            labelPersonelAd.TabIndex = 2;
            labelPersonelAd.Text = "Ad";
            // 
            // btnPersonelEkle
            // 
            btnPersonelEkle.Location = new Point(16, 140);
            btnPersonelEkle.Name = "btnPersonelEkle";
            btnPersonelEkle.Size = new Size(85, 32);
            btnPersonelEkle.TabIndex = 4;
            btnPersonelEkle.Text = "Ekle";
            btnPersonelEkle.UseVisualStyleBackColor = true;
            btnPersonelEkle.Click += btnPersonelEkle_Click;
            // 
            // btnPersonelGuncelle
            // 
            btnPersonelGuncelle.Enabled = false;
            btnPersonelGuncelle.Location = new Point(117, 140);
            btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            btnPersonelGuncelle.Size = new Size(85, 32);
            btnPersonelGuncelle.TabIndex = 5;
            btnPersonelGuncelle.Text = "Güncelle";
            btnPersonelGuncelle.UseVisualStyleBackColor = true;
            btnPersonelGuncelle.Click += btnPersonelGuncelle_Click;
            // 
            // btnPersonelSil
            // 
            btnPersonelSil.Enabled = false;
            btnPersonelSil.Location = new Point(218, 140);
            btnPersonelSil.Name = "btnPersonelSil";
            btnPersonelSil.Size = new Size(85, 32);
            btnPersonelSil.TabIndex = 6;
            btnPersonelSil.Text = "Sil";
            btnPersonelSil.UseVisualStyleBackColor = true;
            btnPersonelSil.Click += btnPersonelSil_Click;
            // 
            // dataGridViewPersoneller
            // 
            dataGridViewPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersoneller.Location = new Point(12, 12);
            dataGridViewPersoneller.MultiSelect = false;
            dataGridViewPersoneller.Name = "dataGridViewPersoneller";
            dataGridViewPersoneller.ReadOnly = true;
            dataGridViewPersoneller.RowHeadersWidth = 51;
            dataGridViewPersoneller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPersoneller.Size = new Size(640, 450);
            dataGridViewPersoneller.TabIndex = 0;
            dataGridViewPersoneller.CellClick += dataGridViewPersoneller_CellClick;
            // 
            // hopeButton1
            // 
            hopeButton1.BorderColor = Color.FromArgb(220, 223, 230);
            hopeButton1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeButton1.DangerColor = Color.FromArgb(245, 108, 108);
            hopeButton1.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeButton1.Font = new Font("Segoe UI", 12F);
            hopeButton1.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeButton1.InfoColor = Color.FromArgb(144, 147, 153);
            hopeButton1.Location = new Point(788, 367);
            hopeButton1.Name = "hopeButton1";
            hopeButton1.PrimaryColor = Color.FromArgb(64, 158, 255);
            hopeButton1.Size = new Size(90, 50);
            hopeButton1.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton1.TabIndex = 34;
            hopeButton1.Text = "Çýkýþ";
            hopeButton1.TextColor = Color.White;
            hopeButton1.WarningColor = Color.FromArgb(230, 162, 60);
            hopeButton1.Click += cksBtn_Click;
            // 
            // hopeButton2
            // 
            hopeButton2.BorderColor = Color.FromArgb(220, 223, 230);
            hopeButton2.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeButton2.DangerColor = Color.FromArgb(245, 108, 108);
            hopeButton2.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeButton2.Font = new Font("Segoe UI", 12F);
            hopeButton2.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeButton2.InfoColor = Color.FromArgb(144, 147, 153);
            hopeButton2.Location = new Point(798, 349);
            hopeButton2.Name = "hopeButton2";
            hopeButton2.PrimaryColor = Color.FromArgb(64, 158, 255);
            hopeButton2.Size = new Size(90, 50);
            hopeButton2.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton2.TabIndex = 34;
            hopeButton2.Text = "Çýkýþ";
            hopeButton2.TextColor = Color.White;
            hopeButton2.WarningColor = Color.FromArgb(230, 162, 60);
            hopeButton2.Click += cksBtn_Click;
            // 
            // FormVeriYonetimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 504);
            Controls.Add(tabControl);
            Name = "FormVeriYonetimi";
            Text = "Veri Yönetimi";
            Load += FormVeriYonetimi_Load;
            tabControl.ResumeLayout(false);
            tabKullanici.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKullanicilar).EndInit();
            tabUcak.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ucakKapasiteTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUcaklar).EndInit();
            tabPersonel.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersoneller).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabKullanici;
        private DataGridView dataGridViewKullanicilar;
        private GroupBox groupBox1;
        private Label labelKullaniciAdi;
        private TextBox kullaniciAdiTB;
        private Label labelSifre;
        private TextBox sifreTB;
        private Label labelAd;
        private TextBox adTB;
        private Label labelSoyad;
        private TextBox soyadTB;
        private Label labelTc;
        private TextBox tcNoTB;
        private Label labelTelefon;
        private TextBox telefonNoTB;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnKaydet;
        private Label labelTip;
        private ComboBox cmbTip;
        private TabPage tabUcak;
        private DataGridView dataGridViewUcaklar;
        private GroupBox groupBox2;
        private TextBox ucakKuyrukNoTB;
        private Label labelKuyrukNo;
        private NumericUpDown ucakKapasiteTB;
        private Label labelKapasite;
        private TextBox ucakModelTB;
        private Label labelModel;
        private Button btnUcakEkle;
        private Button btnUcakGuncelle;
        private Button btnUcakSil;
        private TabPage tabPersonel;
        private DataGridView dataGridViewPersoneller;
        private GroupBox groupBox3;
        private Label labelPersonelTip;
        private ComboBox cmbPersonelTip;
        private TextBox personelSoyadTB;
        private Label labelPersonelSoyad;
        private TextBox personelAdTB;
        private Label labelPersonelAd;
        private Button btnPersonelEkle;
        private Button btnPersonelGuncelle;
        private Button btnPersonelSil;
        private ReaLTaiizor.Controls.HopeButton cksBtn;
        private ReaLTaiizor.Controls.HopeButton hopeButton2;
        private ReaLTaiizor.Controls.HopeButton hopeButton1;
    }
}