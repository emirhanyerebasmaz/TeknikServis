using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar.İstatislik_İşlemleri
{
    public partial class FrmÜrünİstatislik : Form
    {
        public FrmÜrünİstatislik()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmÜrünİstatislik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TBLURUN.Count().ToString(); //Toplam Ürün Sayısı
            labelControl29.Text = db.TBLKATEGORİ.Count().ToString(); //Toplam Kategori Sayısı
            labelControl27.Text = db.TBLURUN.Sum(x => x.STOK).ToString(); //Toplam Stok Sayısı
            labelControl25.Text = "10"; //Kıritik Seviye
            labelControl3.Text = (from x in db.TBLURUN
                                   orderby x.STOK descending    //En Fazla Stoklu Ürün
                                   select x.AD).FirstOrDefault();
            labelControl5.Text = (from x in db.TBLURUN
                                   orderby x.STOK ascending     //En Az Stoklu Ürün
                                   select x.AD).FirstOrDefault();
            labelControl7.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT descending    //En Yüksek Fİyatlı Ürün
                                   select x.AD).FirstOrDefault();
            labelControl11.Text = (from x in db.TBLURUN
                                  orderby x.SATISFIYAT ascending    //En az Fİyatlı Ürün
                                  select x.AD).FirstOrDefault();
            labelControl15.Text = db.TBLURUN.Count(x => x.KATEGORI == 4).ToString();  //Beyaz Eşya Stok Sayısı
            labelControl17.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();  //Bilgisiyar Stok Sayısı
            labelControl13.Text = (from x in db.TBLURUN         //Toplam Marka Sayısı
                                   select x.MARKA).Distinct().Count().ToString();
            labelControl21.Text = db.TBLURUNKABUL.Count().ToString();
            labelControl9.Text = db.makskategori().FirstOrDefault();
            labelControl19.Text = db.TBLURUN.Count(x => x.KATEGORI == 5).ToString();
        }

        private void labelControl25_Click(object sender, EventArgs e)
        {

        }
    }
}
