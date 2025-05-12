namespace Emlak_Uygulaması
{
    partial class Ilanlar
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
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblIlanNo = new System.Windows.Forms.Label();
            this.lblIlanTarih = new System.Windows.Forms.Label();
            this.lblAlan = new System.Windows.Forms.Label();
            this.lblBinaYas = new System.Windows.Forms.Label();
            this.lblKatSayisi = new System.Windows.Forms.Label();
            this.lblIsitma = new System.Windows.Forms.Label();
            this.lblBalkon = new System.Windows.Forms.Label();
            this.lblAidat = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblIlanıVeren = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.pIlanlar = new System.Windows.Forms.Panel();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.btnYeniIlan = new System.Windows.Forms.Button();
            this.btnIlanSil = new System.Windows.Forms.Button();
            this.btnIlanGuncelle = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.txtGuncelleAlan = new System.Windows.Forms.TextBox();
            this.txtGuncelleBinaYasi = new System.Windows.Forms.TextBox();
            this.txtGuncelleKatSayisi = new System.Windows.Forms.TextBox();
            this.txtGuncelleBalkon = new System.Windows.Forms.TextBox();
            this.txtGuncelleAidat = new System.Windows.Forms.TextBox();
            this.dtGuncelleIlanTarih = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGuncelleIlaniVeren = new System.Windows.Forms.TextBox();
            this.txtGuncelleIlaniVerenTel = new System.Windows.Forms.MaskedTextBox();
            this.cmbGuncelleIsitma = new System.Windows.Forms.ComboBox();
            this.txtGuncelleFiyat = new System.Windows.Forms.TextBox();
            this.txtGuncelleKonum = new System.Windows.Forms.TextBox();
            this.FormHareket.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormHareket
            // 
            this.FormHareket.BackColor = System.Drawing.Color.Transparent;
            this.FormHareket.Controls.Add(this.btnMin);
            this.FormHareket.Controls.Add(this.btnExit);
            this.FormHareket.Location = new System.Drawing.Point(0, 0);
            this.FormHareket.Name = "FormHareket";
            this.FormHareket.Size = new System.Drawing.Size(1036, 28);
            this.FormHareket.TabIndex = 8;
            this.FormHareket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormHareket_MouseDown);
            this.FormHareket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormHareket_MouseMove);
            this.FormHareket.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormHareket_MouseUp);
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
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblIlanNo
            // 
            this.lblIlanNo.AutoSize = true;
            this.lblIlanNo.BackColor = System.Drawing.Color.White;
            this.lblIlanNo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlanNo.Location = new System.Drawing.Point(675, 108);
            this.lblIlanNo.Name = "lblIlanNo";
            this.lblIlanNo.Size = new System.Drawing.Size(0, 17);
            this.lblIlanNo.TabIndex = 9;
            // 
            // lblIlanTarih
            // 
            this.lblIlanTarih.AutoSize = true;
            this.lblIlanTarih.BackColor = System.Drawing.Color.White;
            this.lblIlanTarih.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlanTarih.Location = new System.Drawing.Point(675, 144);
            this.lblIlanTarih.Name = "lblIlanTarih";
            this.lblIlanTarih.Size = new System.Drawing.Size(0, 17);
            this.lblIlanTarih.TabIndex = 10;
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.BackColor = System.Drawing.Color.White;
            this.lblAlan.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlan.Location = new System.Drawing.Point(675, 181);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(0, 17);
            this.lblAlan.TabIndex = 11;
            // 
            // lblBinaYas
            // 
            this.lblBinaYas.AutoSize = true;
            this.lblBinaYas.BackColor = System.Drawing.Color.White;
            this.lblBinaYas.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBinaYas.Location = new System.Drawing.Point(675, 220);
            this.lblBinaYas.Name = "lblBinaYas";
            this.lblBinaYas.Size = new System.Drawing.Size(0, 17);
            this.lblBinaYas.TabIndex = 12;
            // 
            // lblKatSayisi
            // 
            this.lblKatSayisi.AutoSize = true;
            this.lblKatSayisi.BackColor = System.Drawing.Color.White;
            this.lblKatSayisi.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKatSayisi.Location = new System.Drawing.Point(675, 257);
            this.lblKatSayisi.Name = "lblKatSayisi";
            this.lblKatSayisi.Size = new System.Drawing.Size(0, 17);
            this.lblKatSayisi.TabIndex = 13;
            // 
            // lblIsitma
            // 
            this.lblIsitma.AutoSize = true;
            this.lblIsitma.BackColor = System.Drawing.Color.White;
            this.lblIsitma.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsitma.Location = new System.Drawing.Point(675, 294);
            this.lblIsitma.Name = "lblIsitma";
            this.lblIsitma.Size = new System.Drawing.Size(0, 17);
            this.lblIsitma.TabIndex = 14;
            // 
            // lblBalkon
            // 
            this.lblBalkon.AutoSize = true;
            this.lblBalkon.BackColor = System.Drawing.Color.White;
            this.lblBalkon.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBalkon.Location = new System.Drawing.Point(675, 332);
            this.lblBalkon.Name = "lblBalkon";
            this.lblBalkon.Size = new System.Drawing.Size(0, 17);
            this.lblBalkon.TabIndex = 15;
            // 
            // lblAidat
            // 
            this.lblAidat.AutoSize = true;
            this.lblAidat.BackColor = System.Drawing.Color.White;
            this.lblAidat.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAidat.Location = new System.Drawing.Point(675, 369);
            this.lblAidat.Name = "lblAidat";
            this.lblAidat.Size = new System.Drawing.Size(0, 17);
            this.lblAidat.TabIndex = 16;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.BackColor = System.Drawing.Color.White;
            this.lblAciklama.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(631, 401);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(0, 17);
            this.lblAciklama.TabIndex = 17;
            // 
            // lblIlanıVeren
            // 
            this.lblIlanıVeren.AutoSize = true;
            this.lblIlanıVeren.BackColor = System.Drawing.Color.Transparent;
            this.lblIlanıVeren.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlanıVeren.Location = new System.Drawing.Point(565, 463);
            this.lblIlanıVeren.Name = "lblIlanıVeren";
            this.lblIlanıVeren.Size = new System.Drawing.Size(0, 19);
            this.lblIlanıVeren.TabIndex = 18;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.BackColor = System.Drawing.Color.Transparent;
            this.lblTelNo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTelNo.Location = new System.Drawing.Point(565, 492);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(0, 15);
            this.lblTelNo.TabIndex = 19;
            // 
            // pIlanlar
            // 
            this.pIlanlar.AutoScroll = true;
            this.pIlanlar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pIlanlar.BackColor = System.Drawing.Color.White;
            this.pIlanlar.Location = new System.Drawing.Point(0, 82);
            this.pIlanlar.Name = "pIlanlar";
            this.pIlanlar.Size = new System.Drawing.Size(522, 455);
            this.pIlanlar.TabIndex = 20;
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltre.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFiltre.FormattingEnabled = true;
            this.cmbFiltre.Items.AddRange(new object[] {
            "Kiralık",
            "Satılık"});
            this.cmbFiltre.Location = new System.Drawing.Point(13, 44);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(121, 23);
            this.cmbFiltre.TabIndex = 21;
            this.cmbFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbFiltre_SelectedIndexChanged);
            // 
            // btnYeniIlan
            // 
            this.btnYeniIlan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYeniIlan.BackColor = System.Drawing.Color.Transparent;
            this.btnYeniIlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeniIlan.FlatAppearance.BorderSize = 0;
            this.btnYeniIlan.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnYeniIlan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnYeniIlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnYeniIlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniIlan.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniIlan.Location = new System.Drawing.Point(432, 44);
            this.btnYeniIlan.Name = "btnYeniIlan";
            this.btnYeniIlan.Size = new System.Drawing.Size(84, 23);
            this.btnYeniIlan.TabIndex = 9;
            this.btnYeniIlan.UseVisualStyleBackColor = false;
            this.btnYeniIlan.Click += new System.EventHandler(this.btnYeniIlan_Click);
            // 
            // btnIlanSil
            // 
            this.btnIlanSil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIlanSil.BackColor = System.Drawing.Color.Transparent;
            this.btnIlanSil.BackgroundImage = global::Emlak_Uygulaması.Properties.Resources.İlanSilbtn;
            this.btnIlanSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIlanSil.FlatAppearance.BorderSize = 0;
            this.btnIlanSil.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnIlanSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIlanSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIlanSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIlanSil.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIlanSil.Location = new System.Drawing.Point(987, 82);
            this.btnIlanSil.Name = "btnIlanSil";
            this.btnIlanSil.Size = new System.Drawing.Size(35, 23);
            this.btnIlanSil.TabIndex = 22;
            this.btnIlanSil.UseVisualStyleBackColor = false;
            this.btnIlanSil.Click += new System.EventHandler(this.btnIlanSil_Click);
            // 
            // btnIlanGuncelle
            // 
            this.btnIlanGuncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIlanGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnIlanGuncelle.BackgroundImage = global::Emlak_Uygulaması.Properties.Resources.İlanDüzenlebtn;
            this.btnIlanGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIlanGuncelle.FlatAppearance.BorderSize = 0;
            this.btnIlanGuncelle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnIlanGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIlanGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIlanGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIlanGuncelle.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIlanGuncelle.Location = new System.Drawing.Point(946, 82);
            this.btnIlanGuncelle.Name = "btnIlanGuncelle";
            this.btnIlanGuncelle.Size = new System.Drawing.Size(35, 23);
            this.btnIlanGuncelle.TabIndex = 23;
            this.btnIlanGuncelle.UseVisualStyleBackColor = false;
            this.btnIlanGuncelle.Click += new System.EventHandler(this.btnIlanGuncelle_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.Color.White;
            this.lblBaslik.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(550, 81);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(0, 20);
            this.lblBaslik.TabIndex = 24;
            // 
            // txtGuncelleAlan
            // 
            this.txtGuncelleAlan.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuncelleAlan.Location = new System.Drawing.Point(754, 181);
            this.txtGuncelleAlan.Name = "txtGuncelleAlan";
            this.txtGuncelleAlan.Size = new System.Drawing.Size(137, 23);
            this.txtGuncelleAlan.TabIndex = 26;
            this.txtGuncelleAlan.Visible = false;
            // 
            // txtGuncelleBinaYasi
            // 
            this.txtGuncelleBinaYasi.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuncelleBinaYasi.Location = new System.Drawing.Point(754, 220);
            this.txtGuncelleBinaYasi.Name = "txtGuncelleBinaYasi";
            this.txtGuncelleBinaYasi.Size = new System.Drawing.Size(137, 23);
            this.txtGuncelleBinaYasi.TabIndex = 27;
            this.txtGuncelleBinaYasi.Visible = false;
            // 
            // txtGuncelleKatSayisi
            // 
            this.txtGuncelleKatSayisi.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuncelleKatSayisi.Location = new System.Drawing.Point(754, 257);
            this.txtGuncelleKatSayisi.Name = "txtGuncelleKatSayisi";
            this.txtGuncelleKatSayisi.Size = new System.Drawing.Size(137, 23);
            this.txtGuncelleKatSayisi.TabIndex = 28;
            this.txtGuncelleKatSayisi.Visible = false;
            // 
            // txtGuncelleBalkon
            // 
            this.txtGuncelleBalkon.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuncelleBalkon.Location = new System.Drawing.Point(754, 332);
            this.txtGuncelleBalkon.Name = "txtGuncelleBalkon";
            this.txtGuncelleBalkon.Size = new System.Drawing.Size(137, 23);
            this.txtGuncelleBalkon.TabIndex = 30;
            this.txtGuncelleBalkon.Visible = false;
            // 
            // txtGuncelleAidat
            // 
            this.txtGuncelleAidat.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuncelleAidat.Location = new System.Drawing.Point(754, 369);
            this.txtGuncelleAidat.Name = "txtGuncelleAidat";
            this.txtGuncelleAidat.Size = new System.Drawing.Size(137, 23);
            this.txtGuncelleAidat.TabIndex = 31;
            this.txtGuncelleAidat.Visible = false;
            // 
            // dtGuncelleIlanTarih
            // 
            this.dtGuncelleIlanTarih.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGuncelleIlanTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtGuncelleIlanTarih.Location = new System.Drawing.Point(754, 143);
            this.dtGuncelleIlanTarih.Name = "dtGuncelleIlanTarih";
            this.dtGuncelleIlanTarih.Size = new System.Drawing.Size(137, 23);
            this.dtGuncelleIlanTarih.TabIndex = 32;
            this.dtGuncelleIlanTarih.Visible = false;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(85)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(935, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGuncelleIlaniVeren
            // 
            this.txtGuncelleIlaniVeren.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuncelleIlaniVeren.Location = new System.Drawing.Point(876, 464);
            this.txtGuncelleIlaniVeren.Name = "txtGuncelleIlaniVeren";
            this.txtGuncelleIlaniVeren.Size = new System.Drawing.Size(137, 23);
            this.txtGuncelleIlaniVeren.TabIndex = 34;
            this.txtGuncelleIlaniVeren.Visible = false;
            // 
            // txtGuncelleIlaniVerenTel
            // 
            this.txtGuncelleIlaniVerenTel.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuncelleIlaniVerenTel.Location = new System.Drawing.Point(876, 495);
            this.txtGuncelleIlaniVerenTel.Mask = "(999) 000-00-00";
            this.txtGuncelleIlaniVerenTel.Name = "txtGuncelleIlaniVerenTel";
            this.txtGuncelleIlaniVerenTel.Size = new System.Drawing.Size(137, 23);
            this.txtGuncelleIlaniVerenTel.TabIndex = 36;
            this.txtGuncelleIlaniVerenTel.Visible = false;
            // 
            // cmbGuncelleIsitma
            // 
            this.cmbGuncelleIsitma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGuncelleIsitma.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGuncelleIsitma.FormattingEnabled = true;
            this.cmbGuncelleIsitma.Items.AddRange(new object[] {
            "Doğalgaz",
            "Soba"});
            this.cmbGuncelleIsitma.Location = new System.Drawing.Point(754, 293);
            this.cmbGuncelleIsitma.Name = "cmbGuncelleIsitma";
            this.cmbGuncelleIsitma.Size = new System.Drawing.Size(137, 24);
            this.cmbGuncelleIsitma.TabIndex = 37;
            this.cmbGuncelleIsitma.Visible = false;
            // 
            // txtGuncelleFiyat
            // 
            this.txtGuncelleFiyat.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuncelleFiyat.Location = new System.Drawing.Point(896, 369);
            this.txtGuncelleFiyat.Name = "txtGuncelleFiyat";
            this.txtGuncelleFiyat.Size = new System.Drawing.Size(137, 23);
            this.txtGuncelleFiyat.TabIndex = 38;
            this.txtGuncelleFiyat.Visible = false;
            // 
            // txtGuncelleKonum
            // 
            this.txtGuncelleKonum.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuncelleKonum.Location = new System.Drawing.Point(896, 332);
            this.txtGuncelleKonum.Name = "txtGuncelleKonum";
            this.txtGuncelleKonum.Size = new System.Drawing.Size(137, 23);
            this.txtGuncelleKonum.TabIndex = 39;
            this.txtGuncelleKonum.Visible = false;
            // 
            // Ilanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Emlak_Uygulaması.Properties.Resources.İlanlar1;
            this.ClientSize = new System.Drawing.Size(1034, 537);
            this.Controls.Add(this.txtGuncelleKonum);
            this.Controls.Add(this.txtGuncelleFiyat);
            this.Controls.Add(this.cmbGuncelleIsitma);
            this.Controls.Add(this.txtGuncelleIlaniVerenTel);
            this.Controls.Add(this.txtGuncelleIlaniVeren);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtGuncelleIlanTarih);
            this.Controls.Add(this.txtGuncelleAidat);
            this.Controls.Add(this.txtGuncelleBalkon);
            this.Controls.Add(this.txtGuncelleKatSayisi);
            this.Controls.Add(this.txtGuncelleBinaYasi);
            this.Controls.Add(this.txtGuncelleAlan);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnIlanGuncelle);
            this.Controls.Add(this.btnIlanSil);
            this.Controls.Add(this.btnYeniIlan);
            this.Controls.Add(this.cmbFiltre);
            this.Controls.Add(this.pIlanlar);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblIlanıVeren);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblAidat);
            this.Controls.Add(this.lblBalkon);
            this.Controls.Add(this.lblIsitma);
            this.Controls.Add(this.lblKatSayisi);
            this.Controls.Add(this.lblBinaYas);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.lblIlanTarih);
            this.Controls.Add(this.lblIlanNo);
            this.Controls.Add(this.FormHareket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ilanlar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sokan Emlak";
            this.Load += new System.EventHandler(this.Ilanlar_Load);
            this.FormHareket.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FormHareket;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblIlanTarih;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.Label lblBinaYas;
        private System.Windows.Forms.Label lblKatSayisi;
        private System.Windows.Forms.Label lblIsitma;
        private System.Windows.Forms.Label lblBalkon;
        private System.Windows.Forms.Label lblAidat;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblIlanıVeren;
        private System.Windows.Forms.Label lblTelNo;
        public System.Windows.Forms.ComboBox cmbFiltre;
        public System.Windows.Forms.Panel pIlanlar;
        private System.Windows.Forms.Button btnYeniIlan;
        private System.Windows.Forms.Button btnIlanSil;
        private System.Windows.Forms.Button btnIlanGuncelle;
        private System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.Label lblIlanNo;
        private System.Windows.Forms.TextBox txtGuncelleAlan;
        private System.Windows.Forms.TextBox txtGuncelleBinaYasi;
        private System.Windows.Forms.TextBox txtGuncelleKatSayisi;
        private System.Windows.Forms.TextBox txtGuncelleBalkon;
        private System.Windows.Forms.TextBox txtGuncelleAidat;
        private System.Windows.Forms.DateTimePicker dtGuncelleIlanTarih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGuncelleIlaniVeren;
        private System.Windows.Forms.MaskedTextBox txtGuncelleIlaniVerenTel;
        private System.Windows.Forms.ComboBox cmbGuncelleIsitma;
        private System.Windows.Forms.TextBox txtGuncelleFiyat;
        private System.Windows.Forms.TextBox txtGuncelleKonum;
    }
}