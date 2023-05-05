using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class LoginFormu : Form
    {
        public LoginFormu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN where x.KULLANICIAD == textBox1.Text && x.SIFRA == textBox2.Text  select x;
            if (sorgu.Any())
            {
                Form1 frm = new Form1();
                frm.labelControl1.Text ="Kullanıcı: " + textBox1.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifreniz Hatalı Lütfen Kontrol Edip Tekrar Deneyiniz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void LoginFormu_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar =char.Parse("*");
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            YeniÜye kayit = new YeniÜye();
            this.Hide();
            kayit.ShowDialog();
        }

        private void linkLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            SıfreUnuttum kayit = new SıfreUnuttum();
            this.Hide();
            kayit.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/emir_yerebasmaz/");
       
        }
    }
}
