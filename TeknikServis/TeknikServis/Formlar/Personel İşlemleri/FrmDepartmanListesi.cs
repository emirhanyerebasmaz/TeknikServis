using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar.Personel_İşlemleri
{
    public partial class FrmDepartmanListesi : Form
    {
        public FrmDepartmanListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void FrmDepartmanListesi_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.AÇIKLAMA,
                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl2.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl3.Text = db.TBLPERSONEL.Count().ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN t = new TBLDEPARTMAN();

            if (TxtAd.Text.Length <= 50)
            {
                t.AD = TxtAd.Text;
                t.AÇIKLAMA = richTextBox1.Text;
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Departman Kaydedilemedi !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            db.TBLDEPARTMAN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.ID,
                               u.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            deger.AD = TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Güncelledi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }
    }
}
