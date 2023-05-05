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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int secilen;
        void metot1()
        {
            var degerler = from u in db.TBLCARİ
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.İL,
                               u.İLCE,
                           };
            gridControl1.DataSource = degerler.ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLİLLER
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir,
                                                 }).ToList();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLCARİ t = new TBLCARİ();
            if (TxtAd.Text.Length <= 32 && TxtSoyad.Text.Length <= 32 && TxtMail.Text.Length <= 50  && TxtBanka.Text.Length <= 50 && TxtVergiDairesi.Text.Length <= 70 && TxtVergiNo.Text.Length <= 50 && TxtAdres.Text.Length <= 250)
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
                MessageBox.Show("Cari Sisteme Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cari Kaydedilemedi !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            metot1();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("İL").ToString();
            lookUpEdit2.Text = gridView1.GetFocusedRowCellValue("İLCE").ToString();
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
                                                 }).Where(z=>z.sehir==secilen).ToList();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
        }
    }
}
