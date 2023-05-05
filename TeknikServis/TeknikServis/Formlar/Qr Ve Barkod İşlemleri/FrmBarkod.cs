using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar.Qr_Ve_Barkod_İşlemleri
{
    public partial class FrmBarkod : Form
    {
        public FrmBarkod()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw brc = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureEdit1.Image = brc.Draw(textEdit1.Text,35);
        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
