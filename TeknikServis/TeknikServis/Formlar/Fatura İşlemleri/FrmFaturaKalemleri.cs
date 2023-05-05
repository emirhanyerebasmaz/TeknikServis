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
    public partial class FrmFaturaKalemleri : Form
    {
        public FrmFaturaKalemleri()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (TxtId.Text != "")
            {
                int id = Convert.ToInt32(TxtId.Text);
                var degerler = (from u in db.TBLFATURADETAY
                                select new
                                {
                                    u.FATURADETAYID,
                                    u.URUN,
                                    u.ADET,
                                    u.FİYAT,
                                    u.TUTAR,
                                    u.FATURAID,
                                }).Where(x => x.FATURAID == id);
                gridControl1.DataSource = degerler.ToList();
            }
            var dg = (from u in db.TBLFATURADETAY.Where(x => x.TBLFATURABİLGİ.SERI == TxtSeriNo.Text | x.TBLFATURABİLGİ.SIRANO == TxtSıraNo.Text)
                      select new
                      {
                          u.URUN,
                          u.TBLFATURABİLGİ.SIRANO,
                          u.TBLFATURABİLGİ.SERI,
                          u.ADET,
                          u.FİYAT,
                          u.FATURAID,
                          CARI = u.TBLFATURABİLGİ.TBLCARİ.AD + " " + u.TBLFATURABİLGİ.TBLCARİ.SOYAD,
                      });
                      
        }
    }
}
