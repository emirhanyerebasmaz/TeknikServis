using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeknikServis.Formlar.Cari_İşlemleri
{
    public partial class FrmCariİlİstatisligi : Form
    {
        public FrmCariİlİstatisligi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        SqlConnection baglantı = new SqlConnection(@"Data Source=.;Initial Catalog=DbTeknikServis;Integrated Security=True");
        private void FrmCariİlİstatisligi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLCARİ.OrderBy(x => x.İL).GroupBy(y => y.İL).Select(z => new { İL = z.Key, Toplam = z.Count() }).ToList();

            baglantı.Open();
            SqlCommand komut = new SqlCommand("select İL,COUNT(*) FROM TBLCARİ group by İL", baglantı);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));

            }
            baglantı.Close();
        }
    }
}
