namespace BiletRezervasyon.Formlar
{
    partial class FormKayıt
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
            lblAd = new Label();
            lblSoyad = new Label();
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            lblTcNo = new Label();
            lblTelefonNo = new Label();
            txtAd = new ReaLTaiizor.Controls.HopeTextBox();
            txtSoyad = new ReaLTaiizor.Controls.HopeTextBox();
            txtKullaniciAdi = new ReaLTaiizor.Controls.HopeTextBox();
            txtSifre = new ReaLTaiizor.Controls.HopeTextBox();
            txtTcNo = new ReaLTaiizor.Controls.HopeTextBox();
            txtTelefonNo = new ReaLTaiizor.Controls.HopeTextBox();
            btnKayitOl = new ReaLTaiizor.Controls.HopeButton();
            btnGeriDon = new ReaLTaiizor.Controls.HopeButton();
            lblBaslik = new Label();
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
            hopeForm1.Size = new Size(600, 40);
            hopeForm1.TabIndex = 0;
            hopeForm1.Text = "Müşteri Kayıt Formu";
            hopeForm1.ThemeColor = Color.FromArgb(92, 173, 255);
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 11F);
            lblAd.Location = new Point(80, 100);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(34, 25);
            lblAd.TabIndex = 1;
            lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 11F);
            lblSoyad.Location = new Point(80, 170);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(63, 25);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Font = new Font("Segoe UI", 11F);
            lblKullaniciAdi.Location = new Point(80, 240);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(116, 25);
            lblKullaniciAdi.TabIndex = 3;
            lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI", 11F);
            lblSifre.Location = new Point(80, 310);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(48, 25);
            lblSifre.TabIndex = 4;
            lblSifre.Text = "Şifre";
            // 
            // lblTcNo
            // 
            lblTcNo.AutoSize = true;
            lblTcNo.Font = new Font("Segoe UI", 11F);
            lblTcNo.Location = new Point(80, 380);
            lblTcNo.Name = "lblTcNo";
            lblTcNo.Size = new Size(173, 25);
            lblTcNo.TabIndex = 5;
            lblTcNo.Text = "TC Kimlik Numarası";
            // 
            // lblTelefonNo
            // 
            lblTelefonNo.AutoSize = true;
            lblTelefonNo.Font = new Font("Segoe UI", 11F);
            lblTelefonNo.Location = new Point(80, 450);
            lblTelefonNo.Name = "lblTelefonNo";
            lblTelefonNo.Size = new Size(145, 25);
            lblTelefonNo.TabIndex = 6;
            lblTelefonNo.Text = "Telefon Numarası";
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.White;
            txtAd.BaseColor = Color.FromArgb(44, 55, 66);
            txtAd.BorderColorA = Color.FromArgb(64, 158, 255);
            txtAd.BorderColorB = Color.FromArgb(220, 223, 230);
            txtAd.Font = new Font("Segoe UI", 11F);
            txtAd.ForeColor = Color.FromArgb(48, 49, 51);
            txtAd.Hint = "";
            txtAd.Location = new Point(300, 90);
            txtAd.MaxLength = 32767;
            txtAd.Multiline = false;
            txtAd.Name = "txtAd";
            txtAd.PasswordChar = '\0';
            txtAd.ScrollBars = ScrollBars.None;
            txtAd.SelectedText = "";
            txtAd.SelectionLength = 0;
            txtAd.SelectionStart = 0;
            txtAd.Size = new Size(220, 43);
            txtAd.TabIndex = 1;
            txtAd.TabStop = false;
            txtAd.UseSystemPasswordChar = false;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.White;
            txtSoyad.BaseColor = Color.FromArgb(44, 55, 66);
            txtSoyad.BorderColorA = Color.FromArgb(64, 158, 255);
            txtSoyad.BorderColorB = Color.FromArgb(220, 223, 230);
            txtSoyad.Font = new Font("Segoe UI", 11F);
            txtSoyad.ForeColor = Color.FromArgb(48, 49, 51);
            txtSoyad.Hint = "";
            txtSoyad.Location = new Point(300, 160);
            txtSoyad.MaxLength = 32767;
            txtSoyad.Multiline = false;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.PasswordChar = '\0';
            txtSoyad.ScrollBars = ScrollBars.None;
            txtSoyad.SelectedText = "";
            txtSoyad.SelectionLength = 0;
            txtSoyad.SelectionStart = 0;
            txtSoyad.Size = new Size(220, 43);
            txtSoyad.TabIndex = 2;
            txtSoyad.TabStop = false;
            txtSoyad.UseSystemPasswordChar = false;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.White;
            txtKullaniciAdi.BaseColor = Color.FromArgb(44, 55, 66);
            txtKullaniciAdi.BorderColorA = Color.FromArgb(64, 158, 255);
            txtKullaniciAdi.BorderColorB = Color.FromArgb(220, 223, 230);
            txtKullaniciAdi.Font = new Font("Segoe UI", 11F);
            txtKullaniciAdi.ForeColor = Color.FromArgb(48, 49, 51);
            txtKullaniciAdi.Hint = "";
            txtKullaniciAdi.Location = new Point(300, 230);
            txtKullaniciAdi.MaxLength = 32767;
            txtKullaniciAdi.Multiline = false;
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.PasswordChar = '\0';
            txtKullaniciAdi.ScrollBars = ScrollBars.None;
            txtKullaniciAdi.SelectedText = "";
            txtKullaniciAdi.SelectionLength = 0;
            txtKullaniciAdi.SelectionStart = 0;
            txtKullaniciAdi.Size = new Size(220, 43);
            txtKullaniciAdi.TabIndex = 3;
            txtKullaniciAdi.TabStop = false;
            txtKullaniciAdi.UseSystemPasswordChar = false;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.White;
            txtSifre.BaseColor = Color.FromArgb(44, 55, 66);
            txtSifre.BorderColorA = Color.FromArgb(64, 158, 255);
            txtSifre.BorderColorB = Color.FromArgb(220, 223, 230);
            txtSifre.Font = new Font("Segoe UI", 11F);
            txtSifre.ForeColor = Color.FromArgb(48, 49, 51);
            txtSifre.Hint = "";
            txtSifre.Location = new Point(300, 300);
            txtSifre.MaxLength = 32767;
            txtSifre.Multiline = false;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.ScrollBars = ScrollBars.None;
            txtSifre.SelectedText = "";
            txtSifre.SelectionLength = 0;
            txtSifre.SelectionStart = 0;
            txtSifre.Size = new Size(220, 43);
            txtSifre.TabIndex = 4;
            txtSifre.TabStop = false;
            txtSifre.UseSystemPasswordChar = false;
            // 
            // txtTcNo
            // 
            txtTcNo.BackColor = Color.White;
            txtTcNo.BaseColor = Color.FromArgb(44, 55, 66);
            txtTcNo.BorderColorA = Color.FromArgb(64, 158, 255);
            txtTcNo.BorderColorB = Color.FromArgb(220, 223, 230);
            txtTcNo.Font = new Font("Segoe UI", 11F);
            txtTcNo.ForeColor = Color.FromArgb(48, 49, 51);
            txtTcNo.Hint = "11 haneli";
            txtTcNo.Location = new Point(300, 370);
            txtTcNo.MaxLength = 11;
            txtTcNo.Multiline = false;
            txtTcNo.Name = "txtTcNo";
            txtTcNo.PasswordChar = '\0';
            txtTcNo.ScrollBars = ScrollBars.None;
            txtTcNo.SelectedText = "";
            txtTcNo.SelectionLength = 0;
            txtTcNo.SelectionStart = 0;
            txtTcNo.Size = new Size(220, 43);
            txtTcNo.TabIndex = 5;
            txtTcNo.TabStop = false;
            txtTcNo.UseSystemPasswordChar = false;
            // 
            // txtTelefonNo
            // 
            txtTelefonNo.BackColor = Color.White;
            txtTelefonNo.BaseColor = Color.FromArgb(44, 55, 66);
            txtTelefonNo.BorderColorA = Color.FromArgb(64, 158, 255);
            txtTelefonNo.BorderColorB = Color.FromArgb(220, 223, 230);
            txtTelefonNo.Font = new Font("Segoe UI", 11F);
            txtTelefonNo.ForeColor = Color.FromArgb(48, 49, 51);
            txtTelefonNo.Hint = "05xxxxxxxxx";
            txtTelefonNo.Location = new Point(300, 440);
            txtTelefonNo.MaxLength = 11;
            txtTelefonNo.Multiline = false;
            txtTelefonNo.Name = "txtTelefonNo";
            txtTelefonNo.PasswordChar = '\0';
            txtTelefonNo.ScrollBars = ScrollBars.None;
            txtTelefonNo.SelectedText = "";
            txtTelefonNo.SelectionLength = 0;
            txtTelefonNo.SelectionStart = 0;
            txtTelefonNo.Size = new Size(220, 43);
            txtTelefonNo.TabIndex = 6;
            txtTelefonNo.TabStop = false;
            txtTelefonNo.UseSystemPasswordChar = false;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BorderColor = Color.FromArgb(220, 223, 230);
            btnKayitOl.ButtonType = ReaLTaiizor.Util.HopeButtonType.Success;
            btnKayitOl.DangerColor = Color.FromArgb(245, 108, 108);
            btnKayitOl.DefaultColor = Color.FromArgb(255, 255, 255);
            btnKayitOl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKayitOl.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnKayitOl.InfoColor = Color.FromArgb(144, 147, 153);
            btnKayitOl.Location = new Point(150, 520);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnKayitOl.Size = new Size(150, 55);
            btnKayitOl.SuccessColor = Color.FromArgb(103, 194, 58);
            btnKayitOl.TabIndex = 7;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.TextColor = Color.White;
            btnKayitOl.WarningColor = Color.FromArgb(230, 162, 60);
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BorderColor = Color.FromArgb(220, 223, 230);
            btnGeriDon.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnGeriDon.DangerColor = Color.FromArgb(245, 108, 108);
            btnGeriDon.DefaultColor = Color.FromArgb(255, 255, 255);
            btnGeriDon.Font = new Font("Segoe UI", 12F);
            btnGeriDon.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnGeriDon.InfoColor = Color.FromArgb(144, 147, 153);
            btnGeriDon.Location = new Point(320, 520);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.PrimaryColor = Color.FromArgb(144, 147, 153);
            btnGeriDon.Size = new Size(150, 55);
            btnGeriDon.SuccessColor = Color.FromArgb(103, 194, 58);
            btnGeriDon.TabIndex = 8;
            btnGeriDon.Text = "Geri Dön";
            btnGeriDon.TextColor = Color.White;
            btnGeriDon.WarningColor = Color.FromArgb(230, 162, 60);
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.FromArgb(92, 173, 255);
            lblBaslik.Location = new Point(180, 50);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(250, 32);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Yeni Müşteri Kaydı";
            // 
            // FormKayıt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 600);
            Controls.Add(lblBaslik);
            Controls.Add(btnGeriDon);
            Controls.Add(btnKayitOl);
            Controls.Add(txtTelefonNo);
            Controls.Add(txtTcNo);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblTelefonNo);
            Controls.Add(lblTcNo);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(hopeForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(190, 40);
            Name = "FormKayıt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Kayıt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblKullaniciAdi;
        private Label lblSifre;
        private Label lblTcNo;
        private Label lblTelefonNo;
        private ReaLTaiizor.Controls.HopeTextBox txtAd;
        private ReaLTaiizor.Controls.HopeTextBox txtSoyad;
        private ReaLTaiizor.Controls.HopeTextBox txtKullaniciAdi;
        private ReaLTaiizor.Controls.HopeTextBox txtSifre;
        private ReaLTaiizor.Controls.HopeTextBox txtTcNo;
        private ReaLTaiizor.Controls.HopeTextBox txtTelefonNo;
        private ReaLTaiizor.Controls.HopeButton btnKayitOl;
        private ReaLTaiizor.Controls.HopeButton btnGeriDon;
        private Label lblBaslik;
    }
}