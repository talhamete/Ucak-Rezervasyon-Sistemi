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
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGirisYap = new Button();
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
            sifre.Location = new Point(380, 252);
            sifre.Name = "sifre";
            sifre.Size = new Size(39, 20);
            sifre.TabIndex = 1;
            sifre.Text = "Şifre";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(355, 115);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(125, 27);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(380, 275);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(365, 348);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(94, 29);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(sifre);
            Controls.Add(kullaniciadi);
            Name = "FormGiris";
            Text = "FormGiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kullaniciadi;
        private Label sifre;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGirisYap;
    }
}