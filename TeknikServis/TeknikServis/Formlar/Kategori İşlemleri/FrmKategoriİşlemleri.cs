using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar.Kategori_İşlemleri
{
    public partial class FrmKategoriİşlemleri : Form
    {
        public FrmKategoriİşlemleri()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLKATEGORİ k = new TBLKATEGORİ();

            if (TxtAd.Text.Length <= 50 && TxtAd.Text != "") 
            {
                k.AD = TxtAd.Text;
                db.TBLKATEGORİ.Add(k);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez ve Kategori Adı 30 Karakterden Uzun Olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmKategoriİşlemleri_Load(object sender, EventArgs e)
        {
            var degerler = from k in db.TBLKATEGORİ
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLKATEGORİ.Find(id);
            deger.AD = TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Güncelledi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from k in db.TBLKATEGORİ
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLKATEGORİ.Find(id);
            db.TBLKATEGORİ.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Text = "";
            TxtId.Text = "";
        }
    }
}
