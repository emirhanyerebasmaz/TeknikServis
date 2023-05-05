using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar.Cari_İşlemleri
{
    public partial class FrmYeniCari : Form
    {
        public FrmYeniCari()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int secilen;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLCARİ t = new TBLCARİ();
            if (TxtAd.Text.Length <= 32 && TxtSoyad.Text.Length <= 32 && TxtMail.Text.Length <= 50 && TxtBanka.Text.Length <= 50 && TxtVergiDairesi.Text.Length <= 70 && TxtVergiNo.Text.Length <= 50 && TxtAdres.Text.Length <= 250)
            {
                t.AD = TxtAd.Text;
                t.SOYAD = TxtSoyad.Text;
                t.TELEFON = TxtTelefon.Text;
                t.MAİL = TxtMail.Text;
                t.İL = lookUpEdit1.Text;
                t.İLCE = lookUpEdit2.Text;
                t.BANKA = TxtBanka.Text;
                t.VERGİDAİRESİ = TxtVergiDairesi.Text;
                t.VERGINO = TxtVergiNo.Text;
                t.STATU = TxtStatu.Text;
                t.ADRES = TxtAdres.Text;
                db.TBLCARİ.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni Cari Sisteme Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cari Kaydedilemedi !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            DialogResult vazgec = MessageBox.Show("Yeni Cari Ekleme İşleminden Vazgeçmek İstediğinize Emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vazgec == System.Windows.Forms.DialogResult.Yes)

            {

                this.Close();

            }
        }

        private void FrmYeniCari_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLİLLER
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir,
                                                 }).ToList();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEdit1.EditValue.ToString());
            lookUpEdit2.Properties.DataSource = (from y in db.TBLİLCELER
                                                 select new
                                                 {
                                                     y.id,
                                                     y.ilce,
                                                     y.sehir,
                                                 }).Where(z => z.sehir == secilen).ToList();
        }
    }
}
