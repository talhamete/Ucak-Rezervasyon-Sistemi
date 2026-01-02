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
            dataGridView1 = new DataGridView();
            seferNoTB = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            kabinMLB = new ListBox();
            label6 = new Label();
            label5 = new Label();
            cmbKalkis = new ComboBox();
            cmbVaris = new ComboBox();
            cmbKabinM = new ComboBox();
            cmbPilot = new ComboBox();
            cmbUcak = new ComboBox();
            kabinMEkle = new Button();
            ucakModelTB = new TextBox();
            label7 = new Label();
            ucakKapasiteTB = new TextBox();
            label8 = new Label();
            datePicker = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            timePicker = new DateTimePicker();
            groupBox1 = new GroupBox();
            BtnVeriYonetimi = new Button();
            cksBtn = new ReaLTaiizor.Controls.HopeButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 7);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(691, 480);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // seferNoTB
            // 
            seferNoTB.Location = new Point(389, 26);
            seferNoTB.Name = "seferNoTB";
            seferNoTB.ReadOnly = true;
            seferNoTB.Size = new Size(125, 27);
            seferNoTB.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(21, 426);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Enabled = false;
            btnSil.Location = new Point(121, 426);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Enabled = false;
            btnGuncelle.Location = new Point(221, 426);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 33);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 8;
            label1.Text = "Sefer No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 59);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 9;
            label2.Text = "Uçak";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 283);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 10;
            label3.Text = "Pilot";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 90);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 11;
            label4.Text = "Kabin Memurları";
            // 
            // kabinMLB
            // 
            kabinMLB.FormattingEnabled = true;
            kabinMLB.Location = new Point(23, 123);
            kabinMLB.Name = "kabinMLB";
            kabinMLB.Size = new Size(125, 104);
            kabinMLB.TabIndex = 12;
            kabinMLB.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 221);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 15;
            label6.Text = "Kalkış";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(342, 249);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 16;
            label5.Text = "Varış";
            // 
            // cmbKalkis
            // 
            cmbKalkis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKalkis.FormattingEnabled = true;
            cmbKalkis.Location = new Point(388, 218);
            cmbKalkis.Name = "cmbKalkis";
            cmbKalkis.Size = new Size(125, 28);
            cmbKalkis.TabIndex = 17;
            // 
            // cmbVaris
            // 
            cmbVaris.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVaris.FormattingEnabled = true;
            cmbVaris.Location = new Point(388, 249);
            cmbVaris.Name = "cmbVaris";
            cmbVaris.Size = new Size(125, 28);
            cmbVaris.TabIndex = 18;
            // 
            // cmbKabinM
            // 
            cmbKabinM.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKabinM.FormattingEnabled = true;
            cmbKabinM.Location = new Point(148, 87);
            cmbKabinM.Name = "cmbKabinM";
            cmbKabinM.Size = new Size(89, 28);
            cmbKabinM.TabIndex = 19;
            // 
            // cmbPilot
            // 
            cmbPilot.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPilot.FormattingEnabled = true;
            cmbPilot.Location = new Point(388, 283);
            cmbPilot.Name = "cmbPilot";
            cmbPilot.Size = new Size(125, 28);
            cmbPilot.TabIndex = 20;
            // 
            // cmbUcak
            // 
            cmbUcak.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUcak.FormattingEnabled = true;
            cmbUcak.Location = new Point(388, 56);
            cmbUcak.Name = "cmbUcak";
            cmbUcak.Size = new Size(126, 28);
            cmbUcak.TabIndex = 21;
            cmbUcak.SelectedIndexChanged += cmbUcak_SelectedIndexChanged;
            // 
            // kabinMEkle
            // 
            kabinMEkle.Location = new Point(484, 315);
            kabinMEkle.Name = "kabinMEkle";
            kabinMEkle.Size = new Size(30, 30);
            kabinMEkle.TabIndex = 22;
            kabinMEkle.Text = "+";
            kabinMEkle.UseVisualStyleBackColor = true;
            kabinMEkle.Click += kabinMEkle_Click;
            // 
            // ucakModelTB
            // 
            ucakModelTB.Location = new Point(389, 90);
            ucakModelTB.Name = "ucakModelTB";
            ucakModelTB.ReadOnly = true;
            ucakModelTB.Size = new Size(125, 27);
            ucakModelTB.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(294, 90);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 24;
            label7.Text = "Uçak Model";
            // 
            // ucakKapasiteTB
            // 
            ucakKapasiteTB.Location = new Point(389, 123);
            ucakKapasiteTB.Name = "ucakKapasiteTB";
            ucakKapasiteTB.ReadOnly = true;
            ucakKapasiteTB.Size = new Size(125, 27);
            ucakKapasiteTB.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(316, 123);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 26;
            label8.Text = "Kapasite";
            // 
            // datePicker
            // 
            datePicker.Cursor = Cursors.IBeam;
            datePicker.CustomFormat = "dd.MM.yyyy";
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(389, 156);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(125, 27);
            datePicker.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(298, 156);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 28;
            label9.Text = "Kalkış Günü";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(298, 189);
            label10.Name = "label10";
            label10.Size = new Size(84, 20);
            label10.TabIndex = 29;
            label10.Text = "Kalkış Saati";
            // 
            // timePicker
            // 
            timePicker.CustomFormat = "HH:mm";
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.Location = new Point(389, 189);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(125, 27);
            timePicker.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cksBtn);
            groupBox1.Controls.Add(BtnVeriYonetimi);
            groupBox1.Controls.Add(timePicker);
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
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(seferNoTB);
            groupBox1.Location = new Point(705, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(531, 475);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // BtnVeriYonetimi
            // 
            BtnVeriYonetimi.Location = new Point(21, 24);
            BtnVeriYonetimi.Name = "BtnVeriYonetimi";
            BtnVeriYonetimi.Size = new Size(110, 29);
            BtnVeriYonetimi.TabIndex = 31;
            BtnVeriYonetimi.Text = "Veri Yönetimi";
            BtnVeriYonetimi.UseVisualStyleBackColor = true;
            BtnVeriYonetimi.Click += BtnVeriYonetimi_Click;
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
            cksBtn.Location = new Point(373, 405);
            cksBtn.Name = "cksBtn";
            cksBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            cksBtn.Size = new Size(90, 50);
            cksBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            cksBtn.TabIndex = 32;
            cksBtn.Text = "Çıkış";
            cksBtn.TextColor = Color.White;
            cksBtn.WarningColor = Color.FromArgb(230, 162, 60);
            cksBtn.Click += cksBtn_Click;
            // 
            // AdminPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 499);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "AdminPaneli";
            Text = "AdminPaneli";
            Load += AdminPaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox seferNoTB;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
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
        private GroupBox groupBox1;
        private Button BtnVeriYonetimi;
        private ReaLTaiizor.Controls.HopeButton cksBtn;
    }
}