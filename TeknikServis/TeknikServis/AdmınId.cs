using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class AdmınId : Form
    {
        public AdmınId()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void AdmınId_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLADMIN
                           select new
                           {
                               x.ID,
                               x.KULLANICIAD,
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
