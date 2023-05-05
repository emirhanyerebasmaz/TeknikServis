using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar.Arızalı_Ürün_İşlemleri
{
    public partial class FrmArızaDetay : Form
    {
        public FrmArızaDetay()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            
            TBLURUNTAKİP t = new TBLURUNTAKİP();
            t.ACIKLAMA = richTextBox1.Text;
            t.SERINO = textEdit1.Text;
            t.TARIH =DateTime.Parse(TxtTarih.Text);
            db.TBLURUNTAKİP.Add(t);

            //2.Güncelleme
            TBLURUNKABUL tb = new TBLURUNKABUL();
            int urunıd =int.Parse(ıd.ToString());
            var deger = db.TBLURUNKABUL.Find(urunıd);
            deger.URUNDURUMDETAY = comboBox1.Text;
            db.SaveChanges();
            MessageBox.Show("Yeni Arızalı Ürün Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            DialogResult vazgec = MessageBox.Show("Yeni Arızalı Ürün Ekleme işleminden Vazgeçmek İstediğinize Emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vazgec == System.Windows.Forms.DialogResult.Yes)

            {

                this.Close();

            }
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            textEdit1.Text = "";
        }
        public string ıd, serino;
        private void FrmArızaDetay_Load(object sender, EventArgs e)
        {
            textEdit1.Text = serino;
        }
    }
}
