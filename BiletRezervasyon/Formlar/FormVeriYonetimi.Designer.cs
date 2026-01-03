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
            hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
            tabKullanici = new TabPage();
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
            btnEkle = new ReaLTaiizor.Controls.HopeButton();
            btnGuncelle = new ReaLTaiizor.Controls.HopeButton();
            btnSil = new ReaLTaiizor.Controls.HopeButton();
            dataGridViewKullanicilar = new DataGridView();
            tabUcak = new TabPage();
            groupBox2 = new GroupBox();
            ucakKuyrukNoTB = new TextBox();
            labelKuyrukNo = new Label();
            ucakKapasiteTB = new NumericUpDown();
            labelKapasite = new Label();
            ucakModelTB = new TextBox();
            labelModel = new Label();
            btnUcakEkle = new ReaLTaiizor.Controls.HopeButton();
            btnUcakGuncelle = new ReaLTaiizor.Controls.HopeButton();
            btnUcakSil = new ReaLTaiizor.Controls.HopeButton();
            dataGridViewUcaklar = new DataGridView();
            tabPersonel = new TabPage();
            groupBox3 = new GroupBox();
            labelPersonelTip = new Label();
            cmbPersonelTip = new ComboBox();
            personelSoyadTB = new TextBox();
            labelPersonelSoyad = new Label();
            personelAdTB = new TextBox();
            labelPersonelAd = new Label();
            btnPersonelEkle = new ReaLTaiizor.Controls.HopeButton();
            btnPersonelGuncelle = new ReaLTaiizor.Controls.HopeButton();
            btnPersonelSil = new ReaLTaiizor.Controls.HopeButton();
            dataGridViewPersoneller = new DataGridView();
            cksBtn = new ReaLTaiizor.Controls.HopeButton();
            hopeTabPage1.SuspendLayout();
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
            // hopeForm1
            // 
            hopeForm1.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hopeForm1.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hopeForm1.ControlBoxColorN = Color.White;
            hopeForm1.Dock = DockStyle.Top;
            hopeForm1.Font = new Font("Segoe UI", 12F);
            hopeForm1.ForeColor = Color.FromArgb(242, 246, 252);
            hopeForm1.Image = Properties.Resources.kou;
            hopeForm1.Location = new Point(0, 0);
            hopeForm1.Name = "hopeForm1";
            hopeForm1.Size = new Size(1040, 40);
            hopeForm1.TabIndex = 0;
            hopeForm1.Text = "Veri Yönetimi Paneli";
            hopeForm1.ThemeColor = Color.FromArgb(92, 173, 255);
            // 
            // hopeTabPage1
            // 
            hopeTabPage1.BaseColor = Color.White;
            hopeTabPage1.Controls.Add(tabKullanici);
            hopeTabPage1.Controls.Add(tabUcak);
            hopeTabPage1.Controls.Add(tabPersonel);
            hopeTabPage1.Font = new Font("Segoe UI", 12F);
            hopeTabPage1.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTabPage1.ForeColorA = Color.Black;
            hopeTabPage1.ForeColorB = Color.Gray;
            hopeTabPage1.ForeColorC = Color.FromArgb(150, 255, 255, 255);
            hopeTabPage1.ItemSize = new Size(120, 40);
            hopeTabPage1.Location = new Point(0, 40);
            hopeTabPage1.Name = "hopeTabPage1";
            hopeTabPage1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopeTabPage1.SelectedIndex = 0;
            hopeTabPage1.Size = new Size(1040, 464);
            hopeTabPage1.SizeMode = TabSizeMode.Fixed;
            hopeTabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopeTabPage1.TabIndex = 1;
            hopeTabPage1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            hopeTabPage1.ThemeColorA = Color.FromArgb(92, 173, 255);
            hopeTabPage1.ThemeColorB = Color.FromArgb(150, 64, 158, 255);
            hopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // tabKullanici
            // 
            tabKullanici.BackColor = Color.White;
            tabKullanici.Controls.Add(groupBox1);
            tabKullanici.Controls.Add(dataGridViewKullanicilar);
            tabKullanici.Location = new Point(0, 40);
            tabKullanici.Name = "tabKullanici";
            tabKullanici.Padding = new Padding(3);
            tabKullanici.Size = new Size(1040, 424);
            tabKullanici.TabIndex = 0;
            tabKullanici.Text = "Kullanýcý Yönetimi";
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
            groupBox1.Location = new Point(639, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 412);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanýcý Bilgileri";
            // 
            // labelTip
            // 
            labelTip.AutoSize = true;
            labelTip.Location = new Point(15, 35);
            labelTip.Name = "labelTip";
            labelTip.Size = new Size(39, 28);
            labelTip.TabIndex = 0;
            labelTip.Text = "Tip";
            // 
            // cmbTip
            // 
            cmbTip.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTip.FormattingEnabled = true;
            cmbTip.Items.AddRange(new object[] { "admin", "musteri" });
            cmbTip.Location = new Point(150, 32);
            cmbTip.Name = "cmbTip";
            cmbTip.Size = new Size(227, 36);
            cmbTip.TabIndex = 1;
            // 
            // telefonNoTB
            // 
            telefonNoTB.Location = new Point(150, 272);
            telefonNoTB.Name = "telefonNoTB";
            telefonNoTB.Size = new Size(227, 34);
            telefonNoTB.TabIndex = 7;
            // 
            // labelTelefon
            // 
            labelTelefon.AutoSize = true;
            labelTelefon.Location = new Point(15, 275);
            labelTelefon.Name = "labelTelefon";
            labelTelefon.Size = new Size(106, 28);
            labelTelefon.TabIndex = 12;
            labelTelefon.Text = "Telefon No";
            // 
            // tcNoTB
            // 
            tcNoTB.Location = new Point(150, 232);
            tcNoTB.Name = "tcNoTB";
            tcNoTB.Size = new Size(227, 34);
            tcNoTB.TabIndex = 6;
            // 
            // labelTc
            // 
            labelTc.AutoSize = true;
            labelTc.Location = new Point(15, 235);
            labelTc.Name = "labelTc";
            labelTc.Size = new Size(56, 28);
            labelTc.TabIndex = 10;
            labelTc.Text = "TcNo";
            // 
            // soyadTB
            // 
            soyadTB.Location = new Point(150, 192);
            soyadTB.Name = "soyadTB";
            soyadTB.Size = new Size(227, 34);
            soyadTB.TabIndex = 5;
            // 
            // labelSoyad
            // 
            labelSoyad.AutoSize = true;
            labelSoyad.Location = new Point(15, 195);
            labelSoyad.Name = "labelSoyad";
            labelSoyad.Size = new Size(67, 28);
            labelSoyad.TabIndex = 8;
            labelSoyad.Text = "Soyad";
            // 
            // adTB
            // 
            adTB.Location = new Point(150, 152);
            adTB.Name = "adTB";
            adTB.Size = new Size(227, 34);
            adTB.TabIndex = 4;
            // 
            // labelAd
            // 
            labelAd.AutoSize = true;
            labelAd.Location = new Point(15, 155);
            labelAd.Name = "labelAd";
            labelAd.Size = new Size(37, 28);
            labelAd.TabIndex = 6;
            labelAd.Text = "Ad";
            // 
            // sifreTB
            // 
            sifreTB.Location = new Point(150, 112);
            sifreTB.Name = "sifreTB";
            sifreTB.Size = new Size(227, 34);
            sifreTB.TabIndex = 3;
            // 
            // labelSifre
            // 
            labelSifre.AutoSize = true;
            labelSifre.Location = new Point(15, 115);
            labelSifre.Name = "labelSifre";
            labelSifre.Size = new Size(51, 28);
            labelSifre.TabIndex = 4;
            labelSifre.Text = "Þifre";
            // 
            // kullaniciAdiTB
            // 
            kullaniciAdiTB.Location = new Point(150, 72);
            kullaniciAdiTB.Name = "kullaniciAdiTB";
            kullaniciAdiTB.Size = new Size(227, 34);
            kullaniciAdiTB.TabIndex = 2;
            // 
            // labelKullaniciAdi
            // 
            labelKullaniciAdi.AutoSize = true;
            labelKullaniciAdi.Location = new Point(15, 75);
            labelKullaniciAdi.Name = "labelKullaniciAdi";
            labelKullaniciAdi.Size = new Size(120, 28);
            labelKullaniciAdi.TabIndex = 2;
            labelKullaniciAdi.Text = "Kullanýcý Adý";
            // 
            // btnEkle
            // 
            btnEkle.BorderColor = Color.FromArgb(220, 223, 230);
            btnEkle.ButtonType = ReaLTaiizor.Util.HopeButtonType.Success;
            btnEkle.DangerColor = Color.FromArgb(245, 108, 108);
            btnEkle.DefaultColor = Color.FromArgb(255, 255, 255);
            btnEkle.Font = new Font("Segoe UI", 12F);
            btnEkle.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnEkle.InfoColor = Color.FromArgb(144, 147, 153);
            btnEkle.Location = new Point(15, 350);
            btnEkle.Name = "btnEkle";
            btnEkle.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnEkle.Size = new Size(100, 50);
            btnEkle.SuccessColor = Color.FromArgb(103, 194, 58);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.TextColor = Color.White;
            btnEkle.WarningColor = Color.FromArgb(230, 162, 60);
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BorderColor = Color.FromArgb(220, 223, 230);
            btnGuncelle.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnGuncelle.DangerColor = Color.FromArgb(245, 108, 108);
            btnGuncelle.DefaultColor = Color.FromArgb(255, 255, 255);
            btnGuncelle.Enabled = false;
            btnGuncelle.Font = new Font("Segoe UI", 12F);
            btnGuncelle.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnGuncelle.InfoColor = Color.FromArgb(144, 147, 153);
            btnGuncelle.Location = new Point(121, 350);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnGuncelle.Size = new Size(110, 50);
            btnGuncelle.SuccessColor = Color.FromArgb(103, 194, 58);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.TextColor = Color.White;
            btnGuncelle.WarningColor = Color.FromArgb(230, 162, 60);
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BorderColor = Color.FromArgb(220, 223, 230);
            btnSil.ButtonType = ReaLTaiizor.Util.HopeButtonType.Danger;
            btnSil.DangerColor = Color.FromArgb(245, 108, 108);
            btnSil.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSil.Enabled = false;
            btnSil.Font = new Font("Segoe UI", 12F);
            btnSil.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSil.InfoColor = Color.FromArgb(144, 147, 153);
            btnSil.Location = new Point(237, 350);
            btnSil.Name = "btnSil";
            btnSil.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnSil.Size = new Size(140, 50);
            btnSil.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.TextColor = Color.White;
            btnSil.WarningColor = Color.FromArgb(230, 162, 60);
            btnSil.Click += btnSil_Click;
            // 
            // dataGridViewKullanicilar
            // 
            dataGridViewKullanicilar.AllowUserToAddRows = false;
            dataGridViewKullanicilar.AllowUserToDeleteRows = false;
            dataGridViewKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKullanicilar.Location = new Point(6, 23);
            dataGridViewKullanicilar.MultiSelect = false;
            dataGridViewKullanicilar.Name = "dataGridViewKullanicilar";
            dataGridViewKullanicilar.ReadOnly = true;
            dataGridViewKullanicilar.RowHeadersWidth = 51;
            dataGridViewKullanicilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKullanicilar.Size = new Size(627, 395);
            dataGridViewKullanicilar.TabIndex = 0;
            dataGridViewKullanicilar.CellClick += dataGridViewKullanicilar_CellClick;
            // 
            // tabUcak
            // 
            tabUcak.BackColor = Color.White;
            tabUcak.Controls.Add(groupBox2);
            tabUcak.Controls.Add(dataGridViewUcaklar);
            tabUcak.Location = new Point(0, 40);
            tabUcak.Name = "tabUcak";
            tabUcak.Padding = new Padding(3);
            tabUcak.Size = new Size(1040, 424);
            tabUcak.TabIndex = 1;
            tabUcak.Text = "Uçak Yönetimi";
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
            groupBox2.Location = new Point(639, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(395, 412);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Uçak Bilgileri";
            // 
            // ucakKuyrukNoTB
            // 
            ucakKuyrukNoTB.Location = new Point(150, 112);
            ucakKuyrukNoTB.Name = "ucakKuyrukNoTB";
            ucakKuyrukNoTB.Size = new Size(227, 34);
            ucakKuyrukNoTB.TabIndex = 3;
            // 
            // labelKuyrukNo
            // 
            labelKuyrukNo.AutoSize = true;
            labelKuyrukNo.Location = new Point(15, 115);
            labelKuyrukNo.Name = "labelKuyrukNo";
            labelKuyrukNo.Size = new Size(105, 28);
            labelKuyrukNo.TabIndex = 6;
            labelKuyrukNo.Text = "Kuyruk No";
            // 
            // ucakKapasiteTB
            // 
            ucakKapasiteTB.Location = new Point(150, 72);
            ucakKapasiteTB.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            ucakKapasiteTB.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ucakKapasiteTB.Name = "ucakKapasiteTB";
            ucakKapasiteTB.Size = new Size(227, 34);
            ucakKapasiteTB.TabIndex = 2;
            ucakKapasiteTB.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelKapasite
            // 
            labelKapasite.AutoSize = true;
            labelKapasite.Location = new Point(15, 75);
            labelKapasite.Name = "labelKapasite";
            labelKapasite.Size = new Size(86, 28);
            labelKapasite.TabIndex = 4;
            labelKapasite.Text = "Kapasite";
            // 
            // ucakModelTB
            // 
            ucakModelTB.Location = new Point(150, 32);
            ucakModelTB.Name = "ucakModelTB";
            ucakModelTB.Size = new Size(227, 34);
            ucakModelTB.TabIndex = 1;
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new Point(15, 35);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(69, 28);
            labelModel.TabIndex = 2;
            labelModel.Text = "Model";
            // 
            // btnUcakEkle
            // 
            btnUcakEkle.BorderColor = Color.FromArgb(220, 223, 230);
            btnUcakEkle.ButtonType = ReaLTaiizor.Util.HopeButtonType.Success;
            btnUcakEkle.DangerColor = Color.FromArgb(245, 108, 108);
            btnUcakEkle.DefaultColor = Color.FromArgb(255, 255, 255);
            btnUcakEkle.Font = new Font("Segoe UI", 12F);
            btnUcakEkle.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnUcakEkle.InfoColor = Color.FromArgb(144, 147, 153);
            btnUcakEkle.Location = new Point(15, 350);
            btnUcakEkle.Name = "btnUcakEkle";
            btnUcakEkle.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnUcakEkle.Size = new Size(100, 50);
            btnUcakEkle.SuccessColor = Color.FromArgb(103, 194, 58);
            btnUcakEkle.TabIndex = 4;
            btnUcakEkle.Text = "Ekle";
            btnUcakEkle.TextColor = Color.White;
            btnUcakEkle.WarningColor = Color.FromArgb(230, 162, 60);
            btnUcakEkle.Click += btnUcakEkle_Click;
            // 
            // btnUcakGuncelle
            // 
            btnUcakGuncelle.BorderColor = Color.FromArgb(220, 223, 230);
            btnUcakGuncelle.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnUcakGuncelle.DangerColor = Color.FromArgb(245, 108, 108);
            btnUcakGuncelle.DefaultColor = Color.FromArgb(255, 255, 255);
            btnUcakGuncelle.Enabled = false;
            btnUcakGuncelle.Font = new Font("Segoe UI", 12F);
            btnUcakGuncelle.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnUcakGuncelle.InfoColor = Color.FromArgb(144, 147, 153);
            btnUcakGuncelle.Location = new Point(121, 350);
            btnUcakGuncelle.Name = "btnUcakGuncelle";
            btnUcakGuncelle.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnUcakGuncelle.Size = new Size(110, 50);
            btnUcakGuncelle.SuccessColor = Color.FromArgb(103, 194, 58);
            btnUcakGuncelle.TabIndex = 5;
            btnUcakGuncelle.Text = "Güncelle";
            btnUcakGuncelle.TextColor = Color.White;
            btnUcakGuncelle.WarningColor = Color.FromArgb(230, 162, 60);
            btnUcakGuncelle.Click += btnUcakGuncelle_Click;
            // 
            // btnUcakSil
            // 
            btnUcakSil.BorderColor = Color.FromArgb(220, 223, 230);
            btnUcakSil.ButtonType = ReaLTaiizor.Util.HopeButtonType.Danger;
            btnUcakSil.DangerColor = Color.FromArgb(245, 108, 108);
            btnUcakSil.DefaultColor = Color.FromArgb(255, 255, 255);
            btnUcakSil.Enabled = false;
            btnUcakSil.Font = new Font("Segoe UI", 12F);
            btnUcakSil.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnUcakSil.InfoColor = Color.FromArgb(144, 147, 153);
            btnUcakSil.Location = new Point(237, 350);
            btnUcakSil.Name = "btnUcakSil";
            btnUcakSil.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnUcakSil.Size = new Size(140, 50);
            btnUcakSil.SuccessColor = Color.FromArgb(103, 194, 58);
            btnUcakSil.TabIndex = 6;
            btnUcakSil.Text = "Sil";
            btnUcakSil.TextColor = Color.White;
            btnUcakSil.WarningColor = Color.FromArgb(230, 162, 60);
            btnUcakSil.Click += btnUcakSil_Click;
            // 
            // dataGridViewUcaklar
            // 
            dataGridViewUcaklar.AllowUserToAddRows = false;
            dataGridViewUcaklar.AllowUserToDeleteRows = false;
            dataGridViewUcaklar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUcaklar.Location = new Point(6, 19);
            dataGridViewUcaklar.MultiSelect = false;
            dataGridViewUcaklar.Name = "dataGridViewUcaklar";
            dataGridViewUcaklar.ReadOnly = true;
            dataGridViewUcaklar.RowHeadersWidth = 51;
            dataGridViewUcaklar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUcaklar.Size = new Size(627, 399);
            dataGridViewUcaklar.TabIndex = 0;
            dataGridViewUcaklar.CellClick += dataGridViewUcaklar_CellClick;
            // 
            // tabPersonel
            // 
            tabPersonel.BackColor = Color.White;
            tabPersonel.Controls.Add(groupBox3);
            tabPersonel.Controls.Add(dataGridViewPersoneller);
            tabPersonel.Location = new Point(0, 40);
            tabPersonel.Name = "tabPersonel";
            tabPersonel.Size = new Size(1040, 424);
            tabPersonel.TabIndex = 2;
            tabPersonel.Text = "Personel Yönetimi";
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
            groupBox3.Location = new Point(639, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(395, 412);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personel Bilgileri";
            // 
            // labelPersonelTip
            // 
            labelPersonelTip.AutoSize = true;
            labelPersonelTip.Location = new Point(15, 35);
            labelPersonelTip.Name = "labelPersonelTip";
            labelPersonelTip.Size = new Size(39, 28);
            labelPersonelTip.TabIndex = 0;
            labelPersonelTip.Text = "Tip";
            // 
            // cmbPersonelTip
            // 
            cmbPersonelTip.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonelTip.FormattingEnabled = true;
            cmbPersonelTip.Items.AddRange(new object[] { "Pilot", "KabinMemuru" });
            cmbPersonelTip.Location = new Point(150, 32);
            cmbPersonelTip.Name = "cmbPersonelTip";
            cmbPersonelTip.Size = new Size(227, 36);
            cmbPersonelTip.TabIndex = 1;
            // 
            // personelSoyadTB
            // 
            personelSoyadTB.Location = new Point(150, 112);
            personelSoyadTB.Name = "personelSoyadTB";
            personelSoyadTB.Size = new Size(227, 34);
            personelSoyadTB.TabIndex = 3;
            // 
            // labelPersonelSoyad
            // 
            labelPersonelSoyad.AutoSize = true;
            labelPersonelSoyad.Location = new Point(15, 115);
            labelPersonelSoyad.Name = "labelPersonelSoyad";
            labelPersonelSoyad.Size = new Size(67, 28);
            labelPersonelSoyad.TabIndex = 6;
            labelPersonelSoyad.Text = "Soyad";
            // 
            // personelAdTB
            // 
            personelAdTB.Location = new Point(150, 72);
            personelAdTB.Name = "personelAdTB";
            personelAdTB.Size = new Size(227, 34);
            personelAdTB.TabIndex = 2;
            // 
            // labelPersonelAd
            // 
            labelPersonelAd.AutoSize = true;
            labelPersonelAd.Location = new Point(15, 75);
            labelPersonelAd.Name = "labelPersonelAd";
            labelPersonelAd.Size = new Size(37, 28);
            labelPersonelAd.TabIndex = 2;
            labelPersonelAd.Text = "Ad";
            // 
            // btnPersonelEkle
            // 
            btnPersonelEkle.BorderColor = Color.FromArgb(220, 223, 230);
            btnPersonelEkle.ButtonType = ReaLTaiizor.Util.HopeButtonType.Success;
            btnPersonelEkle.DangerColor = Color.FromArgb(245, 108, 108);
            btnPersonelEkle.DefaultColor = Color.FromArgb(255, 255, 255);
            btnPersonelEkle.Font = new Font("Segoe UI", 12F);
            btnPersonelEkle.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnPersonelEkle.InfoColor = Color.FromArgb(144, 147, 153);
            btnPersonelEkle.Location = new Point(15, 350);
            btnPersonelEkle.Name = "btnPersonelEkle";
            btnPersonelEkle.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnPersonelEkle.Size = new Size(100, 50);
            btnPersonelEkle.SuccessColor = Color.FromArgb(103, 194, 58);
            btnPersonelEkle.TabIndex = 4;
            btnPersonelEkle.Text = "Ekle";
            btnPersonelEkle.TextColor = Color.White;
            btnPersonelEkle.WarningColor = Color.FromArgb(230, 162, 60);
            btnPersonelEkle.Click += btnPersonelEkle_Click;
            // 
            // btnPersonelGuncelle
            // 
            btnPersonelGuncelle.BorderColor = Color.FromArgb(220, 223, 230);
            btnPersonelGuncelle.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnPersonelGuncelle.DangerColor = Color.FromArgb(245, 108, 108);
            btnPersonelGuncelle.DefaultColor = Color.FromArgb(255, 255, 255);
            btnPersonelGuncelle.Enabled = false;
            btnPersonelGuncelle.Font = new Font("Segoe UI", 12F);
            btnPersonelGuncelle.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnPersonelGuncelle.InfoColor = Color.FromArgb(144, 147, 153);
            btnPersonelGuncelle.Location = new Point(121, 350);
            btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            btnPersonelGuncelle.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnPersonelGuncelle.Size = new Size(110, 50);
            btnPersonelGuncelle.SuccessColor = Color.FromArgb(103, 194, 58);
            btnPersonelGuncelle.TabIndex = 5;
            btnPersonelGuncelle.Text = "Güncelle";
            btnPersonelGuncelle.TextColor = Color.White;
            btnPersonelGuncelle.WarningColor = Color.FromArgb(230, 162, 60);
            btnPersonelGuncelle.Click += btnPersonelGuncelle_Click;
            // 
            // btnPersonelSil
            // 
            btnPersonelSil.BorderColor = Color.FromArgb(220, 223, 230);
            btnPersonelSil.ButtonType = ReaLTaiizor.Util.HopeButtonType.Danger;
            btnPersonelSil.DangerColor = Color.FromArgb(245, 108, 108);
            btnPersonelSil.DefaultColor = Color.FromArgb(255, 255, 255);
            btnPersonelSil.Enabled = false;
            btnPersonelSil.Font = new Font("Segoe UI", 12F);
            btnPersonelSil.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnPersonelSil.InfoColor = Color.FromArgb(144, 147, 153);
            btnPersonelSil.Location = new Point(237, 350);
            btnPersonelSil.Name = "btnPersonelSil";
            btnPersonelSil.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnPersonelSil.Size = new Size(140, 50);
            btnPersonelSil.SuccessColor = Color.FromArgb(103, 194, 58);
            btnPersonelSil.TabIndex = 6;
            btnPersonelSil.Text = "Sil";
            btnPersonelSil.TextColor = Color.White;
            btnPersonelSil.WarningColor = Color.FromArgb(230, 162, 60);
            btnPersonelSil.Click += btnPersonelSil_Click;
            // 
            // dataGridViewPersoneller
            // 
            dataGridViewPersoneller.AllowUserToAddRows = false;
            dataGridViewPersoneller.AllowUserToDeleteRows = false;
            dataGridViewPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersoneller.Location = new Point(6, 21);
            dataGridViewPersoneller.MultiSelect = false;
            dataGridViewPersoneller.Name = "dataGridViewPersoneller";
            dataGridViewPersoneller.ReadOnly = true;
            dataGridViewPersoneller.RowHeadersWidth = 51;
            dataGridViewPersoneller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPersoneller.Size = new Size(627, 397);
            dataGridViewPersoneller.TabIndex = 0;
            dataGridViewPersoneller.CellClick += dataGridViewPersoneller_CellClick;
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
            cksBtn.Location = new Point(6, 504);
            cksBtn.Name = "cksBtn";
            cksBtn.PrimaryColor = Color.FromArgb(64, 0, 64);
            cksBtn.Size = new Size(79, 50);
            cksBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            cksBtn.TabIndex = 17;
            cksBtn.Text = "Çýkýþ";
            cksBtn.TextColor = Color.White;
            cksBtn.WarningColor = Color.FromArgb(230, 162, 60);
            cksBtn.Click += cksBtn_Click;
            // 
            // FormVeriYonetimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 557);
            Controls.Add(cksBtn);
            Controls.Add(hopeTabPage1);
            Controls.Add(hopeForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(190, 40);
            Name = "FormVeriYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormVeriYonetimi_Load;
            hopeTabPage1.ResumeLayout(false);
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

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
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
        private ReaLTaiizor.Controls.HopeButton btnEkle;
        private ReaLTaiizor.Controls.HopeButton btnGuncelle;
        private ReaLTaiizor.Controls.HopeButton btnSil;
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
        private ReaLTaiizor.Controls.HopeButton btnUcakEkle;
        private ReaLTaiizor.Controls.HopeButton btnUcakGuncelle;
        private ReaLTaiizor.Controls.HopeButton btnUcakSil;
        private TabPage tabPersonel;
        private DataGridView dataGridViewPersoneller;
        private GroupBox groupBox3;
        private Label labelPersonelTip;
        private ComboBox cmbPersonelTip;
        private TextBox personelSoyadTB;
        private Label labelPersonelSoyad;
        private TextBox personelAdTB;
        private Label labelPersonelAd;
        private ReaLTaiizor.Controls.HopeButton btnPersonelEkle;
        private ReaLTaiizor.Controls.HopeButton btnPersonelGuncelle;
        private ReaLTaiizor.Controls.HopeButton btnPersonelSil;
        private ReaLTaiizor.Controls.HopeButton cksBtn;
    }
}