using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar.Fatura_İşlemleri
{
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURABİLGİ
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAİRE,
                              CARI= u.TBLCARİ.AD +" "+ u.TBLCARİ.SOYAD,
                              PERSONEL=u.TBLPERSONEL.AD+" "+u.TBLPERSONEL.SOYAD,
                           };
            gridControl1.DataSource = degerler.ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARİ
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD +" "+ x.SOYAD,
                                                 }).ToList();

            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD,
                                                 }).ToList();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURABİLGİ
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAİRE,
                               CARI = u.TBLCARİ.AD +" "+ u.TBLCARİ.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD +" "+ u.TBLPERSONEL.SOYAD,
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURABİLGİ t = new TBLFATURABİLGİ();
            t.SERI = TxtSeriNo.Text;
            t.SIRANO = TxtSıraNo.Text;
            t.TARIH = Convert.ToDateTime(TxtTarih.Text);
            t.SAAT = TxtSaat.Text;
            t.VERGIDAİRE = TxtVergiDairesi.Text;
            t.CARİ = int.Parse(lookUpEdit1.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
            db.TBLFATURABİLGİ.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Sisteme Kaydedilmiştir Faturaya Kalem Girişi Yapabilirsiniz");
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtSeriNo.Text = gridView1.GetFocusedRowCellValue("SERI").ToString();
            TxtSıraNo.Text = gridView1.GetFocusedRowCellValue("SIRANO").ToString();
            TxtTarih.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
            TxtSaat.Text = gridView1.GetFocusedRowCellValue("SAAT").ToString();
            TxtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGIDAİRE").ToString();
        }
        public string id;
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopup fr = new FrmFaturaKalemPopup();
            fr.id =int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
