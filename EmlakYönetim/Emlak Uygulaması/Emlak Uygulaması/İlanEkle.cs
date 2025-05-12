using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak_Uygulaması
{
    public partial class İlanEkle : Form
    {
        public İlanEkle()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dc = new DataClasses1DataContext();
        Resimle rs = new Resimle();
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Aç";
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";
            string resimyolu;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pTemelGorsel.Image = Image.FromFile(openFileDialog1.FileName);
                resimyolu = openFileDialog1.FileName.ToString();
            }
        }

        private void btnIlanVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (RSatilikIlan.Checked==true)
                {
                    SatilikIlanVer();
                }
                if (RKiralikIlan.Checked==true)
                {
                    KiralikIlanVer();
                }
            }
            catch { }
        }

        public void SatilikIlanVer()
        {
            dc = new DataClasses1DataContext();
            Satilik ilanver = new Satilik();
            ilanver.Ilan_Baslik = txtBaslik.Text;
            ilanver.Ilan_Tarih = dtTarih.Value.ToShortDateString();
            ilanver.Alan = txtAlan.Text;
            ilanver.Bina_Yasi = txtBinaYasi.Text;
            ilanver.Ilan_Temel_G = rs.ResimYukle(pTemelGorsel.Image);
            ilanver.Kat_Sayisi = txtKatSayisi.Text;
            ilanver.Isitma = cmbIsitma.Text;
            ilanver.Balkon = cmbBalkon.Text;
            ilanver.Aidat = txtAidat.Text;
            ilanver.Ilan_Konum = txtKonum.Text;
            ilanver.Ucret = txtFiyat.Text;
            ilanver.Ilani_Veren = txtIlaniVeren.Text;
            ilanver.Ilani_Veren_Tel = mtxtTelNo.Text;
            dc.Satiliks.InsertOnSubmit(ilanver);
            dc.SubmitChanges();
            MessageBox.Show("İlan Başarıyla Verilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void KiralikIlanVer()
        {
            dc = new DataClasses1DataContext();
            Kiralik ilanver = new Kiralik();
            ilanver.Ilan_Baslik = txtBaslik.Text;
            ilanver.Ilan_Tarih = dtTarih.Value.ToShortDateString();
            ilanver.Alan = txtAlan.Text;
            ilanver.Bina_Yasi = txtBinaYasi.Text;
            ilanver.Ilan_Temel_G = rs.ResimYukle(pTemelGorsel.Image);
            ilanver.Kat_Sayisi = txtKatSayisi.Text;
            ilanver.Isitma = cmbIsitma.Text;
            ilanver.Balkon = cmbBalkon.Text;
            ilanver.Aidat = txtAidat.Text;
            ilanver.Ilan_Konum = txtKonum.Text;
            ilanver.Ucret = txtFiyat.Text;
            ilanver.Ilani_Veren = txtIlaniVeren.Text;
            ilanver.Ilani_Veren_Tel = mtxtTelNo.Text;
            dc.Kiraliks.InsertOnSubmit(ilanver);
            dc.SubmitChanges();
            MessageBox.Show("İlan Başarıyla Verilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormHareket_MouseMove(object sender, MouseEventArgs e)
        {
            if (move==1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void btnResimEkle_MouseEnter(object sender, EventArgs e)
        {
            btnResimEkle.ForeColor = Color.White;
        }

        private void btnResimEkle_MouseLeave(object sender, EventArgs e)
        {
            btnResimEkle.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int move = 0;
        int mx, my;
        private void FormHareket_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void FormHareket_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            mx = e.X;
            my = e.Y;
        }
    }
}
