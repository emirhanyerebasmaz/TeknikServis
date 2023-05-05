using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar.İletişim_İşlemleri
{
    public partial class FrmGelenMesajlar : Form
    {
        public FrmGelenMesajlar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmGelenMesajlar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLİLETİŞİM
                                       select new
                                       {
                                           x.ADSOYAD,
                                           x.MAIL,
                                           x.KONU,
                                           x.MESAJ,
                                       }).ToList();
        }
    }
}
