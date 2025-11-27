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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
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
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
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
            // textBox2
            // 
            textBox2.Location = new Point(389, 26);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dateTimePicker1);
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
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(705, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(531, 475);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(389, 189);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(125, 27);
            dateTimePicker2.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(298, 189);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 29;
            label10.Text = "Kalkış Günü";
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
            // dateTimePicker1
            // 
            dateTimePicker1.Cursor = Cursors.IBeam;
            dateTimePicker1.CustomFormat = "dd.mm.yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(389, 156);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 27;
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
            // ucakKapasiteTB
            // 
            ucakKapasiteTB.Location = new Point(389, 123);
            ucakKapasiteTB.Name = "ucakKapasiteTB";
            ucakKapasiteTB.ReadOnly = true;
            ucakKapasiteTB.Size = new Size(125, 27);
            ucakKapasiteTB.TabIndex = 25;
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
            // ucakModelTB
            // 
            ucakModelTB.Location = new Point(389, 90);
            ucakModelTB.Name = "ucakModelTB";
            ucakModelTB.ReadOnly = true;
            ucakModelTB.Size = new Size(125, 27);
            ucakModelTB.TabIndex = 23;
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
            // cmbUcak
            // 
            cmbUcak.FormattingEnabled = true;
            cmbUcak.Location = new Point(388, 56);
            cmbUcak.Name = "cmbUcak";
            cmbUcak.Size = new Size(126, 28);
            cmbUcak.TabIndex = 21;
            cmbUcak.SelectedIndexChanged += cmbUcak_SelectedIndexChanged;
            // 
            // cmbPilot
            // 
            cmbPilot.FormattingEnabled = true;
            cmbPilot.Location = new Point(388, 283);
            cmbPilot.Name = "cmbPilot";
            cmbPilot.Size = new Size(125, 28);
            cmbPilot.TabIndex = 20;
            // 
            // cmbKabinM
            // 
            cmbKabinM.FormattingEnabled = true;
            cmbKabinM.Items.AddRange(new object[] { "asd asd asd" });
            cmbKabinM.Location = new Point(389, 317);
            cmbKabinM.Name = "cmbKabinM";
            cmbKabinM.Size = new Size(89, 28);
            cmbKabinM.TabIndex = 19;
            // 
            // cmbVaris
            // 
            cmbVaris.FormattingEnabled = true;
            cmbVaris.Location = new Point(388, 249);
            cmbVaris.Name = "cmbVaris";
            cmbVaris.Size = new Size(125, 28);
            cmbVaris.TabIndex = 18;
            // 
            // cmbKalkis
            // 
            cmbKalkis.FormattingEnabled = true;
            cmbKalkis.Location = new Point(389, 215);
            cmbKalkis.Name = "cmbKalkis";
            cmbKalkis.Size = new Size(125, 28);
            cmbKalkis.TabIndex = 17;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(338, 218);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 15;
            label6.Text = "Kalkış";
            // 
            // kabinMLB
            // 
            kabinMLB.FormattingEnabled = true;
            kabinMLB.Location = new Point(388, 351);
            kabinMLB.Name = "kabinMLB";
            kabinMLB.Size = new Size(125, 104);
            kabinMLB.TabIndex = 12;
            kabinMLB.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 317);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 11;
            label4.Text = "Kabin Memurları";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 59);
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
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Button btnSil;
        private Button btnEkle;
        private Button btnGuncelle;
        private Label label2;
        private Label label1;
        private ListBox kabinMLB;
        private Label label4;
        private Label label3;
        private ComboBox cmbVaris;
        private ComboBox cmbKalkis;
        private Label label5;
        private Label label6;
        private ComboBox cmbPilot;
        private ComboBox cmbKabinM;
        private ComboBox cmbUcak;
        private Button kabinMEkle;
        private Label label8;
        private TextBox ucakKapasiteTB;
        private Label label7;
        private TextBox ucakModelTB;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private System.Windows.Forms.Timer timer1;
        private DateTimePicker dateTimePicker2;
    }
}