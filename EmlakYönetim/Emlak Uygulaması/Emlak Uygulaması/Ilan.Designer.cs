namespace Emlak_Uygulaması
{
    partial class Ilan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblKonum = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.btnDetaylar = new System.Windows.Forms.Button();
            this.pIlanTemelG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pIlanTemelG)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(149, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(54, 16);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "BAŞLIK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(149, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "İlan Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(149, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Konum :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(373, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fiyat :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(85)))));
            this.panel1.Location = new System.Drawing.Point(7, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 3);
            this.panel1.TabIndex = 6;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTarih.Location = new System.Drawing.Point(220, 37);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(14, 15);
            this.lblTarih.TabIndex = 7;
            this.lblTarih.Text = "0";
            // 
            // lblKonum
            // 
            this.lblKonum.AutoSize = true;
            this.lblKonum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKonum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblKonum.Location = new System.Drawing.Point(203, 66);
            this.lblKonum.Name = "lblKonum";
            this.lblKonum.Size = new System.Drawing.Size(46, 15);
            this.lblKonum.TabIndex = 8;
            this.lblKonum.Text = "Konum";
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUcret.Location = new System.Drawing.Point(418, 37);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(14, 15);
            this.lblUcret.TabIndex = 9;
            this.lblUcret.Text = "0";
            // 
            // btnDetaylar
            // 
            this.btnDetaylar.BackgroundImage = global::Emlak_Uygulaması.Properties.Resources.DetaylarBtn1;
            this.btnDetaylar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetaylar.FlatAppearance.BorderSize = 0;
            this.btnDetaylar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDetaylar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDetaylar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetaylar.Location = new System.Drawing.Point(373, 74);
            this.btnDetaylar.Name = "btnDetaylar";
            this.btnDetaylar.Size = new System.Drawing.Size(128, 25);
            this.btnDetaylar.TabIndex = 5;
            this.btnDetaylar.UseVisualStyleBackColor = true;
            this.btnDetaylar.Click += new System.EventHandler(this.btnDetaylar_Click);
            // 
            // pIlanTemelG
            // 
            this.pIlanTemelG.Location = new System.Drawing.Point(3, 3);
            this.pIlanTemelG.Name = "pIlanTemelG";
            this.pIlanTemelG.Size = new System.Drawing.Size(144, 96);
            this.pIlanTemelG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pIlanTemelG.TabIndex = 0;
            this.pIlanTemelG.TabStop = false;
            // 
            // Ilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.lblKonum);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDetaylar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pIlanTemelG);
            this.Controls.Add(this.lblBaslik);
            this.Name = "Ilan";
            this.Size = new System.Drawing.Size(514, 114);
            ((System.ComponentModel.ISupportInitialize)(this.pIlanTemelG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblTarih;
        public System.Windows.Forms.Label lblKonum;
        public System.Windows.Forms.Label lblUcret;
        public System.Windows.Forms.Button btnDetaylar;
        public System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.PictureBox pIlanTemelG;
    }
}
