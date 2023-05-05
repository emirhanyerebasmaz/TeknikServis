using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar.Ürün_İşlemleri
{
    public partial class FrmÜrünListesi : Form
    {
        public FrmÜrünListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void metot1()
        {
            var degerler = from u in db.TBLURUN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               KATEGORİ = u.TBLKATEGORİ.AD,
                               u.STOK,
                               u.ALISFIYAT,
                               u.SATISFIYAT,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
                TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                TxtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
                TxtAlışFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
                TxtSatışFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
                TxtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
                //lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("KATEGORI").ToString();
        }

        private void FrmÜrünListesi_Load(object sender, EventArgs e)
        {
            metot1();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORİ
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD,
                                                 }).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();


            if (TxtAd.Text.Length <= 30 && TxtMarka.Text.Length <= 30 && TxtStok.Text.Length <= 5)
            {
                t.AD = TxtAd.Text;
                t.MARKA = TxtMarka.Text;
                //t.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
                t.KATEGORI = byte.Parse(lookUpEdit1.Text);
                t.ALISFIYAT = decimal.Parse(TxtAlışFiyat.Text);
                t.SATISFIYAT = decimal.Parse(TxtSatışFiyat.Text);
                t.STOK = short.Parse(TxtStok.Text);
                t.DURUM = false;
                db.TBLURUN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ürün Kaydedilemedi !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLURUN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               KATEGORİ = u.TBLKATEGORİ.AD,
                               u.STOK,
                               u.ALISFIYAT,
                               u.SATISFIYAT,
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLURUN.Find(id);
            deger.AD = TxtAd.Text;
            deger.STOK = short.Parse(TxtStok.Text);
            deger.MARKA = TxtMarka.Text;
            deger.ALISFIYAT = decimal.Parse(TxtAlışFiyat.Text);
            deger.SATISFIYAT = decimal.Parse(TxtSatışFiyat.Text);
            deger.KATEGORI = byte.Parse(lookUpEdit1.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncelledi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Text = "";
            TxtId.Text = "";
            TxtMarka.Text = "";
            TxtAlışFiyat.Text = "";
            TxtSatışFiyat.Text = "";
            TxtStok.Text = "";
        }
    }
}
