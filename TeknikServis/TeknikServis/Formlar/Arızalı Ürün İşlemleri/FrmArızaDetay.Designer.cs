namespace TeknikServis.Formlar.Arızalı_Ürün_İşlemleri
{
    partial class FrmArızaDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArızaDetay));
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtTarih = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.BtnVazgec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.Appearance.Options.UseForeColor = true;
            this.BtnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGuncelle.ImageOptions.SvgImage")));
            this.BtnGuncelle.Location = new System.Drawing.Point(12, 427);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnGuncelle.Size = new System.Drawing.Size(258, 77);
            this.BtnGuncelle.TabIndex = 72;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(49, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(409, 36);
            this.labelControl1.TabIndex = 73;
            this.labelControl1.Text = "ARIZALI ÜRÜN KAYDI AÇIKLAMA";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DimGray;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(17, 288);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(477, 142);
            this.richTextBox1.TabIndex = 74;
            this.richTextBox1.Text = "....";
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(18, 256);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(173, 26);
            this.labelControl4.TabIndex = 79;
            this.labelControl4.Text = "ARIZA DETAYLARI:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(18, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 5);
            this.panel1.TabIndex = 96;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(17, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 5);
            this.panel4.TabIndex = 98;
            // 
            // TxtTarih
            // 
            this.TxtTarih.EditValue = "Tarih";
            this.TxtTarih.Location = new System.Drawing.Point(14, 135);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.TxtTarih.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTarih.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtTarih.Properties.Appearance.Options.UseBackColor = true;
            this.TxtTarih.Properties.Appearance.Options.UseFont = true;
            this.TxtTarih.Properties.Appearance.Options.UseForeColor = true;
            this.TxtTarih.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtTarih.Properties.Mask.EditMask = "F";
            this.TxtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.TxtTarih.Size = new System.Drawing.Size(394, 32);
            this.TxtTarih.TabIndex = 97;
            this.TxtTarih.Click += new System.EventHandler(this.TxtTarih_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(18, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 5);
            this.panel2.TabIndex = 98;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DimGray;
            this.comboBox1.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ürün Kaydoldu",
            "Parça Bekliyor",
            "Mesaj Bekliyor",
            "İptal Edildi",
            "Fiyat Verildi"});
            this.comboBox1.Location = new System.Drawing.Point(18, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(396, 35);
            this.comboBox1.TabIndex = 99;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Seri No";
            this.textEdit1.Location = new System.Drawing.Point(18, 74);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit1.Size = new System.Drawing.Size(396, 32);
            this.textEdit1.TabIndex = 100;
            this.textEdit1.Click += new System.EventHandler(this.textEdit1_Click);
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVazgec.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnVazgec.Appearance.Options.UseFont = true;
            this.BtnVazgec.Appearance.Options.UseForeColor = true;
            this.BtnVazgec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnVazgec.ImageOptions.SvgImage")));
            this.BtnVazgec.Location = new System.Drawing.Point(264, 427);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnVazgec.Size = new System.Drawing.Size(248, 77);
            this.BtnVazgec.TabIndex = 101;
            this.BtnVazgec.Text = "Vazgeç";
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // FrmArızaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(524, 516);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TxtTarih);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnGuncelle);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArızaDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArızaDetay";
            this.Load += new System.EventHandler(this.FrmArızaDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.TextEdit TxtTarih;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton BtnVazgec;
    }
}