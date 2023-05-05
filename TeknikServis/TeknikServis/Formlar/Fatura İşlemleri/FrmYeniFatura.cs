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
    public partial class FrmYeniFatura : Form
    {
        public FrmYeniFatura()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
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

        private void FrmYeniFatura_Load(object sender, EventArgs e)
        {

            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARİ
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD,
                                                 }).ToList();

            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD,
                                                 }).ToList();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            DialogResult vazgec = MessageBox.Show("Yeni Fatura Ekleme İşleminden Vazgeçmek İstediğinize Emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vazgec == System.Windows.Forms.DialogResult.Yes)

            {

                this.Close();

            }
        }
    }
}
