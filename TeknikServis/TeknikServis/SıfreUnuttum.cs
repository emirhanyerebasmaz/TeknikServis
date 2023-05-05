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
    public partial class SıfreUnuttum : Form
    {
        public SıfreUnuttum()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN where x.KULLANICIAD == TxtKullanıcAd.Text && x.AD == Txtİsim.Text && x.SOYAD == TxtSoyisim.Text && x.NUMARA == TxtNumara.Text select x;
            if (sorgu.Any())
            {
                SıfreUnuttum2 frm = new SıfreUnuttum2();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız Tekrar Deneyiniz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginFormu kayit = new LoginFormu();
            this.Hide();
            kayit.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdmınId kayit = new AdmınId();
            kayit.Show();
        }
    }
}
