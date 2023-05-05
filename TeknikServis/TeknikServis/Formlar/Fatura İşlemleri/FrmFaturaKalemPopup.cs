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
    public partial class FrmFaturaKalemPopup : Form
    {
        public FrmFaturaKalemPopup()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        public int id;
        private void FrmFaturaKalemPopup_Load(object sender, EventArgs e)
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
                               CARI = u.TBLCARİ.AD + u.TBLCARİ.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD + u.TBLPERSONEL.SOYAD,
                           };
            gridControl2.DataSource = degerler.ToList();

            var degerler2 = from y in db.TBLFATURADETAY
                            select new
                            {
                                y.FATURADETAYID,
                                y.URUN,
                                y.ADET,
                                y.FİYAT,
                                y.TUTAR,
                           };
            gridControl1.DataSource = degerler2.ToList();

            //labelControl1.Text = id.ToString();

            gridControl1.DataSource = db.TBLFATURADETAY.Where(x => x.FATURAID == id).ToList();
            gridControl2.DataSource = db.TBLFATURABİLGİ.Where(x => x.ID == id).ToList();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.Pdf";
            gridControl1.ExportToPdf(path);
        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.Xls";
            gridControl1.ExportToXls(path);
        }
    }
}
