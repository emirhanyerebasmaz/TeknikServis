using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmPersonelListesi : Form
    {
        public FrmPersonelListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLPERSONEL t = new TBLPERSONEL();


            if (TxtAd.Text.Length <= 30 && TxtSoyad.Text.Length <= 30)
            {
                t.AD = TxtAd.Text;
                t.SOYAD = TxtSoyad.Text;
                t.MAİL =TxtMail.Text;
                t.TELEFON =TxtTelefon.Text;
                //t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.TBLPERSONEL.Add(t);
                db.SaveChanges();
                MessageBox.Show("Personel Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Personel Kaydedilemedi !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmPersonelListesi_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAİL,
                               u.TELEFON,
                           };
            gridControl1.DataSource = degerler.ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD,
                                                 }).ToList();

            string ad1, soyad1, ad2, soyad2, ad3, soyad3, ad4, soyad4;
            //1.Personel Bilgileri
            ad1 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad1 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl2.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl8.Text = db.TBLPERSONEL.First(x => x.ID == 1).MAİL;
            labelControl7.Text = ad1 + " " + soyad1;

            //2.Personel Bilgileri
            ad2 = db.TBLPERSONEL.First(x => x.ID == 2).AD;
            soyad2 = db.TBLPERSONEL.First(x => x.ID == 2).SOYAD;
            labelControl6.Text = db.TBLPERSONEL.First(x => x.ID == 2).TBLDEPARTMAN.AD;
            labelControl5.Text = db.TBLPERSONEL.First(x => x.ID == 2).MAİL;
            labelControl9.Text = ad2 + " " + soyad2;

            //3.Personel Bilgileri
            ad3 = db.TBLPERSONEL.First(x => x.ID == 3).AD;
            soyad3 = db.TBLPERSONEL.First(x => x.ID == 3).SOYAD;
            labelControl3.Text = db.TBLPERSONEL.First(x => x.ID == 3).TBLDEPARTMAN.AD;
            labelControl1.Text = db.TBLPERSONEL.First(x => x.ID == 3).MAİL;
            labelControl4.Text = ad3 + " " + soyad3;

            //4.Personel Bilgileri
            ad4 = db.TBLPERSONEL.First(x => x.ID == 4).AD;
            soyad4 = db.TBLPERSONEL.First(x => x.ID == 4).SOYAD;
            labelControl17.Text = db.TBLPERSONEL.First(x => x.ID == 4).TBLDEPARTMAN.AD;
            labelControl16.Text = db.TBLPERSONEL.First(x => x.ID == 4).MAİL;
            labelControl18.Text = ad4 + " " + soyad4;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAİL,
                               u.TELEFON,
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLPERSONEL.Find(id);
            deger.AD = TxtAd.Text;
            deger.SOYAD = TxtSoyad.Text;
            deger.MAİL = TxtMail.Text;
            deger.TELEFON = TxtTelefon.Text;
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Güncelledi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLPERSONEL.Find(id);
            db.TBLPERSONEL.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            //lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("DEPARTMAN").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("MAİL").ToString();
            //TxtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            
        }
    }
}
