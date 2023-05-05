using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar.Kategori_İşlemleri
{
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLKATEGORİ t = new TBLKATEGORİ();
            if (TxtKategoriAd.Text.Length <= 50)
            {
                t.AD = TxtKategoriAd.Text;
                db.TBLKATEGORİ.Add(t);
                db.SaveChanges();
                MessageBox.Show("Katagori Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Katogori Kaydedilemedi !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            //DialogResult vazgec = MessageBox.Show("Kategori ekleme işleminden vazgeçmek istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (vazgec == System.Windows.Forms.DialogResult.Yes)
            //{

            //    this.Close();

            //}
        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {
            //DialogResult vazgec = MessageBox.Show("Kategori ekleme işlem Ekranından Cıkış Yapmak İstediginden Emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            //if (vazgec == System.Windows.Forms.DialogResult.Yes)
            //{

            //    this.Close();

            //}
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
