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
    public partial class ArızalıÜrünDetayListesi : Form
    {
        public ArızalıÜrünDetayListesi()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void ArızalıÜrünDetayListesi_Load(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            gridControl1.DataSource = (from x in db.TBLURUNTAKİP
                                      select new
                                      {
                                          x.TAKIPID,
                                          x.SERINO,
                                          x.TARIH,
                                          x.ACIKLAMA,
                                      }).ToList();

        }
    }
}
