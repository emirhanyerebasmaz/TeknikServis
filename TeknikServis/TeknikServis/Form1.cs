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
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Kategori_İşlemleri.FrmYeniKategori fr = new Formlar.Kategori_İşlemleri.FrmYeniKategori();
            //fr.MdiParent = this;
            fr.Show();
        }
             Formlar.Kategori_İşlemleri.FrmKategoriİşlemleri fr2;
        private void BtnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new Formlar.Kategori_İşlemleri.FrmKategoriİşlemleri();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }
        Formlar.Ürün_İşlemleri.FrmYeniÜrün fr3;
        private void BtnYeniÜrün_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null || fr3.IsDisposed)
            {
                fr3 = new Formlar.Ürün_İşlemleri.FrmYeniÜrün();
                //fr.MdiParent = this;
                fr3.Show();
            }
        }
        Formlar.Ürün_İşlemleri.FrmÜrünListesi fr4;
        private void BtnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null || fr4.IsDisposed)
            {
                fr4 = new Formlar.Ürün_İşlemleri.FrmÜrünListesi();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }
        Formlar.İstatislik_İşlemleri.FrmÜrünİstatislik fr5;
        private void BtnÜrünİstatislik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)
            {
                fr5 = new Formlar.İstatislik_İşlemleri.FrmÜrünİstatislik();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }
        Formlar.İstatislik_İşlemleri.FrmMarkaİstatislik fr6;
        private void BtnMarkaİstatislik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null || fr6.IsDisposed)
            {
                fr6 = new Formlar.İstatislik_İşlemleri.FrmMarkaİstatislik();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
            Formlar.Araçlar.FrmDövizKurları fr7;
        private void BtnDövizKurları_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null || fr7.IsDisposed)
            {
                fr7 = new Formlar.Araçlar.FrmDövizKurları();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }
        Formlar.Cari_İşlemleri.FrmCariListesi fr8;
        private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null || fr8.IsDisposed)
            {
                fr8 = new Formlar.Cari_İşlemleri.FrmCariListesi();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }
        Formlar.Cari_İşlemleri.FrmYeniCari fr9;
        private void BtnYeniCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null || fr9.IsDisposed)
            {
                fr9= new Formlar.Cari_İşlemleri.FrmYeniCari ();
                //fr.MdiParent = this;
                fr9.Show();
            }
        }
        Formlar.Cari_İşlemleri.FrmCariİlİstatisligi fr10;

        private void BtnCariİlİstatisligi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null || fr10.IsDisposed)
            {
                fr10 = new Formlar.Cari_İşlemleri.FrmCariİlİstatisligi();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }
            Formlar.Araçlar.FrmAjanda fr11;

        private void FrmAjanda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null || fr11.IsDisposed)
            {
                fr11 = new Formlar.Araçlar.FrmAjanda();
                fr11.MdiParent = this;
                fr11.Show();
            }
        }
        Formlar.Araçlar.FrmYeniNot fr12;
        private void BtnYeniNot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null || fr12.IsDisposed)
            {
                fr12 = new Formlar.Araçlar.FrmYeniNot();
                //fr.MdiParent = this;
                fr12.Show();
            }
        }
        

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Formlar.FrmPersonelListesi fr = new Formlar.FrmPersonelListesi();
            fr.MdiParent = this;
            fr.Show();
        }
        private void FrmYeniPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Personel_İşlemleri.FrmYeniPersonel fr = new Formlar.Personel_İşlemleri.FrmYeniPersonel();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void BtnDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Personel_İşlemleri.FrmDepartmanListesi fr = new Formlar.Personel_İşlemleri.FrmDepartmanListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Personel_İşlemleri.FrmYeniDepartman fr = new Formlar.Personel_İşlemleri.FrmYeniDepartman();
            //fr.MdiParent = this;
            fr.Show();
        }

        private Formlar.Arızalı_Ürün_İşlemleri.FrmArızalıÜrünListesi fr14;
        private void BtnArızalıÜrünListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14 == null || fr14.IsDisposed)
            {
                fr14 = new Formlar.Arızalı_Ürün_İşlemleri.FrmArızalıÜrünListesi();
                fr14.MdiParent = this;
                fr14.Show();
            }
        }

        private void FrmUrunSatıs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Ürün_İşlemleri.FrmÜrünSatıs fr = new Formlar.Ürün_İşlemleri.FrmÜrünSatıs();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                Formlar.Ürün_İşlemleri.FrmSatıışListesi fr = new Formlar.Ürün_İşlemleri.FrmSatıışListesi();
                fr.MdiParent = this;
                fr.Show();
            
        }

        private void BtnYeniArızalıÜrünKaydı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Arızalı_Ürün_İşlemleri.FrmYeniArızalıÜrün fr = new Formlar.Arızalı_Ürün_İşlemleri.FrmYeniArızalıÜrün();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void ArızalıÜrünAcıklama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Arızalı_Ürün_İşlemleri.FrmArızaDetay fr = new Formlar.Arızalı_Ürün_İşlemleri.FrmArızaDetay();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void BtnArızalıÜrünDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Arızalı_Ürün_İşlemleri.ArızalıÜrünDetayListesi fr = new Formlar.Arızalı_Ürün_İşlemleri.ArızalıÜrünDetayListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnQrCodeOluştur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Qr_Ve_Barkod_İşlemleri.FrmQrCode fr = new Formlar.Qr_Ve_Barkod_İşlemleri.FrmQrCode();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void BtnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Fatura_İşlemleri.FrmFaturaListesi fr = new Formlar.Fatura_İşlemleri.FrmFaturaListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnFaturaKalemGirişi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Fatura_İşlemleri.FrmFaturaKalem fr = new Formlar.Fatura_İşlemleri.FrmFaturaKalem();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnFaturaKalemListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Fatura_İşlemleri.FrmFaturaKalemleri fr = new Formlar.Fatura_İşlemleri.FrmFaturaKalemleri();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnHakkımızda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Araçlar.FrmHaritalar fr = new Formlar.Araçlar.FrmHaritalar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Raporlar.FrmRapor fr = new Formlar.Raporlar.FrmRapor();
            //fr.MdiParent = this;
            fr.Show();
        }
        Formlar.FrmAnaSayfa fr;
        private void Form1_Load(object sender, EventArgs e)
        {
        
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAnaSayfa();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAnaSayfa();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void BtnWebSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BtnBarkodOluştur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Qr_Ve_Barkod_İşlemleri.FrmBarkod fr = new Formlar.Qr_Ve_Barkod_İşlemleri.FrmBarkod();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGauge_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Araçlar.FrmGauge fr = new Formlar.Araçlar.FrmGauge();
            fr.MdiParent = this;
            fr.Show();
        }
        Formlar.İletişim_İşlemleri.FrmRehber fr15;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //İletişim
            if (fr15 == null || fr15.IsDisposed)
            {
                fr15 = new Formlar.İletişim_İşlemleri.FrmRehber();
                fr15.MdiParent = this;
                fr15.Show();
            }
        }
        Formlar.İletişim_İşlemleri.FrmGelenMesajlar fr16;
        private void BtnGelenMesaj_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr16 == null || fr16.IsDisposed)
            {
                fr16 = new Formlar.İletişim_İşlemleri.FrmGelenMesajlar();
                fr16.MdiParent = this;
                fr16.Show();
            }
        }

        private void BtnYeniMail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Formlar.İletişim_İşlemleri.mai fr = new Formlar.İletişim_İşlemleri.MailGönder();
            ////fr.MdiParent = this;
            //fr.Show();
        }
        Formlar.Ürün_İşlemleri.ÜrünAra fr17;
        private void BtnUrunAra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr17 == null || fr17.IsDisposed)
            {
                fr17 = new Formlar.Ürün_İşlemleri.ÜrünAra();
                fr17.MdiParent = this;
                fr17.Show();
            }
        }

        private void FrmYeniFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Fatura_İşlemleri.FrmYeniFatura fr = new Formlar.Fatura_İşlemleri.FrmYeniFatura();
            //fr.MdiParent = this;
            fr.Show();
        }
        Formlar.Araçlar.FrmDövizİşlemleri fr18;

        private void BtnDövizİşlemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr18 == null || fr18.IsDisposed)
            {
                fr18 = new Formlar.Araçlar.FrmDövizİşlemleri();
                fr18.MdiParent = this;
                fr18.Show();
            }
        }

        private void BtnPersonelİşlemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void BtnAnahtarımVar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSerialKey fr = new FrmSerialKey();
            fr.Show();
            this.Hide();
        }
    }
}
