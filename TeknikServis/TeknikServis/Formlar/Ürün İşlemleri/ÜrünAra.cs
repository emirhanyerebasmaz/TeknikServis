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
    public partial class ÜrünAra : Form
    {
        public ÜrünAra()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (TxtId.Text != "")
            {
                int id = Convert.ToInt32(TxtId.Text);
                var degerler = (from u in db.TBLURUN
                                select new
                                {
                                    u.ID,
                                    u.AD,
                                    u.MARKA,
                                    KATEGORİ = u.TBLKATEGORİ.AD,
                                    u.STOK,
                                    u.ALISFIYAT,
                                    u.SATISFIYAT,
                                }).Where(x => x.ID == id);
                gridControl1.DataSource = degerler.ToList();
            }
        }
    }
}
