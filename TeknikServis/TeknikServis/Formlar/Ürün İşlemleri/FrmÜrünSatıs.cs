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
    public partial class FrmÜrünSatıs : Form
    {
        public FrmÜrünSatıs()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNHAREKET t = new TBLURUNHAREKET();
            t.URUN =int.Parse( lookUpEdit2.EditValue.ToString());
            t.MUSTERI =int.Parse(lookUpEdit3.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpEdit4.EditValue.ToString());
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            t.ADET = short.Parse(TxtAdet.Text);
            t.FİYAT = decimal.Parse(txtSatısfiyat.Text);
            t.URUNSERINO = TxtSeriNo.Text;
            db.TBLURUNHAREKET.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            DialogResult vazgec = MessageBox.Show("Ürün Satış İşleminden vazgeçmek istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vazgec == System.Windows.Forms.DialogResult.Yes)

            {

                this.Close();

            }
        }

        private void FrmÜrünSatıs_Load(object sender, EventArgs e)
        {
            lookUpEdit2.Properties.DataSource = (from x in db.TBLURUN
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD,
                                                 }).ToList();
            lookUpEdit3.Properties.DataSource = (from y in db.TBLCARİ
                                                 select new
                                                 {
                                                     y.ID,
                                                     AD = y.AD + " " + y.SOYAD,
                                                 }).ToList();
            lookUpEdit4.Properties.DataSource = (from J in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     J.ID,
                                                     AD = J.AD + " " + J.SOYAD,
                                                 }).ToList();
        }
    }
}
