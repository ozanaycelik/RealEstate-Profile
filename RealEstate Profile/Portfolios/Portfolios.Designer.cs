
namespace RealEstate_Profile.Portfolios
{
    partial class portfolios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(portfolios));
            this.gc_filters = new DevExpress.XtraEditors.GroupControl();
            this.btn_excel_export = new DevExpress.XtraEditors.SimpleButton();
            this.dt_endDate = new DevExpress.XtraEditors.DateEdit();
            this.dt_begDate = new DevExpress.XtraEditors.DateEdit();
            this.btn_uygula = new DevExpress.XtraEditors.SimpleButton();
            this.cbx_mahalle_get = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbx_town_get = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_beg_date = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PortfolioNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PortfolioDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NetTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.City = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Town = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mahalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popup_menu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barbtn_add = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_change = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_look = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_delete = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_toplu_sil = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gc_filters)).BeginInit();
            this.gc_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_endDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_endDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_begDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_begDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_mahalle_get.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_town_get.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popup_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_filters
            // 
            this.gc_filters.Controls.Add(this.btn_excel_export);
            this.gc_filters.Controls.Add(this.dt_endDate);
            this.gc_filters.Controls.Add(this.dt_begDate);
            this.gc_filters.Controls.Add(this.btn_uygula);
            this.gc_filters.Controls.Add(this.cbx_mahalle_get);
            this.gc_filters.Controls.Add(this.labelControl3);
            this.gc_filters.Controls.Add(this.cbx_town_get);
            this.gc_filters.Controls.Add(this.labelControl2);
            this.gc_filters.Controls.Add(this.labelControl1);
            this.gc_filters.Controls.Add(this.lbl_beg_date);
            this.gc_filters.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_filters.Location = new System.Drawing.Point(0, 0);
            this.gc_filters.Name = "gc_filters";
            this.gc_filters.Size = new System.Drawing.Size(1527, 109);
            this.gc_filters.TabIndex = 0;
            this.gc_filters.Text = "Filtreler";
            // 
            // btn_excel_export
            // 
            this.btn_excel_export.Location = new System.Drawing.Point(1343, 41);
            this.btn_excel_export.Name = "btn_excel_export";
            this.btn_excel_export.Size = new System.Drawing.Size(172, 34);
            this.btn_excel_export.TabIndex = 11;
            this.btn_excel_export.Text = "Excele Aktar";
            this.btn_excel_export.Click += new System.EventHandler(this.btn_excel_export_Click);
            // 
            // dt_endDate
            // 
            this.dt_endDate.EditValue = null;
            this.dt_endDate.Location = new System.Drawing.Point(428, 46);
            this.dt_endDate.Name = "dt_endDate";
            this.dt_endDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_endDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_endDate.Size = new System.Drawing.Size(173, 26);
            this.dt_endDate.TabIndex = 10;
            // 
            // dt_begDate
            // 
            this.dt_begDate.EditValue = null;
            this.dt_begDate.Location = new System.Drawing.Point(140, 46);
            this.dt_begDate.Name = "dt_begDate";
            this.dt_begDate.Properties.BeepOnError = false;
            this.dt_begDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_begDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_begDate.Properties.MaskSettings.Set("mask", "d");
            this.dt_begDate.Properties.MaskSettings.Set("culture", null);
            this.dt_begDate.Properties.MaskSettings.Set("useAdvancingCaret", true);
            this.dt_begDate.Properties.MaskSettings.Set("spinWithCarry", true);
            this.dt_begDate.Size = new System.Drawing.Size(173, 26);
            this.dt_begDate.TabIndex = 9;
            // 
            // btn_uygula
            // 
            this.btn_uygula.Location = new System.Drawing.Point(1149, 41);
            this.btn_uygula.Name = "btn_uygula";
            this.btn_uygula.Size = new System.Drawing.Size(172, 34);
            this.btn_uygula.TabIndex = 8;
            this.btn_uygula.Text = "Uygula";
            this.btn_uygula.Click += new System.EventHandler(this.btn_uygula_Click);
            // 
            // cbx_mahalle_get
            // 
            this.cbx_mahalle_get.Location = new System.Drawing.Point(945, 46);
            this.cbx_mahalle_get.Name = "cbx_mahalle_get";
            this.cbx_mahalle_get.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_mahalle_get.Properties.Items.AddRange(new object[] {
            "Hepsi"});
            this.cbx_mahalle_get.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbx_mahalle_get.Size = new System.Drawing.Size(151, 26);
            this.cbx_mahalle_get.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(875, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Mahalle :";
            // 
            // cbx_town_get
            // 
            this.cbx_town_get.Location = new System.Drawing.Point(696, 46);
            this.cbx_town_get.Name = "cbx_town_get";
            this.cbx_town_get.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_town_get.Properties.Items.AddRange(new object[] {
            "Hepsi"});
            this.cbx_town_get.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbx_town_get.Size = new System.Drawing.Size(151, 26);
            this.cbx_town_get.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(654, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "İlçe :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(336, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Bitiş Tarihi :";
            // 
            // lbl_beg_date
            // 
            this.lbl_beg_date.Location = new System.Drawing.Point(12, 49);
            this.lbl_beg_date.Name = "lbl_beg_date";
            this.lbl_beg_date.Size = new System.Drawing.Size(122, 19);
            this.lbl_beg_date.TabIndex = 0;
            this.lbl_beg_date.Text = "Başlangıç Tarihi :";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 109);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1527, 582);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            this.gridControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseUp);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Check,
            this.PortfolioNumber,
            this.PortfolioDate,
            this.CustomerName,
            this.CustomerSurname,
            this.Phone1,
            this.NetTotal,
            this.City,
            this.Town,
            this.Mahalle});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            // 
            // Check
            // 
            this.Check.Caption = "#";
            this.Check.FieldName = "Check";
            this.Check.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.Check.MinWidth = 30;
            this.Check.Name = "Check";
            this.Check.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.Top;
            this.Check.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.Check.Visible = true;
            this.Check.VisibleIndex = 0;
            this.Check.Width = 70;
            // 
            // PortfolioNumber
            // 
            this.PortfolioNumber.Caption = "Portföy Numarası";
            this.PortfolioNumber.FieldName = "PortfolioNumber";
            this.PortfolioNumber.MinWidth = 30;
            this.PortfolioNumber.Name = "PortfolioNumber";
            this.PortfolioNumber.OptionsColumn.AllowEdit = false;
            this.PortfolioNumber.OptionsColumn.ReadOnly = true;
            this.PortfolioNumber.Visible = true;
            this.PortfolioNumber.VisibleIndex = 1;
            this.PortfolioNumber.Width = 154;
            // 
            // PortfolioDate
            // 
            this.PortfolioDate.Caption = "Portföy Tarihi";
            this.PortfolioDate.FieldName = "PortfolioDate";
            this.PortfolioDate.MinWidth = 30;
            this.PortfolioDate.Name = "PortfolioDate";
            this.PortfolioDate.OptionsColumn.ReadOnly = true;
            this.PortfolioDate.Visible = true;
            this.PortfolioDate.VisibleIndex = 2;
            this.PortfolioDate.Width = 154;
            // 
            // CustomerName
            // 
            this.CustomerName.Caption = "Müşteri Adı";
            this.CustomerName.FieldName = "CustomerName";
            this.CustomerName.MinWidth = 30;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.OptionsColumn.ReadOnly = true;
            this.CustomerName.Visible = true;
            this.CustomerName.VisibleIndex = 3;
            this.CustomerName.Width = 154;
            // 
            // CustomerSurname
            // 
            this.CustomerSurname.Caption = "Müşteri Soyadı";
            this.CustomerSurname.FieldName = "CustomerSurname";
            this.CustomerSurname.MinWidth = 30;
            this.CustomerSurname.Name = "CustomerSurname";
            this.CustomerSurname.OptionsColumn.ReadOnly = true;
            this.CustomerSurname.Visible = true;
            this.CustomerSurname.VisibleIndex = 4;
            this.CustomerSurname.Width = 154;
            // 
            // Phone1
            // 
            this.Phone1.Caption = "Telefon Numarası";
            this.Phone1.FieldName = "Phone1";
            this.Phone1.MinWidth = 30;
            this.Phone1.Name = "Phone1";
            this.Phone1.OptionsColumn.ReadOnly = true;
            this.Phone1.Visible = true;
            this.Phone1.VisibleIndex = 5;
            this.Phone1.Width = 154;
            // 
            // NetTotal
            // 
            this.NetTotal.Caption = "Net Fiyatı";
            this.NetTotal.FieldName = "NetTotal";
            this.NetTotal.MinWidth = 30;
            this.NetTotal.Name = "NetTotal";
            this.NetTotal.OptionsColumn.ReadOnly = true;
            this.NetTotal.Visible = true;
            this.NetTotal.VisibleIndex = 6;
            this.NetTotal.Width = 154;
            // 
            // City
            // 
            this.City.Caption = "İl";
            this.City.FieldName = "City";
            this.City.MinWidth = 30;
            this.City.Name = "City";
            this.City.OptionsColumn.ReadOnly = true;
            this.City.Visible = true;
            this.City.VisibleIndex = 7;
            this.City.Width = 154;
            // 
            // Town
            // 
            this.Town.Caption = "İlçe";
            this.Town.FieldName = "Town";
            this.Town.MinWidth = 30;
            this.Town.Name = "Town";
            this.Town.OptionsColumn.ReadOnly = true;
            this.Town.Visible = true;
            this.Town.VisibleIndex = 8;
            this.Town.Width = 154;
            // 
            // Mahalle
            // 
            this.Mahalle.Caption = "Mahalle";
            this.Mahalle.FieldName = "Mahalle";
            this.Mahalle.MinWidth = 30;
            this.Mahalle.Name = "Mahalle";
            this.Mahalle.OptionsColumn.ReadOnly = true;
            this.Mahalle.Visible = true;
            this.Mahalle.VisibleIndex = 9;
            this.Mahalle.Width = 186;
            // 
            // popup_menu
            // 
            this.popup_menu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barbtn_add),
            new DevExpress.XtraBars.LinkPersistInfo(this.barbtn_change),
            new DevExpress.XtraBars.LinkPersistInfo(this.barbtn_look),
            new DevExpress.XtraBars.LinkPersistInfo(this.barbtn_delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barbtn_toplu_sil)});
            this.popup_menu.Manager = this.barManager1;
            this.popup_menu.Name = "popup_menu";
            this.popup_menu.ShowCaption = true;
            // 
            // barbtn_add
            // 
            this.barbtn_add.Caption = "Ekle";
            this.barbtn_add.Id = 0;
            this.barbtn_add.Name = "barbtn_add";
            this.barbtn_add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // barbtn_change
            // 
            this.barbtn_change.Caption = "Değiştir";
            this.barbtn_change.Id = 1;
            this.barbtn_change.Name = "barbtn_change";
            this.barbtn_change.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_change_ItemClick);
            // 
            // barbtn_look
            // 
            this.barbtn_look.Caption = "İncele";
            this.barbtn_look.Id = 2;
            this.barbtn_look.Name = "barbtn_look";
            this.barbtn_look.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_look_ItemClick);
            // 
            // barbtn_delete
            // 
            this.barbtn_delete.Caption = "Sil";
            this.barbtn_delete.Id = 3;
            this.barbtn_delete.Name = "barbtn_delete";
            this.barbtn_delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_delete_ItemClick);
            // 
            // barbtn_toplu_sil
            // 
            this.barbtn_toplu_sil.Caption = "Toplu Sil";
            this.barbtn_toplu_sil.Id = 4;
            this.barbtn_toplu_sil.Name = "barbtn_toplu_sil";
            this.barbtn_toplu_sil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_toplu_sil_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barbtn_add,
            this.barbtn_change,
            this.barbtn_look,
            this.barbtn_delete,
            this.barbtn_toplu_sil});
            this.barManager1.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1527, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 691);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1527, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 691);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1527, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 691);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // portfolios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 691);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gc_filters);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("portfolios.IconOptions.SvgImage")));
            this.Name = "portfolios";
            this.Text = "Portföylerim";
            this.Load += new System.EventHandler(this.portfolios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_filters)).EndInit();
            this.gc_filters.ResumeLayout(false);
            this.gc_filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_endDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_endDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_begDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_begDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_mahalle_get.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_town_get.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popup_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gc_filters;
        private DevExpress.XtraEditors.LabelControl lbl_beg_date;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_mahalle_get;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_town_get;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dt_begDate;
        public DevExpress.XtraEditors.DateEdit dt_endDate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn PortfolioNumber;
        private DevExpress.XtraGrid.Columns.GridColumn PortfolioDate;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn Phone1;
        private DevExpress.XtraGrid.Columns.GridColumn NetTotal;
        private DevExpress.XtraGrid.Columns.GridColumn City;
        private DevExpress.XtraGrid.Columns.GridColumn Town;
        private DevExpress.XtraGrid.Columns.GridColumn Mahalle;
        public DevExpress.XtraEditors.SimpleButton btn_uygula;
        private DevExpress.XtraBars.PopupMenu popup_menu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraBars.BarButtonItem barbtn_add;
        private DevExpress.XtraBars.BarButtonItem barbtn_change;
        private DevExpress.XtraBars.BarButtonItem barbtn_look;
        private DevExpress.XtraBars.BarButtonItem barbtn_delete;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        public DevExpress.XtraEditors.SimpleButton btn_excel_export;
        private DevExpress.XtraGrid.Columns.GridColumn Check;
        private DevExpress.XtraBars.BarButtonItem barbtn_toplu_sil;
    }
}