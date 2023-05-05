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
    public partial class SıfreUnuttum2 : Form
    {
        public SıfreUnuttum2()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            int ıd = int.Parse(TxtKullanıcıAd.Text);
            var deger = db.TBLADMIN.Find(ıd);
            deger.SIFRA = TxtSıfre.Text;
            db.SaveChanges();
            MessageBox.Show("Şifreniz Başarıyla Degiştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginFormu kayit = new LoginFormu();
            this.Hide();
            kayit.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
