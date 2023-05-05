using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TeknikServis.Formlar.İstatislik_İşlemleri
{
    public partial class FrmMarkaİstatislik : Form
    {
        public FrmMarkaİstatislik()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmMarkaİstatislik_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA)
                                         .Select(z => new
                                           {
                                             Marka = z.Key,
                                             Toplam = z.Count()

                                           });

            gridControl1.DataSource = degerler.ToList();

            labelControl3.Text = (from x in db.TBLURUN         //Toplam Marka Sayısı
                                  select x.MARKA).Distinct().Count().ToString();
            labelControl2.Text = db.TBLURUN.Count().ToString(); //Toplam Ürün Sayısı
            labelControl7.Text = (from x in db.TBLURUN
                                  orderby x.SATISFIYAT descending    //En Yüksek Fİyatlı Ürün
                                  select x.MARKA).FirstOrDefault();
            labelControl5.Text = (from x in db.TBLURUN
                                  orderby x.SATISFIYAT descending    //En Yüksek Fİyatlı Marka
                                  select x.MARKA).FirstOrDefault();

            SqlConnection baglantı = new SqlConnection(@"Data Source=.;Initial Catalog=DbTeknikServis;Integrated Security=True");
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT  MARKA, COUNT(*) FROM TBLURUN GROUP BY MARKA", baglantı);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglantı.Close();
            
            //2.Chart
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("SELECT  TBLKATEGORI.AD,COUNT(*) FROM TBLURUN INNER JOIN TBLKATEGORI ON TBLKATEGORI.ID=TBLURUN.KATEGORI GROUP BY TBLKATEGORI.AD", baglantı);
            SqlDataReader dr2 = komut.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["KATEGORILER"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            baglantı.Close();
        }
    }
}
