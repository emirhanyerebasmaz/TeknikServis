using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar.Araçlar
{
    public partial class FrmYeniNot : Form
    {
        public FrmYeniNot()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLAR t = new TBLNOTLAR();
            t.BASLIK = TxtBaşlık.Text;
            t.ICERIK = Txtİçerik.Text;
            t.DURUM = false;
            db.TBLNOTLAR.Add(t);
            db.SaveChanges();
            MessageBox.Show("Not Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            DialogResult vazgec = MessageBox.Show("Yeni Not Ekleme işleminden Vazgeçmek İstediğinize Emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vazgec == System.Windows.Forms.DialogResult.Yes)
            {

                this.Close();

            }
        }
    }
}
