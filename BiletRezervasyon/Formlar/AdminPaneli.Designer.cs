namespace BiletRezervasyon.Formlar
{
    partial class AdminPaneli
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label11 = new Label();
            timePicker = new DateTimePicker();
            BtnVeriYonetimi = new ReaLTaiizor.Controls.HopeButton();
            label10 = new Label();
            label9 = new Label();
            datePicker = new DateTimePicker();
            label8 = new Label();
            ucakKapasiteTB = new TextBox();
            label7 = new Label();
            ucakModelTB = new TextBox();
            kabinMEkle = new Button();
            cmbUcak = new ComboBox();
            cmbPilot = new ComboBox();
            cmbKabinM = new ComboBox();
            cmbVaris = new ComboBox();
            cmbKalkis = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            kabinMLB = new ListBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            seferNoTB = new TextBox();
            btnEkle = new ReaLTaiizor.Controls.HopeButton();
            btnGuncelle = new ReaLTaiizor.Controls.HopeButton();
            btnSil = new ReaLTaiizor.Controls.HopeButton();
            cksBtn = new ReaLTaiizor.Controls.HopeButton();
            labelBaslik = new Label();
            fiyatTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
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
            hopeForm1.Image = null;
            hopeForm1.Location = new Point(0, 0);
            hopeForm1.Name = "hopeForm1";
            hopeForm1.Size = new Size(1300, 40);
            hopeForm1.TabIndex = 0;
            hopeForm1.Text = "Admin Paneli";
            hopeForm1.ThemeColor = Color.FromArgb(92, 173, 255);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 95);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(720, 610);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fiyatTB);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(timePicker);
            groupBox1.Controls.Add(BtnVeriYonetimi);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(datePicker);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(ucakKapasiteTB);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(ucakModelTB);
            groupBox1.Controls.Add(kabinMEkle);
            groupBox1.Controls.Add(cmbUcak);
            groupBox1.Controls.Add(cmbPilot);
            groupBox1.Controls.Add(cmbKabinM);
            groupBox1.Controls.Add(cmbVaris);
            groupBox1.Controls.Add(cmbKalkis);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(kabinMLB);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(seferNoTB);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(cksBtn);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.ForeColor = Color.FromArgb(48, 49, 51);
            groupBox1.Location = new Point(738, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(550, 610);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sefer Bilgileri";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(16, 353);
            label11.Name = "label11";
            label11.Size = new Size(85, 23);
            label11.TabIndex = 26;
            label11.Text = "Base Fiyat";
            // 
            // timePicker
            // 
            timePicker.CustomFormat = "HH:mm";
            timePicker.Font = new Font("Segoe UI", 10F);
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.Location = new Point(150, 240);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(180, 30);
            timePicker.TabIndex = 9;
            // 
            // BtnVeriYonetimi
            // 
            BtnVeriYonetimi.BorderColor = Color.FromArgb(220, 223, 230);
            BtnVeriYonetimi.ButtonType = ReaLTaiizor.Util.HopeButtonType.Warning;
            BtnVeriYonetimi.DangerColor = Color.FromArgb(245, 108, 108);
            BtnVeriYonetimi.DefaultColor = Color.FromArgb(255, 255, 255);
            BtnVeriYonetimi.Font = new Font("Segoe UI", 12F);
            BtnVeriYonetimi.HoverTextColor = Color.FromArgb(48, 49, 51);
            BtnVeriYonetimi.InfoColor = Color.FromArgb(144, 147, 153);
            BtnVeriYonetimi.Location = new Point(16, 540);
            BtnVeriYonetimi.Name = "BtnVeriYonetimi";
            BtnVeriYonetimi.PrimaryColor = Color.FromArgb(64, 158, 255);
            BtnVeriYonetimi.Size = new Size(160, 50);
            BtnVeriYonetimi.SuccessColor = Color.FromArgb(103, 194, 58);
            BtnVeriYonetimi.TabIndex = 15;
            BtnVeriYonetimi.Text = "Veri Yönetimi";
            BtnVeriYonetimi.TextColor = Color.White;
            BtnVeriYonetimi.WarningColor = Color.FromArgb(230, 162, 60);
            BtnVeriYonetimi.Click += BtnVeriYonetimi_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(15, 243);
            label10.Name = "label10";
            label10.Size = new Size(94, 23);
            label10.TabIndex = 24;
            label10.Text = "Kalkış Saati";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(15, 205);
            label9.Name = "label9";
            label9.Size = new Size(99, 23);
            label9.TabIndex = 23;
            label9.Text = "Kalkış Günü";
            // 
            // datePicker
            // 
            datePicker.CustomFormat = "dd.MM.yyyy";
            datePicker.Font = new Font("Segoe UI", 10F);
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(150, 202);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(180, 30);
            datePicker.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(15, 167);
            label8.Name = "label8";
            label8.Size = new Size(74, 23);
            label8.TabIndex = 21;
            label8.Text = "Kapasite";
            // 
            // ucakKapasiteTB
            // 
            ucakKapasiteTB.Font = new Font("Segoe UI", 10F);
            ucakKapasiteTB.Location = new Point(150, 164);
            ucakKapasiteTB.Name = "ucakKapasiteTB";
            ucakKapasiteTB.ReadOnly = true;
            ucakKapasiteTB.Size = new Size(180, 30);
            ucakKapasiteTB.TabIndex = 20;
            ucakKapasiteTB.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(15, 129);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 19;
            label7.Text = "Uçak Model";
            // 
            // ucakModelTB
            // 
            ucakModelTB.Font = new Font("Segoe UI", 10F);
            ucakModelTB.Location = new Point(150, 126);
            ucakModelTB.Name = "ucakModelTB";
            ucakModelTB.ReadOnly = true;
            ucakModelTB.Size = new Size(180, 30);
            ucakModelTB.TabIndex = 18;
            ucakModelTB.TabStop = false;
            // 
            // kabinMEkle
            // 
            kabinMEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            kabinMEkle.Location = new Point(495, 116);
            kabinMEkle.Name = "kabinMEkle";
            kabinMEkle.Size = new Size(40, 35);
            kabinMEkle.TabIndex = 4;
            kabinMEkle.Text = "+";
            kabinMEkle.UseVisualStyleBackColor = true;
            kabinMEkle.Click += kabinMEkle_Click;
            // 
            // cmbUcak
            // 
            cmbUcak.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUcak.Font = new Font("Segoe UI", 10F);
            cmbUcak.FormattingEnabled = true;
            cmbUcak.Location = new Point(150, 88);
            cmbUcak.Name = "cmbUcak";
            cmbUcak.Size = new Size(180, 31);
            cmbUcak.TabIndex = 5;
            cmbUcak.SelectedIndexChanged += cmbUcak_SelectedIndexChanged;
            // 
            // cmbPilot
            // 
            cmbPilot.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPilot.Font = new Font("Segoe UI", 10F);
            cmbPilot.FormattingEnabled = true;
            cmbPilot.Location = new Point(355, 345);
            cmbPilot.Name = "cmbPilot";
            cmbPilot.Size = new Size(180, 31);
            cmbPilot.TabIndex = 11;
            // 
            // cmbKabinM
            // 
            cmbKabinM.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKabinM.Font = new Font("Segoe UI", 10F);
            cmbKabinM.FormattingEnabled = true;
            cmbKabinM.Location = new Point(355, 80);
            cmbKabinM.Name = "cmbKabinM";
            cmbKabinM.Size = new Size(180, 31);
            cmbKabinM.TabIndex = 3;
            // 
            // cmbVaris
            // 
            cmbVaris.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVaris.Font = new Font("Segoe UI", 10F);
            cmbVaris.FormattingEnabled = true;
            cmbVaris.Location = new Point(150, 276);
            cmbVaris.Name = "cmbVaris";
            cmbVaris.Size = new Size(180, 31);
            cmbVaris.TabIndex = 10;
            // 
            // cmbKalkis
            // 
            cmbKalkis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKalkis.Font = new Font("Segoe UI", 10F);
            cmbKalkis.FormattingEnabled = true;
            cmbKalkis.Location = new Point(150, 313);
            cmbKalkis.Name = "cmbKalkis";
            cmbKalkis.Size = new Size(180, 31);
            cmbKalkis.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(16, 279);
            label5.Name = "label5";
            label5.Size = new Size(46, 23);
            label5.TabIndex = 11;
            label5.Text = "Varış";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(15, 313);
            label6.Name = "label6";
            label6.Size = new Size(52, 23);
            label6.TabIndex = 10;
            label6.Text = "Kalkış";
            // 
            // kabinMLB
            // 
            kabinMLB.Font = new Font("Segoe UI", 10F);
            kabinMLB.FormattingEnabled = true;
            kabinMLB.ItemHeight = 23;
            kabinMLB.Location = new Point(355, 116);
            kabinMLB.Name = "kabinMLB";
            kabinMLB.Size = new Size(134, 188);
            kabinMLB.TabIndex = 9;
            kabinMLB.TabStop = false;
            kabinMLB.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(355, 50);
            label4.Name = "label4";
            label4.Size = new Size(136, 23);
            label4.TabIndex = 8;
            label4.Text = "Kabin Memurları";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(355, 319);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 7;
            label3.Text = "Pilot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(15, 91);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 6;
            label2.Text = "Uçak";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(15, 53);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 5;
            label1.Text = "Sefer No";
            // 
            // seferNoTB
            // 
            seferNoTB.Font = new Font("Segoe UI", 10F);
            seferNoTB.Location = new Point(150, 50);
            seferNoTB.Name = "seferNoTB";
            seferNoTB.ReadOnly = true;
            seferNoTB.Size = new Size(180, 30);
            seferNoTB.TabIndex = 4;
            seferNoTB.TabStop = false;
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
            btnEkle.Location = new Point(15, 445);
            btnEkle.Name = "btnEkle";
            btnEkle.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnEkle.Size = new Size(160, 50);
            btnEkle.SuccessColor = Color.FromArgb(103, 194, 58);
            btnEkle.TabIndex = 12;
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
            btnGuncelle.Location = new Point(195, 445);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnGuncelle.Size = new Size(160, 50);
            btnGuncelle.SuccessColor = Color.FromArgb(103, 194, 58);
            btnGuncelle.TabIndex = 13;
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
            btnSil.Location = new Point(375, 445);
            btnSil.Name = "btnSil";
            btnSil.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnSil.Size = new Size(160, 50);
            btnSil.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSil.TabIndex = 14;
            btnSil.Text = "Sil";
            btnSil.TextColor = Color.White;
            btnSil.WarningColor = Color.FromArgb(230, 162, 60);
            btnSil.Click += btnSil_Click;
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
            cksBtn.Location = new Point(375, 540);
            cksBtn.Name = "cksBtn";
            cksBtn.PrimaryColor = Color.FromArgb(64, 0, 64);
            cksBtn.Size = new Size(160, 50);
            cksBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            cksBtn.TabIndex = 16;
            cksBtn.Text = "Çıkış Yap";
            cksBtn.TextColor = Color.White;
            cksBtn.WarningColor = Color.FromArgb(230, 162, 60);
            cksBtn.Click += cksBtn_Click;
            // 
            // labelBaslik
            // 
            labelBaslik.AutoSize = true;
            labelBaslik.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelBaslik.ForeColor = Color.FromArgb(92, 173, 255);
            labelBaslik.Location = new Point(12, 55);
            labelBaslik.Name = "labelBaslik";
            labelBaslik.Size = new Size(163, 28);
            labelBaslik.TabIndex = 3;
            labelBaslik.Text = "Mevcut Seferler";
            // 
            // fiyatTB
            // 
            fiyatTB.Font = new Font("Segoe UI", 10F);
            fiyatTB.Location = new Point(150, 353);
            fiyatTB.Name = "fiyatTB";
            fiyatTB.Size = new Size(180, 30);
            fiyatTB.TabIndex = 27;
            fiyatTB.TabStop = false;
            // 
            // AdminPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 717);
            Controls.Add(labelBaslik);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(hopeForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(190, 40);
            Name = "AdminPaneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Paneli";
            Load += AdminPaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox seferNoTB;
        private ReaLTaiizor.Controls.HopeButton btnEkle;
        private ReaLTaiizor.Controls.HopeButton btnSil;
        private ReaLTaiizor.Controls.HopeButton btnGuncelle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox kabinMLB;
        private Label label6;
        private Label label5;
        private ComboBox cmbKalkis;
        private ComboBox cmbVaris;
        private ComboBox cmbKabinM;
        private ComboBox cmbPilot;
        private ComboBox cmbUcak;
        private Button kabinMEkle;
        private TextBox ucakModelTB;
        private Label label7;
        private TextBox ucakKapasiteTB;
        private Label label8;
        private DateTimePicker datePicker;
        private Label label9;
        private Label label10;
        private DateTimePicker timePicker;
        private ReaLTaiizor.Controls.HopeButton BtnVeriYonetimi;
        private ReaLTaiizor.Controls.HopeButton cksBtn;
        private Label labelBaslik;
        private Label label11;
        private TextBox fiyatTB;
    }
}