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
    public partial class Ilanlar : Form
    {
        public Ilanlar()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dc = new DataClasses1DataContext();
        Satilik satilik = new Satilik();
        Kiralik kiralik = new Kiralik();
        Resimle rs = new Resimle();
        Ilan ilan = new Emlak_Uygulaması.Ilan();
        public string ilantürü;

        private void Ilanlar_Load(object sender, EventArgs e)
        {
            try
            {
                cmbFiltre.SelectedIndex = 0;
                ilantürü = cmbFiltre.Text;
                Baslangic();
            }
            catch { }
        }
        private void cmbFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Baslangic();
        }

        public void Baslangic()
        {
            if (cmbFiltre.SelectedIndex == 0)
            {
                pIlanlar.Controls.Clear();
                foreach (var tbli in dc.Kiraliks)
                {
                    Ilan ilan = new Ilan();
                    ilan.lblBaslik.Text = tbli.Ilan_Baslik;
                    ilan.lblKonum.Text = tbli.Ilan_Konum;
                    ilan.lblTarih.Text = tbli.Ilan_Tarih.ToString();
                    ilan.lblUcret.Text = tbli.Ucret + " ₺";
                    ilan.pIlanTemelG.Image = rs.ResimGetir(tbli.Ilan_Temel_G.ToArray());
                    ilan.btnDetaylar.Tag = tbli.E_Kayit;
                    ilan.btnDetaylar.Click += Kiralik_Click;
                    ilan.Dock = DockStyle.Top;
                    pIlanlar.Controls.Add(ilan);
                }
            }
            if (cmbFiltre.SelectedIndex == 1)
            {
                pIlanlar.Controls.Clear();
                foreach (var tbli in dc.Satiliks)
                {
                    Ilan ilan1 = new Ilan();
                    ilan1.lblBaslik.Text = tbli.Ilan_Baslik;
                    ilan1.lblKonum.Text = tbli.Ilan_Konum;
                    ilan1.lblTarih.Text = tbli.Ilan_Tarih.ToString();
                    ilan1.lblUcret.Text = tbli.Ucret + " ₺";
                    ilan1.pIlanTemelG.Image = rs.ResimGetir(tbli.Ilan_Temel_G.ToArray());
                    ilan1.btnDetaylar.Tag = tbli.E_Kayit;
                    ilan1.btnDetaylar.Click += Satilik_Click;
                    ilan1.Dock = DockStyle.Top;
                    pIlanlar.Controls.Add(ilan1);
                }
            }
        }

        private void Satilik_Click(object sender, EventArgs e)
        {
            if (cmbFiltre.SelectedIndex==1)
            {
                int indeks = Ilan.S_Ilan_No;
                var komut = dc.Satiliks.First(x => x.E_Kayit == indeks);
                lblIlanNo.Text = komut.E_Kayit.ToString();
                lblBaslik.Text = komut.Ilan_Baslik;
                lblIlanTarih.Text = komut.Ilan_Tarih.ToString();
                lblAlan.Text = komut.Alan;
                lblBinaYas.Text = komut.Bina_Yasi;
                lblKatSayisi.Text = komut.Kat_Sayisi;
                lblIsitma.Text = komut.Isitma;
                lblBalkon.Text = komut.Balkon;
                lblAidat.Text = komut.Aidat + " ₺";
                lblIlanıVeren.Text = komut.Ilani_Veren;
                lblTelNo.Text = komut.Ilani_Veren_Tel;
                if (truefalse != false)
                {
                    truefalse = false; //Sonra Textlerin visible özelliklerini false'a döndür.
                }
                Textler();
            }
            else
            {
                ilan.btnDetaylar.Click += Kiralik_Click;
            }
        } 
        private void Kiralik_Click(object sender, EventArgs e)
        {
            if (cmbFiltre.SelectedIndex==0)
            {
                int indeks = Ilan.S_Ilan_No;
                var komut = dc.Kiraliks.First(x => x.E_Kayit == indeks);
                lblIlanNo.Text = komut.E_Kayit.ToString();
                lblBaslik.Text = komut.Ilan_Baslik;
                lblIlanTarih.Text = komut.Ilan_Tarih.ToString();
                lblAlan.Text = komut.Alan;
                lblBinaYas.Text = komut.Bina_Yasi;
                lblKatSayisi.Text = komut.Kat_Sayisi;
                lblIsitma.Text = komut.Isitma;
                lblBalkon.Text = komut.Balkon;
                lblAidat.Text = komut.Aidat;
                lblIlanıVeren.Text = komut.Ilani_Veren;
                lblTelNo.Text = komut.Ilani_Veren_Tel;
                if (truefalse != false)
                {
                    truefalse = false; //Sonra Textlerin visible özelliklerini false'a döndür.
                }
                Textler();
            }
            else
            {
                ilan.btnDetaylar.Click += Satilik_Click;
            }
            
        }

        //Form Hareketleri ve Programı Kapatma-Alta Alma kodları.
        int move = 0;
        int mx;
        int my;
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

        private void FormHareket_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaEkran ana = new AnaEkran();
            ana.Show();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnYeniIlan_Click(object sender, EventArgs e)
        {
            İlanEkle ilanekle = new Emlak_Uygulaması.İlanEkle();
            ilanekle.ShowDialog();
        }

        private void btnIlanSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltre.SelectedIndex == 0)
                {
                    KiralikIlanSil();
                }
                if (cmbFiltre.SelectedIndex == 1)
                {
                    SatilikIlanSil();
                }
            }
            catch { }
        }

        public void SatilikIlanSil()
        {
            DialogResult soru = MessageBox.Show("Seçili satılık ilanı silmek istediğinize emin misiniz ?","Bilgi",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (soru == DialogResult.Yes)
            {
                int ilanno = int.Parse(lblIlanNo.Text);
                var komut = dc.Satiliks.Where(x => x.E_Kayit == ilanno);
                dc.Satiliks.DeleteAllOnSubmit(komut);
                dc.SubmitChanges();
                Baslangic();
            }
            
        }

        public void KiralikIlanSil()
        {
            DialogResult soru = MessageBox.Show("Seçili kiralık ilanı silmek istediğinize emin misiniz ?","Bilgi",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (soru == DialogResult.Yes)
            {
                int ilanno = int.Parse(lblIlanNo.Text);
                var komut = dc.Kiraliks.Where(x => x.E_Kayit == ilanno);
                dc.Kiraliks.DeleteAllOnSubmit(komut);
                dc.SubmitChanges();
                Baslangic();
            }
        }

        public bool truefalse = true;

        public void Textler()
        {
            txtGuncelleAidat.Visible = truefalse;
            txtGuncelleAlan.Visible = truefalse;
            txtGuncelleBalkon.Visible = truefalse;
            txtGuncelleBinaYasi.Visible = truefalse;
            txtGuncelleFiyat.Visible = truefalse;
            txtGuncelleIlaniVeren.Visible = truefalse;
            txtGuncelleIlaniVerenTel.Visible = truefalse;
            txtGuncelleKatSayisi.Visible = truefalse;
            txtGuncelleKonum.Visible = truefalse;
            dtGuncelleIlanTarih.Visible = truefalse;
            cmbGuncelleIsitma.Visible = truefalse;
            button1.Visible = truefalse;
            truefalse = true;
        }

        private void btnIlanGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbFiltre.SelectedIndex == 0)
            {
                int ilanno = int.Parse(lblIlanNo.Text);
                kiralik = dc.Kiraliks.First(x => x.E_Kayit == ilanno);
                dtGuncelleIlanTarih.Text = kiralik.Ilan_Tarih.ToString();
                txtGuncelleAlan.Text = kiralik.Alan;
                txtGuncelleBinaYasi.Text = kiralik.Bina_Yasi;
                txtGuncelleKatSayisi.Text = kiralik.Kat_Sayisi;
                cmbGuncelleIsitma.Text = kiralik.Isitma;
                txtGuncelleBalkon.Text = kiralik.Balkon;
                txtGuncelleAidat.Text = kiralik.Aidat;
                txtGuncelleIlaniVeren.Text = kiralik.Ilani_Veren;
                txtGuncelleIlaniVerenTel.Text = kiralik.Ilani_Veren_Tel;
                txtGuncelleFiyat.Text = kiralik.Ucret;
                txtGuncelleKonum.Text = kiralik.Ilan_Konum;
            }
            else if (cmbFiltre.SelectedIndex == 1)
            {
                int ilanno = int.Parse(lblIlanNo.Text);
                satilik = dc.Satiliks.First(x => x.E_Kayit == ilanno);
                dtGuncelleIlanTarih.Text = satilik.Ilan_Tarih.ToString();
                txtGuncelleAlan.Text = satilik.Alan;
                txtGuncelleBinaYasi.Text = satilik.Bina_Yasi;
                txtGuncelleKatSayisi.Text = satilik.Kat_Sayisi;
                cmbGuncelleIsitma.Text = satilik.Isitma;
                txtGuncelleBalkon.Text = satilik.Balkon;
                txtGuncelleAidat.Text = satilik.Aidat;
                txtGuncelleIlaniVeren.Text = satilik.Ilani_Veren;
                txtGuncelleIlaniVerenTel.Text = satilik.Ilani_Veren_Tel;
                txtGuncelleFiyat.Text = satilik.Ucret;
                txtGuncelleKonum.Text = satilik.Ilan_Konum;
            }
            Textler();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GuncelleIlan(); //Bilgileri Güncelle evvela.
            if (truefalse != false)
            {
                truefalse = false; //Sonra Textlerin visible özelliklerini false'a döndür.
            }
            Textler(); //Sonra textleri görünmez yap.
            Labeller(); //Sonra Labeller'ı güncel değerler ile güncelle;
        }

        public void Labeller()
        {
            if (cmbFiltre.SelectedIndex == 0)
            {
                int indeks = Ilan.S_Ilan_No;
                var komut = dc.Kiraliks.First(x => x.E_Kayit == indeks);
                lblIlanNo.Text = komut.E_Kayit.ToString();
                lblBaslik.Text = komut.Ilan_Baslik;
                lblIlanTarih.Text = komut.Ilan_Tarih.ToString();
                lblAlan.Text = komut.Alan;
                lblBinaYas.Text = komut.Bina_Yasi;
                lblKatSayisi.Text = komut.Kat_Sayisi;
                lblIsitma.Text = komut.Isitma;
                lblBalkon.Text = komut.Balkon;
                lblAidat.Text = komut.Aidat + " ₺";
                lblIlanıVeren.Text = komut.Ilani_Veren;
                lblTelNo.Text = komut.Ilani_Veren_Tel;
            }
            if (cmbFiltre.SelectedIndex == 1)
            {
                int indeks = Ilan.S_Ilan_No;
                var komut = dc.Satiliks.First(x => x.E_Kayit == indeks);
                lblIlanNo.Text = komut.E_Kayit.ToString();
                lblBaslik.Text = komut.Ilan_Baslik;
                lblIlanTarih.Text = komut.Ilan_Tarih.ToString();
                lblAlan.Text = komut.Alan;
                lblBinaYas.Text = komut.Bina_Yasi;
                lblKatSayisi.Text = komut.Kat_Sayisi;
                lblIsitma.Text = komut.Isitma;
                lblBalkon.Text = komut.Balkon;
                lblAidat.Text = komut.Aidat + " ₺";
                lblIlanıVeren.Text = komut.Ilani_Veren;
                lblTelNo.Text = komut.Ilani_Veren_Tel;
            }
        }

        public void GuncelleIlan()
        {
            if (cmbFiltre.SelectedIndex==0)
            {
                DialogResult s = MessageBox.Show("İlanı Güncellemek istediğinize emin misniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (s == DialogResult.Yes)
                {
                    int ilanno = int.Parse(lblIlanNo.Text);
                    kiralik = dc.Kiraliks.First(x => x.E_Kayit == ilanno);
                    kiralik.Ilan_Tarih = dtGuncelleIlanTarih.Value.ToShortDateString();
                    kiralik.Alan = txtGuncelleAlan.Text;
                    kiralik.Bina_Yasi = txtGuncelleBinaYasi.Text;
                    kiralik.Kat_Sayisi = txtGuncelleKatSayisi.Text;
                    kiralik.Isitma = cmbGuncelleIsitma.Text;
                    kiralik.Balkon = txtGuncelleBalkon.Text;
                    kiralik.Aidat = txtGuncelleAidat.Text;
                    kiralik.Ilani_Veren = txtGuncelleIlaniVeren.Text;
                    kiralik.Ilani_Veren_Tel = txtGuncelleIlaniVerenTel.Text;
                    kiralik.Ucret = txtGuncelleFiyat.Text;
                    kiralik.Ilan_Konum = txtGuncelleKonum.Text;
                    dc.SubmitChanges();
                    MessageBox.Show("Kiralık ilanı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (cmbFiltre.SelectedIndex==1)
            {
                DialogResult s = MessageBox.Show("İlanı Güncellemek istediğinize emin misniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (s == DialogResult.Yes)
                {
                    int ilanno = int.Parse(lblIlanNo.Text);
                    satilik = dc.Satiliks.First(x => x.E_Kayit == ilanno);
                    satilik.Ilan_Tarih = dtGuncelleIlanTarih.Value.ToShortDateString();
                    satilik.Alan = txtGuncelleAlan.Text;
                    satilik.Bina_Yasi = txtGuncelleBinaYasi.Text;
                    satilik.Kat_Sayisi = txtGuncelleKatSayisi.Text;
                    satilik.Isitma = cmbGuncelleIsitma.Text;
                    satilik.Balkon = txtGuncelleBalkon.Text;
                    satilik.Aidat = txtGuncelleAidat.Text;
                    satilik.Ilani_Veren = txtGuncelleIlaniVeren.Text;
                    satilik.Ilani_Veren_Tel = txtGuncelleIlaniVerenTel.Text;
                    satilik.Ucret = txtGuncelleFiyat.Text;
                    satilik.Ilan_Konum = txtGuncelleKonum.Text;
                    dc.SubmitChanges();
                    MessageBox.Show("Kiralık ilanı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Baslangic();
        }
    }
}
