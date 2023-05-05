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

namespace TeknikServis.Formlar.Araçlar
{
    public partial class FrmAjanda : Form
    {
        public FrmAjanda()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmAjanda_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLNOTLAR.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TBLNOTLAR.Where(y => y.DURUM == true).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLAR t = new TBLNOTLAR();
            t.BASLIK = TxtBaşlık.Text;
            t.ICERIK = Txtİcerik.Text;
            t.DURUM = false;
            t.TARİH = DateTime.Parse(TxtTarih.Text);
            db.TBLNOTLAR.Add(t);
            db.SaveChanges();
            MessageBox.Show("Not Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLNOTLAR.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TBLNOTLAR.Where(y => y.DURUM == true).ToList();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                int id = int.Parse(TxtId.Text);
                var deger = db.TBLNOTLAR.Find(id);
                deger.DURUM = true;
                db.SaveChanges();
                MessageBox.Show("Not Durumu Değiştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtBaşlık.Text = gridView1.GetFocusedRowCellValue("BASLIK").ToString();
            Txtİcerik.Text = gridView1.GetFocusedRowCellValue("ICERIK").ToString();
        }
    }
}
