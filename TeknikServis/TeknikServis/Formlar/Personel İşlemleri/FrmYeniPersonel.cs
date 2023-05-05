using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar.Personel_İşlemleri
{
    public partial class FrmYeniPersonel : Form
    {
        public FrmYeniPersonel()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLPERSONEL t = new TBLPERSONEL();


            if (TxtAd.Text.Length <= 30 && TxtSoyad.Text.Length <= 30)
            {
                t.AD = TxtAd.Text;
                t.SOYAD = TxtSoyad.Text;
                t.MAİL = TxtMail.Text;
                t.TELEFON = TxtTelefon.Text;
                //t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.TBLPERSONEL.Add(t);
                db.SaveChanges();
                MessageBox.Show("Personel Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Personel Kaydedilemedi !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            DialogResult vazgec = MessageBox.Show("Personel ekleme işleminden vazgeçmek istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vazgec == System.Windows.Forms.DialogResult.Yes)

            {

                this.Close();

            }
        }
    }
}
