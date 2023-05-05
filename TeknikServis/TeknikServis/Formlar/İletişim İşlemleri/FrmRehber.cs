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
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLCARİ
                                       select new
                                       {
                                           AD = x.AD + " " + x.SOYAD,
                                           x.TELEFON,
                                           x.MAİL,
                                       }).ToList();
        }
    }
}
