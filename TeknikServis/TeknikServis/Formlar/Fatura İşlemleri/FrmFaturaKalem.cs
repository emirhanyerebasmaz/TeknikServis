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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURADETAY t = new TBLFATURADETAY();
            t.URUN = TxtUrun.Text;
            t.ADET = short.Parse(TxtAdet.Text);
            t.FİYAT = decimal.Parse(TxtFıyat.Text);
            t.TUTAR = short.Parse(TxtTutar.Text);
            t.FATURAID = int.Parse(TxtFaturaId.Text);
            db.TBLFATURADETAY.Add(t);
            db.SaveChanges();
            MessageBox.Show("Faturaya Ait Kalem Girişi Başarıyla Yapıldı");
        }

        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FİYAT,
                               u.TUTAR,
                               u.FATURAID,
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FİYAT,
                               u.TUTAR,
                               u.FATURAID,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
