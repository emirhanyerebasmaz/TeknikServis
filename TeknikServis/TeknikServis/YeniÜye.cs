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
    public partial class YeniÜye : Form
    {
        public YeniÜye()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            TBLADMIN t = new TBLADMIN();

            t.KULLANICIAD = TxtKullanıcAd.Text;
            t.AD = Txtİsim.Text;
            t.SOYAD = TxtSoyisim.Text;
            t.NUMARA = TxtNumara.Text;
            t.SIFRA = TxtSıfre.Text;
            db.TBLADMIN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Yeni Kullanıcı Sisteme Başarıyla Kayıt Oldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            LoginFormu kayit = new LoginFormu();
            this.Hide();
            kayit.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
