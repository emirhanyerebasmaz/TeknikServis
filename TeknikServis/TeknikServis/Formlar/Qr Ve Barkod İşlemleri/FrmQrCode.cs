using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
namespace TeknikServis.Formlar.Qr_Ve_Barkod_İşlemleri
{
    public partial class FrmQrCode : Form
    {
        public FrmQrCode()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            pictureEdit1.Image = enc.Encode(textEdit1.Text);
        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
