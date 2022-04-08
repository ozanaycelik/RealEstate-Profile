
namespace RealEstate_Profile
{
    partial class GayrimenkulTipi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GayrimenkulTipi));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_yeni_tip = new DevExpress.XtraEditors.TextEdit();
            this.btn_gayr_tipi_degistir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbx_gyr_tipleri = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_gayr_tipi_sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_gayr_tipi_kaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yeni_tip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_gyr_tipleri.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_yeni_tip);
            this.groupControl1.Controls.Add(this.btn_gayr_tipi_degistir);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cbx_gyr_tipleri);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btn_gayr_tipi_sil);
            this.groupControl1.Controls.Add(this.btn_gayr_tipi_kaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(536, 278);
            this.groupControl1.TabIndex = 2;
            // 
            // txt_yeni_tip
            // 
            this.txt_yeni_tip.Location = new System.Drawing.Point(170, 110);
            this.txt_yeni_tip.Name = "txt_yeni_tip";
            this.txt_yeni_tip.Size = new System.Drawing.Size(276, 26);
            this.txt_yeni_tip.TabIndex = 8;
            // 
            // btn_gayr_tipi_degistir
            // 
            this.btn_gayr_tipi_degistir.Location = new System.Drawing.Point(182, 168);
            this.btn_gayr_tipi_degistir.Name = "btn_gayr_tipi_degistir";
            this.btn_gayr_tipi_degistir.Size = new System.Drawing.Size(124, 37);
            this.btn_gayr_tipi_degistir.TabIndex = 7;
            this.btn_gayr_tipi_degistir.Text = "Değiştir";
            this.btn_gayr_tipi_degistir.Click += new System.EventHandler(this.btn_gayr_tipi_degistir_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 117);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 19);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Yeni Tip :";
            // 
            // cbx_gyr_tipleri
            // 
            this.cbx_gyr_tipleri.Location = new System.Drawing.Point(170, 60);
            this.cbx_gyr_tipleri.Name = "cbx_gyr_tipleri";
            this.cbx_gyr_tipleri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_gyr_tipleri.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbx_gyr_tipleri.Size = new System.Drawing.Size(276, 26);
            this.cbx_gyr_tipleri.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(150, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Gayrimenkul Tipleri :";
            // 
            // btn_gayr_tipi_sil
            // 
            this.btn_gayr_tipi_sil.Location = new System.Drawing.Point(322, 168);
            this.btn_gayr_tipi_sil.Name = "btn_gayr_tipi_sil";
            this.btn_gayr_tipi_sil.Size = new System.Drawing.Size(124, 37);
            this.btn_gayr_tipi_sil.TabIndex = 2;
            this.btn_gayr_tipi_sil.Text = "Sil";
            this.btn_gayr_tipi_sil.Click += new System.EventHandler(this.btn_gayr_tipi_sil_Click);
            // 
            // btn_gayr_tipi_kaydet
            // 
            this.btn_gayr_tipi_kaydet.Location = new System.Drawing.Point(43, 168);
            this.btn_gayr_tipi_kaydet.Name = "btn_gayr_tipi_kaydet";
            this.btn_gayr_tipi_kaydet.Size = new System.Drawing.Size(121, 37);
            this.btn_gayr_tipi_kaydet.TabIndex = 1;
            this.btn_gayr_tipi_kaydet.Text = "Kaydet";
            this.btn_gayr_tipi_kaydet.Click += new System.EventHandler(this.btn_gayr_tipi_kaydet_Click);
            // 
            // GayrimenkulTipi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 278);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("GayrimenkulTipi.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.Name = "GayrimenkulTipi";
            this.Text = "Gayrimenkul Tipleri";
            this.Load += new System.EventHandler(this.GayrimenkulTipi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yeni_tip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_gyr_tipleri.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_yeni_tip;
        private DevExpress.XtraEditors.SimpleButton btn_gayr_tipi_degistir;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_gyr_tipleri;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_gayr_tipi_sil;
        private DevExpress.XtraEditors.SimpleButton btn_gayr_tipi_kaydet;
    }
}