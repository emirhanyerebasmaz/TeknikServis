namespace TeknikServis.Formlar.Araçlar
{
    partial class FrmAjanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjanda));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.Txtİcerik = new DevExpress.XtraEditors.TextEdit();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TxtBaşlık = new DevExpress.XtraEditors.TextEdit();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTarih = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtİcerik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaşlık.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 50);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1516, 311);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.SystemColors.Info;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(190, 27);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Okunmamış Notlar";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 377);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(165, 27);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Okunmuş Notlar";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(1, 410);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1516, 310);
            this.gridControl2.TabIndex = 13;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.SystemColors.Info;
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TxtTarih);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.Txtİcerik);
            this.groupControl1.Controls.Add(this.BtnListele);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.TxtBaşlık);
            this.groupControl1.Controls.Add(this.TxtId);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Location = new System.Drawing.Point(1523, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(400, 715);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Not İşlemleri";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(99, 222);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Okundu Olarak İşaretle";
            this.checkEdit1.Size = new System.Drawing.Size(219, 27);
            this.checkEdit1.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(22, 222);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 26);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Durum:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(22, 134);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 26);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "İçerik:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(19, 97);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 26);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Başlık:";
            // 
            // Txtİcerik
            // 
            this.Txtİcerik.Location = new System.Drawing.Point(90, 135);
            this.Txtİcerik.Name = "Txtİcerik";
            this.Txtİcerik.Size = new System.Drawing.Size(290, 26);
            this.Txtİcerik.TabIndex = 2;
            // 
            // BtnListele
            // 
            this.BtnListele.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnListele.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnListele.Appearance.Options.UseFont = true;
            this.BtnListele.Appearance.Options.UseForeColor = true;
            this.BtnListele.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnListele.ImageOptions.SvgImage")));
            this.BtnListele.Location = new System.Drawing.Point(89, 483);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnListele.Size = new System.Drawing.Size(290, 60);
            this.BtnListele.TabIndex = 8;
            this.BtnListele.Text = "Listele";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.Appearance.Options.UseForeColor = true;
            this.BtnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGuncelle.ImageOptions.SvgImage")));
            this.BtnGuncelle.Location = new System.Drawing.Point(89, 412);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnGuncelle.Size = new System.Drawing.Size(290, 60);
            this.BtnGuncelle.TabIndex = 7;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.Appearance.Options.UseForeColor = true;
            this.BtnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSil.ImageOptions.SvgImage")));
            this.BtnSil.Location = new System.Drawing.Point(89, 338);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnSil.Size = new System.Drawing.Size(290, 60);
            this.BtnSil.TabIndex = 6;
            this.BtnSil.Text = "Sil";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.Appearance.Options.UseForeColor = true;
            this.BtnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnKaydet.ImageOptions.SvgImage")));
            this.BtnKaydet.Location = new System.Drawing.Point(89, 272);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnKaydet.Size = new System.Drawing.Size(290, 60);
            this.BtnKaydet.TabIndex = 5;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtBaşlık
            // 
            this.TxtBaşlık.Location = new System.Drawing.Point(89, 98);
            this.TxtBaşlık.Name = "TxtBaşlık";
            this.TxtBaşlık.Size = new System.Drawing.Size(290, 26);
            this.TxtBaşlık.TabIndex = 1;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(89, 61);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(290, 26);
            this.TxtId.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(18, 60);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(65, 26);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Not ID:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(22, 178);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 26);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Tarih:";
            // 
            // TxtTarih
            // 
            this.TxtTarih.Location = new System.Drawing.Point(90, 179);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.Mask.EditMask = "d";
            this.TxtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.TxtTarih.Size = new System.Drawing.Size(290, 26);
            this.TxtTarih.TabIndex = 3;
            // 
            // FrmAjanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1924, 727);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmAjanda";
            this.Text = "Ajanda";
            this.Load += new System.EventHandler(this.FrmAjanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtİcerik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaşlık.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit Txtİcerik;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit TxtBaşlık;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtTarih;
    }
}