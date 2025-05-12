namespace Emlak_Uygulaması
{
    partial class İlanEkle
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
            this.FormHareket = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.pTemelGorsel = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnIlanVer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RSatilikIlan = new System.Windows.Forms.RadioButton();
            this.RKiralikIlan = new System.Windows.Forms.RadioButton();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtAlan = new System.Windows.Forms.TextBox();
            this.txtBinaYasi = new System.Windows.Forms.TextBox();
            this.txtKatSayisi = new System.Windows.Forms.TextBox();
            this.txtAidat = new System.Windows.Forms.TextBox();
            this.txtIlaniVeren = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtKonum = new System.Windows.Forms.TextBox();
            this.mtxtTelNo = new System.Windows.Forms.MaskedTextBox();
            this.cmbIsitma = new System.Windows.Forms.ComboBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbBalkon = new System.Windows.Forms.ComboBox();
            this.FormHareket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pTemelGorsel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormHareket
            // 
            this.FormHareket.BackColor = System.Drawing.Color.Transparent;
            this.FormHareket.Controls.Add(this.button1);
            this.FormHareket.Controls.Add(this.btnMin);
            this.FormHareket.Controls.Add(this.button2);
            this.FormHareket.Controls.Add(this.btnExit);
            this.FormHareket.Location = new System.Drawing.Point(0, 0);
            this.FormHareket.Name = "FormHareket";
            this.FormHareket.Size = new System.Drawing.Size(509, 28);
            this.FormHareket.TabIndex = 9;
            this.FormHareket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormHareket_MouseDown);
            this.FormHareket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormHareket_MouseMove);
            this.FormHareket.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormHareket_MouseUp);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(14, 14);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMin
            // 
            this.btnMin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(39, 7);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(14, 14);
            this.btnMin.TabIndex = 8;
            this.btnMin.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(15, 14);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(13, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(15, 14);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResimEkle.FlatAppearance.BorderSize = 0;
            this.btnResimEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnResimEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(85)))));
            this.btnResimEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResimEkle.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResimEkle.Location = new System.Drawing.Point(417, 194);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(87, 27);
            this.btnResimEkle.TabIndex = 12;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            this.btnResimEkle.MouseEnter += new System.EventHandler(this.btnResimEkle_MouseEnter);
            this.btnResimEkle.MouseLeave += new System.EventHandler(this.btnResimEkle_MouseLeave);
            // 
            // pTemelGorsel
            // 
            this.pTemelGorsel.Location = new System.Drawing.Point(335, 67);
            this.pTemelGorsel.Name = "pTemelGorsel";
            this.pTemelGorsel.Size = new System.Drawing.Size(171, 121);
            this.pTemelGorsel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pTemelGorsel.TabIndex = 13;
            this.pTemelGorsel.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnIlanVer
            // 
            this.btnIlanVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(85)))));
            this.btnIlanVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIlanVer.FlatAppearance.BorderSize = 0;
            this.btnIlanVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnIlanVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(85)))));
            this.btnIlanVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIlanVer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlanVer.ForeColor = System.Drawing.Color.White;
            this.btnIlanVer.Location = new System.Drawing.Point(380, 494);
            this.btnIlanVer.Name = "btnIlanVer";
            this.btnIlanVer.Size = new System.Drawing.Size(116, 34);
            this.btnIlanVer.TabIndex = 14;
            this.btnIlanVer.Text = "İlan Ver";
            this.btnIlanVer.UseVisualStyleBackColor = false;
            this.btnIlanVer.Click += new System.EventHandler(this.btnIlanVer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.RSatilikIlan);
            this.groupBox1.Controls.Add(this.RKiralikIlan);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(336, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 69);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlan Türü";
            // 
            // RSatilikIlan
            // 
            this.RSatilikIlan.AutoSize = true;
            this.RSatilikIlan.Location = new System.Drawing.Point(88, 30);
            this.RSatilikIlan.Name = "RSatilikIlan";
            this.RSatilikIlan.Size = new System.Drawing.Size(56, 17);
            this.RSatilikIlan.TabIndex = 1;
            this.RSatilikIlan.TabStop = true;
            this.RSatilikIlan.Text = "Satılık";
            this.RSatilikIlan.UseVisualStyleBackColor = true;
            // 
            // RKiralikIlan
            // 
            this.RKiralikIlan.AutoSize = true;
            this.RKiralikIlan.Location = new System.Drawing.Point(16, 30);
            this.RKiralikIlan.Name = "RKiralikIlan";
            this.RKiralikIlan.Size = new System.Drawing.Size(57, 17);
            this.RKiralikIlan.TabIndex = 0;
            this.RKiralikIlan.TabStop = true;
            this.RKiralikIlan.Text = "Kiralık";
            this.RKiralikIlan.UseVisualStyleBackColor = true;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBaslik.Location = new System.Drawing.Point(157, 64);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(175, 24);
            this.txtBaslik.TabIndex = 18;
            // 
            // txtAlan
            // 
            this.txtAlan.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlan.Location = new System.Drawing.Point(157, 137);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(175, 24);
            this.txtAlan.TabIndex = 19;
            // 
            // txtBinaYasi
            // 
            this.txtBinaYasi.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBinaYasi.Location = new System.Drawing.Point(157, 174);
            this.txtBinaYasi.Name = "txtBinaYasi";
            this.txtBinaYasi.Size = new System.Drawing.Size(175, 24);
            this.txtBinaYasi.TabIndex = 20;
            // 
            // txtKatSayisi
            // 
            this.txtKatSayisi.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKatSayisi.Location = new System.Drawing.Point(157, 208);
            this.txtKatSayisi.Name = "txtKatSayisi";
            this.txtKatSayisi.Size = new System.Drawing.Size(175, 24);
            this.txtKatSayisi.TabIndex = 21;
            // 
            // txtAidat
            // 
            this.txtAidat.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAidat.Location = new System.Drawing.Point(157, 323);
            this.txtAidat.Name = "txtAidat";
            this.txtAidat.Size = new System.Drawing.Size(175, 24);
            this.txtAidat.TabIndex = 23;
            // 
            // txtIlaniVeren
            // 
            this.txtIlaniVeren.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIlaniVeren.Location = new System.Drawing.Point(157, 358);
            this.txtIlaniVeren.Name = "txtIlaniVeren";
            this.txtIlaniVeren.Size = new System.Drawing.Size(175, 24);
            this.txtIlaniVeren.TabIndex = 24;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(157, 432);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(175, 24);
            this.txtFiyat.TabIndex = 26;
            // 
            // txtKonum
            // 
            this.txtKonum.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKonum.Location = new System.Drawing.Point(157, 471);
            this.txtKonum.Name = "txtKonum";
            this.txtKonum.Size = new System.Drawing.Size(175, 24);
            this.txtKonum.TabIndex = 27;
            // 
            // mtxtTelNo
            // 
            this.mtxtTelNo.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtTelNo.Location = new System.Drawing.Point(157, 397);
            this.mtxtTelNo.Mask = "(999) 000-00-00";
            this.mtxtTelNo.Name = "mtxtTelNo";
            this.mtxtTelNo.Size = new System.Drawing.Size(175, 24);
            this.mtxtTelNo.TabIndex = 28;
            // 
            // cmbIsitma
            // 
            this.cmbIsitma.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIsitma.FormattingEnabled = true;
            this.cmbIsitma.Items.AddRange(new object[] {
            "Doğalgaz",
            "Soba"});
            this.cmbIsitma.Location = new System.Drawing.Point(157, 247);
            this.cmbIsitma.Name = "cmbIsitma";
            this.cmbIsitma.Size = new System.Drawing.Size(175, 23);
            this.cmbIsitma.TabIndex = 29;
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Location = new System.Drawing.Point(157, 99);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(175, 24);
            this.dtTarih.TabIndex = 30;
            // 
            // cmbBalkon
            // 
            this.cmbBalkon.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBalkon.FormattingEnabled = true;
            this.cmbBalkon.Items.AddRange(new object[] {
            "YOK",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbBalkon.Location = new System.Drawing.Point(157, 284);
            this.cmbBalkon.Name = "cmbBalkon";
            this.cmbBalkon.Size = new System.Drawing.Size(175, 23);
            this.cmbBalkon.TabIndex = 31;
            // 
            // İlanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Emlak_Uygulaması.Properties.Resources.Yeni_İlan1;
            this.ClientSize = new System.Drawing.Size(509, 540);
            this.Controls.Add(this.cmbBalkon);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.cmbIsitma);
            this.Controls.Add(this.mtxtTelNo);
            this.Controls.Add(this.txtKonum);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtIlaniVeren);
            this.Controls.Add(this.txtAidat);
            this.Controls.Add(this.txtKatSayisi);
            this.Controls.Add(this.txtBinaYasi);
            this.Controls.Add(this.txtAlan);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.btnIlanVer);
            this.Controls.Add(this.pTemelGorsel);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.FormHareket);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "İlanEkle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni İlan";
            this.FormHareket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pTemelGorsel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FormHareket;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.PictureBox pTemelGorsel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnIlanVer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RSatilikIlan;
        private System.Windows.Forms.RadioButton RKiralikIlan;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.TextBox txtAlan;
        private System.Windows.Forms.TextBox txtBinaYasi;
        private System.Windows.Forms.TextBox txtKatSayisi;
        private System.Windows.Forms.TextBox txtAidat;
        private System.Windows.Forms.TextBox txtIlaniVeren;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtKonum;
        private System.Windows.Forms.MaskedTextBox mtxtTelNo;
        private System.Windows.Forms.ComboBox cmbIsitma;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ComboBox cmbBalkon;
    }
}