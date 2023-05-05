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
    public partial class FrmSerialKey : Form
    {
        public FrmSerialKey()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Properties.Settings.Default.Key1)
            {
                Properties.Settings.Default.Kontrol = 1;
                Properties.Settings.Default.Save();
                MessageBox.Show("Ürün Anahtarınız Geçerli! Teşekkür Ederiz!");
                label1.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else if (textBox1.Text == Properties.Settings.Default.Key2)
            {
                Properties.Settings.Default.Kontrol = 1;
                Properties.Settings.Default.Save();
                MessageBox.Show("Ürün Anahtarınız Geçerli! Teşekkür Ederiz!");
                label1.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else if (textBox1.Text == Properties.Settings.Default.Key3)
            {
                Properties.Settings.Default.Kontrol = 1;
                Properties.Settings.Default.Save();
                MessageBox.Show("Ürün Anahtarınız Geçerli! Teşekkür Ederiz!");
                label1.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else if (textBox1.Text == Properties.Settings.Default.Key4)
            {
                Properties.Settings.Default.Kontrol = 1;
                Properties.Settings.Default.Save();
                MessageBox.Show("Ürün Anahtarınız Geçerli! Teşekkür Ederiz!");
                label1.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ürün Anahtarınız Geçersiz");
            }
        }
    }
}
