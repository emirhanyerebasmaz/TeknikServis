using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar.Arızalı_Ürün_İşlemleri
{
    public partial class FrmYeniArızalıÜrün : Form
    {
        public FrmYeniArızalıÜrün()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNKABUL t = new TBLURUNKABUL();
            t.CARİ = int.Parse(lookUpEdit1.EditValue.ToString());
            t.GELİŞTARİHİ = DateTime.Parse(TxtTarih.Text);
            t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
            t.URUNSERINO = TxtSeriNo.Text;
            t.URUNDURUMDETAY = "Ürün Kaydoldu";
            t.URUNDURUM = true;
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Yeni Arızalı Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            DialogResult vazgec = MessageBox.Show("Yeni Arızalı Ürün ekleme işleminden vazgeçmek istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vazgec == System.Windows.Forms.DialogResult.Yes)
            {

                this.Close();

            }
        }

        private void FrmYeniArızalıÜrün_Load(object sender, EventArgs e)
        {
            //Müşteri
            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARİ
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD,
                                                 }).ToList();

            //Personel
            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD,
                                                 }).ToList();
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
