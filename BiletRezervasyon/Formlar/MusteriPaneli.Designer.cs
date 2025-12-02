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
            seferlerDGV = new DataGridView();
            rezervasyonlarGDV = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            koltukCMB = new ComboBox();
            rezerveEtBtn = new Button();
            rezerveSilBtn = new Button();
            rezervasyonGuncelleBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)seferlerDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rezervasyonlarGDV).BeginInit();
            SuspendLayout();
            // 
            // seferlerDGV
            // 
            seferlerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            seferlerDGV.Location = new Point(12, 45);
            seferlerDGV.MultiSelect = false;
            seferlerDGV.Name = "seferlerDGV";
            seferlerDGV.ReadOnly = true;
            seferlerDGV.RowHeadersWidth = 51;
            seferlerDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            seferlerDGV.Size = new Size(719, 364);
            seferlerDGV.TabIndex = 0;
            seferlerDGV.CellClick += seferlerDGV_CellClick;
            // 
            // rezervasyonlarGDV
            // 
            rezervasyonlarGDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rezervasyonlarGDV.Location = new Point(12, 460);
            rezervasyonlarGDV.MultiSelect = false;
            rezervasyonlarGDV.Name = "rezervasyonlarGDV";
            rezervasyonlarGDV.ReadOnly = true;
            rezervasyonlarGDV.RowHeadersWidth = 51;
            rezervasyonlarGDV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rezervasyonlarGDV.Size = new Size(719, 267);
            rezervasyonlarGDV.TabIndex = 1;
            rezervasyonlarGDV.CellClick += rezervasyonlarGDV_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 22);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 2;
            label1.Text = "Seferler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 437);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 3;
            label2.Text = "Rezervasyonlarım";
            // 
            // koltukCMB
            // 
            koltukCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            koltukCMB.FormattingEnabled = true;
            koltukCMB.Location = new Point(908, 45);
            koltukCMB.Name = "koltukCMB";
            koltukCMB.Size = new Size(58, 28);
            koltukCMB.TabIndex = 4;
            // 
            // rezerveEtBtn
            // 
            rezerveEtBtn.Enabled = false;
            rezerveEtBtn.Location = new Point(872, 79);
            rezerveEtBtn.Name = "rezerveEtBtn";
            rezerveEtBtn.Size = new Size(94, 29);
            rezerveEtBtn.TabIndex = 5;
            rezerveEtBtn.Text = "Rezerve Et";
            rezerveEtBtn.UseVisualStyleBackColor = true;
            rezerveEtBtn.Click += rezerveEtBtn_Click;
            // 
            // rezerveSilBtn
            // 
            rezerveSilBtn.Enabled = false;
            rezerveSilBtn.Location = new Point(872, 114);
            rezerveSilBtn.Name = "rezerveSilBtn";
            rezerveSilBtn.Size = new Size(94, 29);
            rezerveSilBtn.TabIndex = 6;
            rezerveSilBtn.Text = "Sil";
            rezerveSilBtn.UseVisualStyleBackColor = true;
            rezerveSilBtn.Click += rezerveSilBtn_Click;
            // 
            // rezervasyonGuncelleBtn
            // 
            rezervasyonGuncelleBtn.Enabled = false;
            rezervasyonGuncelleBtn.Location = new Point(872, 149);
            rezervasyonGuncelleBtn.Name = "rezervasyonGuncelleBtn";
            rezervasyonGuncelleBtn.Size = new Size(94, 29);
            rezervasyonGuncelleBtn.TabIndex = 7;
            rezervasyonGuncelleBtn.Text = "Güncelle";
            rezervasyonGuncelleBtn.UseVisualStyleBackColor = true;
            rezervasyonGuncelleBtn.Click += rezervasyonGuncelleBtn_Click;
            // 
            // MusteriPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 739);
            Controls.Add(rezervasyonGuncelleBtn);
            Controls.Add(rezerveSilBtn);
            Controls.Add(rezerveEtBtn);
            Controls.Add(koltukCMB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rezervasyonlarGDV);
            Controls.Add(seferlerDGV);
            Name = "MusteriPaneli";
            Text = "Hoşgeldiniz";
            Load += MusteriPencere_Load;
            ((System.ComponentModel.ISupportInitialize)seferlerDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)rezervasyonlarGDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView seferlerDGV;
        private DataGridView rezervasyonlarGDV;
        private Label label1;
        private Label label2;
        private ComboBox koltukCMB;
        private Button rezerveEtBtn;
        private Button rezerveSilBtn;
        private Button rezervasyonGuncelleBtn;
    }
}