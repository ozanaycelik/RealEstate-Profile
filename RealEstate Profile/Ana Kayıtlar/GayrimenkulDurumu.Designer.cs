
namespace RealEstate_Profile.Ana_Kayıtlar
{
    partial class GayrimenkulDurumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GayrimenkulDurumu));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_yeni_durumu = new DevExpress.XtraEditors.TextEdit();
            this.btn_gayr_durumu_degistir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbx_gyr_durumu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_gayr_durumu_sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_gayr_durumu_kaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yeni_durumu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_gyr_durumu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.Controls.Add(this.txt_yeni_durumu);
            this.groupControl1.Controls.Add(this.btn_gayr_durumu_degistir);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cbx_gyr_durumu);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btn_gayr_durumu_sil);
            this.groupControl1.Controls.Add(this.btn_gayr_durumu_kaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(530, 267);
            this.groupControl1.TabIndex = 3;
            // 
            // txt_yeni_durumu
            // 
            this.txt_yeni_durumu.Location = new System.Drawing.Point(170, 110);
            this.txt_yeni_durumu.Name = "txt_yeni_durumu";
            this.txt_yeni_durumu.Size = new System.Drawing.Size(276, 26);
            this.txt_yeni_durumu.TabIndex = 8;
            // 
            // btn_gayr_durumu_degistir
            // 
            this.btn_gayr_durumu_degistir.Location = new System.Drawing.Point(182, 168);
            this.btn_gayr_durumu_degistir.Name = "btn_gayr_durumu_degistir";
            this.btn_gayr_durumu_degistir.Size = new System.Drawing.Size(124, 37);
            this.btn_gayr_durumu_degistir.TabIndex = 7;
            this.btn_gayr_durumu_degistir.Text = "Değiştir";
            this.btn_gayr_durumu_degistir.Click += new System.EventHandler(this.btn_gayr_durumu_degistir_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 117);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 19);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Yeni Tip :";
            // 
            // cbx_gyr_durumu
            // 
            this.cbx_gyr_durumu.Location = new System.Drawing.Point(170, 60);
            this.cbx_gyr_durumu.Name = "cbx_gyr_durumu";
            this.cbx_gyr_durumu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_gyr_durumu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbx_gyr_durumu.Size = new System.Drawing.Size(276, 26);
            this.cbx_gyr_durumu.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(150, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Gayrimenkul Tipleri :";
            // 
            // btn_gayr_durumu_sil
            // 
            this.btn_gayr_durumu_sil.Location = new System.Drawing.Point(322, 168);
            this.btn_gayr_durumu_sil.Name = "btn_gayr_durumu_sil";
            this.btn_gayr_durumu_sil.Size = new System.Drawing.Size(124, 37);
            this.btn_gayr_durumu_sil.TabIndex = 2;
            this.btn_gayr_durumu_sil.Text = "Sil";
            this.btn_gayr_durumu_sil.Click += new System.EventHandler(this.btn_gayr_durumu_sil_Click);
            // 
            // btn_gayr_durumu_kaydet
            // 
            this.btn_gayr_durumu_kaydet.Location = new System.Drawing.Point(43, 168);
            this.btn_gayr_durumu_kaydet.Name = "btn_gayr_durumu_kaydet";
            this.btn_gayr_durumu_kaydet.Size = new System.Drawing.Size(121, 37);
            this.btn_gayr_durumu_kaydet.TabIndex = 1;
            this.btn_gayr_durumu_kaydet.Text = "Kaydet";
            this.btn_gayr_durumu_kaydet.Click += new System.EventHandler(this.btn_gayr_tipi_kaydet_Click);
            // 
            // GayrimenkulDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 267);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("GayrimenkulDurumu.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.Name = "GayrimenkulDurumu";
            this.Text = "GayrimenkulDurumu";
            this.Load += new System.EventHandler(this.GayrimenkulDurumu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yeni_durumu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_gyr_durumu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_yeni_durumu;
        private DevExpress.XtraEditors.SimpleButton btn_gayr_durumu_degistir;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_gyr_durumu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_gayr_durumu_sil;
        private DevExpress.XtraEditors.SimpleButton btn_gayr_durumu_kaydet;
    }
}