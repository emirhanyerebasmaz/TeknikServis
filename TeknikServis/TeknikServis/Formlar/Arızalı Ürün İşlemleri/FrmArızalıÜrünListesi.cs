using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar.Arızalı_Ürün_İşlemleri
{
    public partial class FrmArızalıÜrünListesi : Form
    {
        public FrmArızalıÜrünListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmArızalıÜrünListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.İSLEMID,
                               //ÜRÜN = x.TBLURUN.AD,
                               CARI = x.TBLCARİ.AD +" "+ x.TBLCARİ.SOYAD,
                               PRESONEL = x.TBLPERSONEL.AD +" "+ x.TBLPERSONEL.SOYAD,
                               x.GELİŞTARİHİ,
                               x.CIKISTARIHI,
                               x.URUNSERINO,
                               x.URUNDURUMDETAY,
                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl7.Text = db.TBLURUNKABUL.Count(x=>x.URUNDURUM==true).ToString();
            labelControl5.Text = db.TBLURUNKABUL.Count(x=>x.URUNDURUM==false).ToString();
            labelControl3.Text = db.TBLURUN.Count().ToString();
            labelControl13.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Parça Bekliyor").ToString();
            labelControl1.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Mesaj Bekleniyor").ToString();
            labelControl11.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "İptal Bekleniyor").ToString();

            SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-CT2V3O4;Initial Catalog=DbTeknikServis;Integrated Security=True");
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT  URUNDURUMDETAY, COUNT(*) FROM TBLURUNKABUL GROUP BY URUNDURUMDETAY", baglantı);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglantı.Close();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmArızaDetay fr = new FrmArızaDetay();
            fr.ıd = gridView1.GetFocusedRowCellValue("İSLEMID").ToString();
            fr.serino = gridView1.GetFocusedRowCellValue("URUNSERINO").ToString();
            fr.Show();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.İSLEMID,
                               //ÜRÜN = x.TBLURUN.AD,
                               CARI = x.TBLCARİ.AD + " " + x.TBLCARİ.SOYAD,
                               PRESONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                               x.GELİŞTARİHİ,
                               x.CIKISTARIHI,
                               x.URUNSERINO,
                               x.URUNDURUMDETAY,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
