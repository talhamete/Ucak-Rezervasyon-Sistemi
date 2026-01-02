namespace BiletRezervasyon.Formlar
{
    partial class FormGiris
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
            kullaniciadi = new Label();
            sifre = new Label();
            txtSifre = new ReaLTaiizor.Controls.HopeTextBox();
            hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            txtKullaniciAdi = new ReaLTaiizor.Controls.HopeTextBox();
            hopeContextMenuStrip1 = new ReaLTaiizor.Controls.HopeContextMenuStrip();
            btnGirisYap = new ReaLTaiizor.Controls.HopeButton();
            SuspendLayout();
            // 
            // kullaniciadi
            // 
            kullaniciadi.AutoSize = true;
            kullaniciadi.Location = new Point(355, 92);
            kullaniciadi.Margin = new Padding(0);
            kullaniciadi.Name = "kullaniciadi";
            kullaniciadi.Size = new Size(92, 20);
            kullaniciadi.TabIndex = 0;
            kullaniciadi.Text = "Kullanıcı Adı";
            // 
            // sifre
            // 
            sifre.AutoSize = true;
            sifre.Location = new Point(355, 185);
            sifre.Name = "sifre";
            sifre.Size = new Size(39, 20);
            sifre.TabIndex = 0;
            sifre.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.White;
            txtSifre.BaseColor = Color.FromArgb(44, 55, 66);
            txtSifre.BorderColorA = Color.FromArgb(64, 158, 255);
            txtSifre.BorderColorB = Color.FromArgb(220, 223, 230);
            txtSifre.Font = new Font("Segoe UI", 12F);
            txtSifre.ForeColor = Color.FromArgb(48, 49, 51);
            txtSifre.Hint = "";
            txtSifre.Location = new Point(355, 208);
            txtSifre.MaxLength = 32767;
            txtSifre.Multiline = false;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.ScrollBars = ScrollBars.None;
            txtSifre.SelectedText = "";
            txtSifre.SelectionLength = 0;
            txtSifre.SelectionStart = 0;
            txtSifre.Size = new Size(154, 43);
            txtSifre.TabIndex = 2;
            txtSifre.TabStop = false;
            txtSifre.UseSystemPasswordChar = false;
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
            hopeForm1.Size = new Size(800, 40);
            hopeForm1.TabIndex = 9;
            hopeForm1.Text = "Uçak Rezervasyon Sistemi";
            hopeForm1.ThemeColor = Color.FromArgb(92, 173, 255);
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.White;
            txtKullaniciAdi.BaseColor = Color.FromArgb(44, 55, 66);
            txtKullaniciAdi.BorderColorA = Color.FromArgb(64, 158, 255);
            txtKullaniciAdi.BorderColorB = Color.FromArgb(220, 223, 230);
            txtKullaniciAdi.Font = new Font("Segoe UI", 12F);
            txtKullaniciAdi.ForeColor = Color.FromArgb(48, 49, 51);
            txtKullaniciAdi.Hint = "";
            txtKullaniciAdi.Location = new Point(355, 115);
            txtKullaniciAdi.MaxLength = 32767;
            txtKullaniciAdi.Multiline = false;
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.PasswordChar = '\0';
            txtKullaniciAdi.ScrollBars = ScrollBars.None;
            txtKullaniciAdi.SelectedText = "";
            txtKullaniciAdi.SelectionLength = 0;
            txtKullaniciAdi.SelectionStart = 0;
            txtKullaniciAdi.Size = new Size(154, 43);
            txtKullaniciAdi.TabIndex = 1;
            txtKullaniciAdi.TabStop = false;
            txtKullaniciAdi.UseSystemPasswordChar = false;
            // 
            // hopeContextMenuStrip1
            // 
            hopeContextMenuStrip1.BackColor = Color.White;
            hopeContextMenuStrip1.ForeColor = Color.FromArgb(48, 49, 51);
            hopeContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            hopeContextMenuStrip1.Name = "hopeContextMenuStrip1";
            hopeContextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnGirisYap
            // 
            btnGirisYap.BorderColor = Color.FromArgb(220, 223, 230);
            btnGirisYap.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnGirisYap.DangerColor = Color.FromArgb(245, 108, 108);
            btnGirisYap.DefaultColor = Color.FromArgb(255, 255, 255);
            btnGirisYap.Font = new Font("Segoe UI", 12F);
            btnGirisYap.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnGirisYap.InfoColor = Color.FromArgb(144, 147, 153);
            btnGirisYap.Location = new Point(355, 314);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnGirisYap.Size = new Size(150, 50);
            btnGirisYap.SuccessColor = Color.FromArgb(103, 194, 58);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.TextColor = Color.White;
            btnGirisYap.WarningColor = Color.FromArgb(230, 162, 60);
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGirisYap);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(hopeForm1);
            Controls.Add(txtSifre);
            Controls.Add(sifre);
            Controls.Add(kullaniciadi);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1020);
            MinimumSize = new Size(190, 40);
            Name = "FormGiris";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dungeonForm1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kullaniciadi;
        private Label sifre;
        private ReaLTaiizor.Controls.HopeTextBox txtSifre;
        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.HopeTextBox txtKullaniciAdi;
        private ReaLTaiizor.Controls.HopeContextMenuStrip hopeContextMenuStrip1;
        private ReaLTaiizor.Controls.HopeButton btnGirisYap;
    }
}