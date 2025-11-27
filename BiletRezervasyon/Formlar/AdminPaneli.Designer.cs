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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            cmbVaris = new ComboBox();
            cmbKalkis = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            cmbKabinM = new ComboBox();
            cmbPilot = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 7);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(607, 480);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(389, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(389, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbPilot);
            groupBox1.Controls.Add(cmbKabinM);
            groupBox1.Controls.Add(cmbVaris);
            groupBox1.Controls.Add(cmbKalkis);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(705, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(531, 475);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cmbVaris
            // 
            cmbVaris.FormattingEnabled = true;
            cmbVaris.Location = new Point(389, 125);
            cmbVaris.Name = "cmbVaris";
            cmbVaris.Size = new Size(125, 28);
            cmbVaris.TabIndex = 18;
            // 
            // cmbKalkis
            // 
            cmbKalkis.FormattingEnabled = true;
            cmbKalkis.Location = new Point(389, 91);
            cmbKalkis.Name = "cmbKalkis";
            cmbKalkis.Size = new Size(125, 28);
            cmbKalkis.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 125);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 16;
            label5.Text = "Varış";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(336, 94);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 15;
            label6.Text = "Kalkış";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(389, 225);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(125, 104);
            listBox1.TabIndex = 12;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 200);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 11;
            label4.Text = "Kabin Memurları";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 167);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 10;
            label3.Text = "Pilot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 59);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 9;
            label2.Text = "Uçak";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 33);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 8;
            label1.Text = "Uçuş No";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(221, 426);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "button1";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(121, 426);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 6;
            btnSil.Text = "button1";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(21, 426);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "button1";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // cmbKabinM
            // 
            cmbKabinM.FormattingEnabled = true;
            cmbKabinM.Location = new Point(389, 191);
            cmbKabinM.Name = "cmbKabinM";
            cmbKabinM.Size = new Size(125, 28);
            cmbKabinM.TabIndex = 19;
            // 
            // cmbPilot
            // 
            cmbPilot.FormattingEnabled = true;
            cmbPilot.Location = new Point(389, 159);
            cmbPilot.Name = "cmbPilot";
            cmbPilot.Size = new Size(125, 28);
            cmbPilot.TabIndex = 20;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Button btnSil;
        private Button btnEkle;
        private Button btnGuncelle;
        private Label label2;
        private Label label1;
        private ListBox listBox1;
        private Label label4;
        private Label label3;
        private ComboBox cmbVaris;
        private ComboBox cmbKalkis;
        private Label label5;
        private Label label6;
        private ComboBox cmbPilot;
        private ComboBox cmbKabinM;
    }
}