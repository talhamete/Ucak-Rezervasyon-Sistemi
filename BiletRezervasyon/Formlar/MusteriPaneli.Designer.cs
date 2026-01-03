namespace BiletRezervasyon.Formlar
{
    partial class MusteriPaneli
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
            seferlerDGV = new DataGridView();
            rezervasyonlarGDV = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            fiyatlbl = new Label();
            labelKoltuk = new Label();
            koltukCMB = new ComboBox();
            rezerveEtBtn = new ReaLTaiizor.Controls.HopeButton();
            rezervasyonGuncelleBtn = new ReaLTaiizor.Controls.HopeButton();
            rezerveSilBtn = new ReaLTaiizor.Controls.HopeButton();
            cksBtn = new ReaLTaiizor.Controls.HopeButton();
            ((System.ComponentModel.ISupportInitialize)seferlerDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rezervasyonlarGDV).BeginInit();
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
            hopeForm1.Size = new Size(1000, 40);
            hopeForm1.TabIndex = 0;
            hopeForm1.Text = "Müşteri Paneli - Hoşgeldiniz";
            hopeForm1.ThemeColor = Color.FromArgb(92, 173, 255);
            // 
            // seferlerDGV
            // 
            seferlerDGV.AllowUserToAddRows = false;
            seferlerDGV.AllowUserToDeleteRows = false;
            seferlerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            seferlerDGV.Location = new Point(12, 75);
            seferlerDGV.MultiSelect = false;
            seferlerDGV.Name = "seferlerDGV";
            seferlerDGV.ReadOnly = true;
            seferlerDGV.RowHeadersWidth = 51;
            seferlerDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            seferlerDGV.Size = new Size(720, 280);
            seferlerDGV.TabIndex = 1;
            seferlerDGV.CellClick += seferlerDGV_CellClick;
            // 
            // rezervasyonlarGDV
            // 
            rezervasyonlarGDV.AllowUserToAddRows = false;
            rezervasyonlarGDV.AllowUserToDeleteRows = false;
            rezervasyonlarGDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rezervasyonlarGDV.Location = new Point(12, 395);
            rezervasyonlarGDV.MultiSelect = false;
            rezervasyonlarGDV.Name = "rezervasyonlarGDV";
            rezervasyonlarGDV.ReadOnly = true;
            rezervasyonlarGDV.RowHeadersWidth = 51;
            rezervasyonlarGDV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rezervasyonlarGDV.Size = new Size(720, 280);
            rezervasyonlarGDV.TabIndex = 2;
            rezervasyonlarGDV.CellClick += rezervasyonlarGDV_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(92, 173, 255);
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 3;
            label1.Text = "Mevcut Seferler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(92, 173, 255);
            label2.Location = new Point(12, 365);
            label2.Name = "label2";
            label2.Size = new Size(181, 28);
            label2.TabIndex = 4;
            label2.Text = "Rezervasyonlarım";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fiyatlbl);
            groupBox1.Controls.Add(labelKoltuk);
            groupBox1.Controls.Add(koltukCMB);
            groupBox1.Controls.Add(rezerveEtBtn);
            groupBox1.Controls.Add(rezervasyonGuncelleBtn);
            groupBox1.Controls.Add(rezerveSilBtn);
            groupBox1.Controls.Add(cksBtn);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.ForeColor = Color.FromArgb(48, 49, 51);
            groupBox1.Location = new Point(738, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 600);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "İşlemler";
            // 
            // fiyatlbl
            // 
            fiyatlbl.AutoSize = true;
            fiyatlbl.Font = new Font("Segoe UI", 11F);
            fiyatlbl.Location = new Point(7, 105);
            fiyatlbl.Name = "fiyatlbl";
            fiyatlbl.Size = new Size(51, 25);
            fiyatlbl.TabIndex = 6;
            fiyatlbl.Text = "Fiyat";
            // 
            // labelKoltuk
            // 
            labelKoltuk.AutoSize = true;
            labelKoltuk.Font = new Font("Segoe UI", 11F);
            labelKoltuk.Location = new Point(15, 35);
            labelKoltuk.Name = "labelKoltuk";
            labelKoltuk.Size = new Size(119, 25);
            labelKoltuk.TabIndex = 0;
            labelKoltuk.Text = "Koltuk Seçin:";
            // 
            // koltukCMB
            // 
            koltukCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            koltukCMB.Font = new Font("Segoe UI", 11F);
            koltukCMB.FormattingEnabled = true;
            koltukCMB.Location = new Point(15, 65);
            koltukCMB.Name = "koltukCMB";
            koltukCMB.Size = new Size(220, 33);
            koltukCMB.TabIndex = 1;
            // 
            // rezerveEtBtn
            // 
            rezerveEtBtn.BorderColor = Color.FromArgb(220, 223, 230);
            rezerveEtBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Success;
            rezerveEtBtn.DangerColor = Color.FromArgb(245, 108, 108);
            rezerveEtBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            rezerveEtBtn.Enabled = false;
            rezerveEtBtn.Font = new Font("Segoe UI", 12F);
            rezerveEtBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            rezerveEtBtn.InfoColor = Color.FromArgb(144, 147, 153);
            rezerveEtBtn.Location = new Point(15, 351);
            rezerveEtBtn.Name = "rezerveEtBtn";
            rezerveEtBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            rezerveEtBtn.Size = new Size(220, 50);
            rezerveEtBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            rezerveEtBtn.TabIndex = 2;
            rezerveEtBtn.Text = "Rezerve Et";
            rezerveEtBtn.TextColor = Color.White;
            rezerveEtBtn.WarningColor = Color.FromArgb(230, 162, 60);
            rezerveEtBtn.Click += rezerveEtBtn_Click;
            // 
            // rezervasyonGuncelleBtn
            // 
            rezervasyonGuncelleBtn.BorderColor = Color.FromArgb(220, 223, 230);
            rezervasyonGuncelleBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            rezervasyonGuncelleBtn.DangerColor = Color.FromArgb(245, 108, 108);
            rezervasyonGuncelleBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            rezervasyonGuncelleBtn.Enabled = false;
            rezervasyonGuncelleBtn.Font = new Font("Segoe UI", 12F);
            rezervasyonGuncelleBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            rezervasyonGuncelleBtn.InfoColor = Color.FromArgb(144, 147, 153);
            rezervasyonGuncelleBtn.Location = new Point(15, 407);
            rezervasyonGuncelleBtn.Name = "rezervasyonGuncelleBtn";
            rezervasyonGuncelleBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            rezervasyonGuncelleBtn.Size = new Size(220, 50);
            rezervasyonGuncelleBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            rezervasyonGuncelleBtn.TabIndex = 3;
            rezervasyonGuncelleBtn.Text = "Rezervasyonu Güncelle";
            rezervasyonGuncelleBtn.TextColor = Color.White;
            rezervasyonGuncelleBtn.WarningColor = Color.FromArgb(230, 162, 60);
            rezervasyonGuncelleBtn.Click += rezervasyonGuncelleBtn_Click;
            // 
            // rezerveSilBtn
            // 
            rezerveSilBtn.BorderColor = Color.FromArgb(220, 223, 230);
            rezerveSilBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Danger;
            rezerveSilBtn.DangerColor = Color.FromArgb(245, 108, 108);
            rezerveSilBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            rezerveSilBtn.Enabled = false;
            rezerveSilBtn.Font = new Font("Segoe UI", 12F);
            rezerveSilBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            rezerveSilBtn.InfoColor = Color.FromArgb(144, 147, 153);
            rezerveSilBtn.Location = new Point(15, 466);
            rezerveSilBtn.Name = "rezerveSilBtn";
            rezerveSilBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            rezerveSilBtn.Size = new Size(220, 50);
            rezerveSilBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            rezerveSilBtn.TabIndex = 4;
            rezerveSilBtn.Text = "Rezervasyonu Sil";
            rezerveSilBtn.TextColor = Color.White;
            rezerveSilBtn.WarningColor = Color.FromArgb(230, 162, 60);
            rezerveSilBtn.Click += rezerveSilBtn_Click;
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
            cksBtn.Location = new Point(15, 530);
            cksBtn.Name = "cksBtn";
            cksBtn.PrimaryColor = Color.FromArgb(64, 0, 64);
            cksBtn.Size = new Size(220, 50);
            cksBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            cksBtn.TabIndex = 5;
            cksBtn.Text = "Çıkış Yap";
            cksBtn.TextColor = Color.White;
            cksBtn.WarningColor = Color.FromArgb(230, 162, 60);
            cksBtn.Click += hopeButton1_Click;
            // 
            // MusteriPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 687);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rezervasyonlarGDV);
            Controls.Add(seferlerDGV);
            Controls.Add(hopeForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(190, 40);
            Name = "MusteriPaneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Paneli";
            Load += MusteriPencere_Load;
            ((System.ComponentModel.ISupportInitialize)seferlerDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)rezervasyonlarGDV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private DataGridView seferlerDGV;
        private DataGridView rezervasyonlarGDV;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label labelKoltuk;
        private ComboBox koltukCMB;
        private ReaLTaiizor.Controls.HopeButton rezerveEtBtn;
        private ReaLTaiizor.Controls.HopeButton rezerveSilBtn;
        private ReaLTaiizor.Controls.HopeButton rezervasyonGuncelleBtn;
        private ReaLTaiizor.Controls.HopeButton cksBtn;
        private Label fiyatlbl;
        private TextBox fiyatTB;
    }
}