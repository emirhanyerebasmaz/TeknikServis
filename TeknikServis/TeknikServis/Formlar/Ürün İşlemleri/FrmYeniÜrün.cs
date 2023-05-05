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
    public partial class FrmYeniÜrün : Form
    {
        public FrmYeniÜrün()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
                TBLURUN t = new TBLURUN();
                t.AD = TxtÜrünAd.Text;
                t.MARKA = TxtMarka.Text;
                t.ALISFIYAT = decimal.Parse(TxtAlışFiyat.Text);
                t.SATISFIYAT = decimal.Parse(TxtSatısFiyat.Text);
                t.STOK = short.Parse(TxtStok.Text);
                t.DURUM = false;
                t.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.TBLURUN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            //DialogResult vazgec = MessageBox.Show("Ürün ekleme işleminden vazgeçmek istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (vazgec == System.Windows.Forms.DialogResult.Yes)

            //{

            //    this.Close();

            //}
        }

        private void TxtÜrünAd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit5_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit6_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtKategori_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtAlışFiyat_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtSatısFiyat_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtStok_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtÜrünAd_Click(object sender, EventArgs e)
        {
            TxtÜrünAd.Text = "";
            TxtÜrünAd.Focus();
        }

        private void FrmYeniÜrün_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORİ
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD,
                                               }).ToList();
        }
    }
}
