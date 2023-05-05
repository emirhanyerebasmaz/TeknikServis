namespace TeknikServis.Formlar.Fatura_İşlemleri
{
    partial class FrmFaturaKalemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaKalemleri));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSıraNo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSıraNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-5, 76);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1932, 647);
            this.gridControl1.TabIndex = 28;
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
            // 
            // BtnAra
            // 
            this.BtnAra.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.Appearance.Options.UseFont = true;
            this.BtnAra.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAra.ImageOptions.SvgImage")));
            this.BtnAra.Location = new System.Drawing.Point(869, 15);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnAra.Size = new System.Drawing.Size(202, 51);
            this.BtnAra.TabIndex = 4;
            this.BtnAra.Text = "Ara";
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(112, 30);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(169, 26);
            this.TxtId.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(94, 26);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "Fatura Id:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(291, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 26);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Seri No:";
            // 
            // TxtSeriNo
            // 
            this.TxtSeriNo.Location = new System.Drawing.Point(380, 30);
            this.TxtSeriNo.Name = "TxtSeriNo";
            this.TxtSeriNo.Properties.Mask.EditMask = "A";
            this.TxtSeriNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtSeriNo.Size = new System.Drawing.Size(169, 26);
            this.TxtSeriNo.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(568, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 26);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "Sıra No:";
            // 
            // TxtSıraNo
            // 
            this.TxtSıraNo.Location = new System.Drawing.Point(658, 31);
            this.TxtSıraNo.Name = "TxtSıraNo";
            this.TxtSıraNo.Properties.Mask.EditMask = "000000";
            this.TxtSıraNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtSıraNo.Size = new System.Drawing.Size(184, 26);
            this.TxtSıraNo.TabIndex = 3;
            // 
            // FrmFaturaKalemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 727);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TxtSıraNo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.TxtSeriNo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmFaturaKalemleri";
            this.Text = "Detaylı Fatura Sorgulama";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSıraNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnAra;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtSeriNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtSıraNo;
    }
}