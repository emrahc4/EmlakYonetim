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
    public partial class IlanGuncelle : Form
    {
        public IlanGuncelle()
        {
            InitializeComponent();
        }
        Ilanlar ilanlar = new Ilanlar();
        DataClasses1DataContext dc = new DataClasses1DataContext();
        Kiralik kiralik = new Kiralik();
        Satilik satilik = new Satilik();
        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void KiralikIlaniDuzenle()
        {
            int ilanno = int.Parse(ilanlar.lblIlanNo.Text);
            kiralik = dc.Kiraliks.First(x => x.E_Kayit == ilanno);
            kiralik.Ilan_Baslik = txtBaslik.Text;
            kiralik.Ilan_Tarih = dtTarih.Value.ToShortDateString();
            kiralik.Alan = txtAlan.Text;
            kiralik.Bina_Yasi = txtBinaYasi.Text;
            kiralik.Kat_Sayisi = txtKatSayisi.Text;
            kiralik.Isitma = cmbIsitma.Text;
            kiralik.Balkon = txtBalkon.Text;
            kiralik.Aidat = txtAidat.Text;
            kiralik.Ilani_Veren = txtIlaniVeren.Text;
            kiralik.Ilani_Veren_Tel = mtxtTelNo.Text;
            kiralik.Ucret = txtFiyat.Text;
            kiralik.Ilan_Konum = txtKonum.Text;
            dc.SubmitChanges();
            MessageBox.Show("Kiralık ilanı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void SatilikIlaniDuzenle()
        {
            int ilanno = int.Parse(ilanlar.lblIlanNo.Text);
            satilik = dc.Satiliks.First(x => x.E_Kayit == ilanno);
            satilik.Ilan_Baslik = txtBaslik.Text;
            satilik.Ilan_Tarih = dtTarih.Value.ToShortDateString();
            satilik.Alan = txtAlan.Text;
            satilik.Bina_Yasi = txtBinaYasi.Text;
            satilik.Kat_Sayisi = txtKatSayisi.Text;
            satilik.Isitma = cmbIsitma.Text;
            satilik.Balkon = txtBalkon.Text;
            satilik.Aidat = txtAidat.Text;
            satilik.Ilani_Veren = txtIlaniVeren.Text;
            satilik.Ilani_Veren_Tel = mtxtTelNo.Text;
            satilik.Ucret = txtFiyat.Text;
            satilik.Ilan_Konum = txtKonum.Text;
            dc.SubmitChanges();
            MessageBox.Show("Kiralık ilanı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            btnIlanGuncelle.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnIlanGuncelle.ForeColor = Color.White;
        }

        
    }
}
