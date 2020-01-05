namespace Develover.GUI.Forms
{
    partial class DeveloverCatalogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeveloverCatalogForm));
            this.toolbarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.toolBar = new DevExpress.XtraBars.Bar();
            this.BarButtonNew = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gro_content = new Develover.GUI.Controls.DeveloverGroupControl();
            this.gro_information = new Develover.GUI.Controls.DeveloverGroupControl();
            this.tab_information = new Develover.GUI.Controls.DeveloverXtraTabControl();
            this.tbp_general = new DevExpress.XtraTab.XtraTabPage();
            this.gro_general = new Develover.GUI.Controls.DeveloverGroupControl();
            this.tbp_note = new DevExpress.XtraTab.XtraTabPage();
            this.gro_note = new Develover.GUI.Controls.DeveloverGroupControl();
            this.develoverGridControl2 = new Develover.GUI.Controls.DeveloverGridControl();
            this.develoverGridView2 = new Develover.GUI.Controls.DeveloverGridView();
            this.but_delete_note = new Develover.GUI.Controls.DeveloverSimpleButton();
            this.but_add_note = new Develover.GUI.Controls.DeveloverSimpleButton();
            this.gro_detail_note = new Develover.GUI.Controls.DeveloverGroupControl();
            this.mmo_note = new Develover.GUI.Controls.DeveloverMemoEdit();
            this.develoverSplitterControl1 = new Develover.GUI.Controls.DeveloverSplitterControl();
            this.gro_search = new Develover.GUI.Controls.DeveloverGroupControl();
            this.gro_search_middle_1 = new Develover.GUI.Controls.DeveloverGroupControl();
            this.grc_search = new Develover.GUI.Controls.DeveloverGridControl();
            this.grv_search = new Develover.GUI.Controls.DeveloverGridView();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_content)).BeginInit();
            this.gro_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_information)).BeginInit();
            this.gro_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_information)).BeginInit();
            this.tab_information.SuspendLayout();
            this.tbp_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_general)).BeginInit();
            this.tbp_note.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_note)).BeginInit();
            this.gro_note.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.develoverGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.develoverGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_detail_note)).BeginInit();
            this.gro_detail_note.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmo_note.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_search)).BeginInit();
            this.gro_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_search_middle_1)).BeginInit();
            this.gro_search_middle_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbarManager
            // 
            this.toolbarManager.AllowCustomization = false;
            this.toolbarManager.AllowMdiChildButtons = false;
            this.toolbarManager.AllowMoveBarOnToolbar = false;
            this.toolbarManager.AllowQuickCustomization = false;
            this.toolbarManager.AllowShowToolbarsPopup = false;
            this.toolbarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.toolBar});
            this.toolbarManager.DockControls.Add(this.barDockControlTop);
            this.toolbarManager.DockControls.Add(this.barDockControlBottom);
            this.toolbarManager.DockControls.Add(this.barDockControlLeft);
            this.toolbarManager.DockControls.Add(this.barDockControlRight);
            this.toolbarManager.Form = this;
            this.toolbarManager.HideBarsWhenMerging = false;
            this.toolbarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonEdit,
            this.barButtonCancel,
            this.barButtonDelete,
            this.BarButtonNew,
            this.barButtonPrint});
            this.toolbarManager.MainMenu = this.toolBar;
            this.toolbarManager.MaxItemId = 10;
            // 
            // toolBar
            // 
            this.toolBar.BarName = "Standard";
            this.toolBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.toolBar.DockCol = 0;
            this.toolBar.DockRow = 0;
            this.toolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.toolBar.HideWhenMerging = DevExpress.Utils.DefaultBoolean.True;
            this.toolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BarButtonNew, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonCancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonDelete),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonPrint, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.toolBar.OptionsBar.AllowQuickCustomization = false;
            this.toolBar.OptionsBar.DisableCustomization = true;
            this.toolBar.OptionsBar.DrawDragBorder = false;
            this.toolBar.OptionsBar.MultiLine = true;
            this.toolBar.OptionsBar.UseWholeRow = true;
            this.toolBar.Text = "Standard";
            // 
            // BarButtonNew
            // 
            this.BarButtonNew.Caption = "Thêm";
            this.BarButtonNew.Id = 8;
            this.BarButtonNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BarButtonNew.ImageOptions.SvgImage")));
            this.BarButtonNew.Name = "BarButtonNew";
            this.BarButtonNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonNew_ItemClick);
            // 
            // barButtonEdit
            // 
            this.barButtonEdit.Caption = "Sửa";
            this.barButtonEdit.Id = 4;
            this.barButtonEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonEdit.ImageOptions.SvgImage")));
            this.barButtonEdit.Name = "barButtonEdit";
            this.barButtonEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonEdit_ItemClick);
            // 
            // barButtonCancel
            // 
            this.barButtonCancel.Caption = "Hủy";
            this.barButtonCancel.Id = 5;
            this.barButtonCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonCancel.ImageOptions.SvgImage")));
            this.barButtonCancel.Name = "barButtonCancel";
            this.barButtonCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonCancel_ItemClick);
            // 
            // barButtonDelete
            // 
            this.barButtonDelete.Caption = "Xóa";
            this.barButtonDelete.Id = 6;
            this.barButtonDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonDelete.ImageOptions.SvgImage")));
            this.barButtonDelete.Name = "barButtonDelete";
            this.barButtonDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonDelete_ItemClick);
            // 
            // barButtonPrint
            // 
            this.barButtonPrint.Caption = "In";
            this.barButtonPrint.Id = 9;
            this.barButtonPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonPrint.ImageOptions.SvgImage")));
            this.barButtonPrint.Name = "barButtonPrint";
            this.barButtonPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPrint_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.toolbarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(838, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 437);
            this.barDockControlBottom.Manager = this.toolbarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(838, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.toolbarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 413);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(838, 24);
            this.barDockControlRight.Manager = this.toolbarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 413);
            // 
            // gro_content
            // 
            this.gro_content.Controls.Add(this.gro_information);
            this.gro_content.Controls.Add(this.develoverSplitterControl1);
            this.gro_content.Controls.Add(this.gro_search);
            this.gro_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gro_content.FieldBinding = null;
            this.gro_content.IsGUID = false;
            this.gro_content.Location = new System.Drawing.Point(0, 24);
            this.gro_content.Name = "gro_content";
            this.gro_content.ShowCaption = false;
            this.gro_content.Size = new System.Drawing.Size(838, 413);
            this.gro_content.TabIndex = 4;
            this.gro_content.Text = "develoverGroupControl2";
            this.gro_content.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // gro_information
            // 
            this.gro_information.Controls.Add(this.tab_information);
            this.gro_information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gro_information.FieldBinding = null;
            this.gro_information.IsGUID = false;
            this.gro_information.Location = new System.Drawing.Point(254, 2);
            this.gro_information.Name = "gro_information";
            this.gro_information.ShowCaption = false;
            this.gro_information.Size = new System.Drawing.Size(582, 409);
            this.gro_information.TabIndex = 0;
            this.gro_information.Text = "develoverGroupControl3";
            this.gro_information.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // tab_information
            // 
            this.tab_information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_information.FieldBinding = null;
            this.tab_information.IsGUID = false;
            this.tab_information.Location = new System.Drawing.Point(2, 2);
            this.tab_information.Name = "tab_information";
            this.tab_information.SelectedTabPage = this.tbp_general;
            this.tab_information.Size = new System.Drawing.Size(578, 405);
            this.tab_information.TabIndex = 0;
            this.tab_information.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tbp_general,
            this.tbp_note});
            this.tab_information.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // tbp_general
            // 
            this.tbp_general.Controls.Add(this.gro_general);
            this.tbp_general.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tbp_general.ImageOptions.SvgImage")));
            this.tbp_general.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.tbp_general.Name = "tbp_general";
            this.tbp_general.Size = new System.Drawing.Size(576, 377);
            this.tbp_general.Text = "Thông tin";
            // 
            // gro_general
            // 
            this.gro_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gro_general.FieldBinding = null;
            this.gro_general.IsGUID = false;
            this.gro_general.Location = new System.Drawing.Point(0, 0);
            this.gro_general.Name = "gro_general";
            this.gro_general.ShowCaption = false;
            this.gro_general.Size = new System.Drawing.Size(576, 377);
            this.gro_general.TabIndex = 0;
            this.gro_general.Text = "General";
            this.gro_general.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // tbp_note
            // 
            this.tbp_note.Controls.Add(this.gro_note);
            this.tbp_note.Name = "tbp_note";
            this.tbp_note.PageVisible = false;
            this.tbp_note.Size = new System.Drawing.Size(576, 373);
            this.tbp_note.Text = "Note";
            // 
            // gro_note
            // 
            this.gro_note.Controls.Add(this.develoverGridControl2);
            this.gro_note.Controls.Add(this.but_delete_note);
            this.gro_note.Controls.Add(this.but_add_note);
            this.gro_note.Controls.Add(this.gro_detail_note);
            this.gro_note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gro_note.FieldBinding = null;
            this.gro_note.IsGUID = false;
            this.gro_note.Location = new System.Drawing.Point(0, 0);
            this.gro_note.Name = "gro_note";
            this.gro_note.ShowCaption = false;
            this.gro_note.Size = new System.Drawing.Size(576, 373);
            this.gro_note.TabIndex = 2;
            this.gro_note.Text = "develoverGroupControl12";
            this.gro_note.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // develoverGridControl2
            // 
            this.develoverGridControl2.FieldBinding = null;
            this.develoverGridControl2.IsGUID = false;
            this.develoverGridControl2.Location = new System.Drawing.Point(5, 5);
            this.develoverGridControl2.MainView = this.develoverGridView2;
            this.develoverGridControl2.MenuManager = this.toolbarManager;
            this.develoverGridControl2.Name = "develoverGridControl2";
            this.develoverGridControl2.Size = new System.Drawing.Size(529, 203);
            this.develoverGridControl2.TabIndex = 4;
            this.develoverGridControl2.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            this.develoverGridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.develoverGridView2});
            // 
            // develoverGridView2
            // 
            this.develoverGridView2.FieldBinding = null;
            this.develoverGridView2.GridControl = this.develoverGridControl2;
            this.develoverGridView2.IndicatorWidth = 40;
            this.develoverGridView2.IsGUID = false;
            this.develoverGridView2.Name = "develoverGridView2";
            this.develoverGridView2.OptionsView.ShowGroupPanel = false;
            this.develoverGridView2.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // but_delete_note
            // 
            this.but_delete_note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_delete_note.FieldBinding = null;
            this.but_delete_note.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.but_delete_note.IsGUID = false;
            this.but_delete_note.Location = new System.Drawing.Point(549, 37);
            this.but_delete_note.Name = "but_delete_note";
            this.but_delete_note.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.but_delete_note.Size = new System.Drawing.Size(30, 23);
            this.but_delete_note.TabIndex = 2;
            this.but_delete_note.Text = "Del";
            this.but_delete_note.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // but_add_note
            // 
            this.but_add_note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_add_note.FieldBinding = null;
            this.but_add_note.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.but_add_note.IsGUID = false;
            this.but_add_note.Location = new System.Drawing.Point(549, 8);
            this.but_add_note.Name = "but_add_note";
            this.but_add_note.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.but_add_note.Size = new System.Drawing.Size(28, 23);
            this.but_add_note.TabIndex = 3;
            this.but_add_note.Text = "Add";
            this.but_add_note.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // gro_detail_note
            // 
            this.gro_detail_note.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gro_detail_note.Controls.Add(this.mmo_note);
            this.gro_detail_note.FieldBinding = null;
            this.gro_detail_note.IsGUID = false;
            this.gro_detail_note.Location = new System.Drawing.Point(5, 214);
            this.gro_detail_note.Name = "gro_detail_note";
            this.gro_detail_note.Size = new System.Drawing.Size(574, 152);
            this.gro_detail_note.TabIndex = 0;
            this.gro_detail_note.Text = "Note";
            this.gro_detail_note.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // mmo_note
            // 
            this.mmo_note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mmo_note.FieldBinding = null;
            this.mmo_note.IsGUID = false;
            this.mmo_note.Location = new System.Drawing.Point(2, 23);
            this.mmo_note.Name = "mmo_note";
            this.mmo_note.Size = new System.Drawing.Size(570, 127);
            this.mmo_note.TabIndex = 0;
            this.mmo_note.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // develoverSplitterControl1
            // 
            this.develoverSplitterControl1.FieldBinding = null;
            this.develoverSplitterControl1.IsGUID = false;
            this.develoverSplitterControl1.Location = new System.Drawing.Point(244, 2);
            this.develoverSplitterControl1.MinExtra = 0;
            this.develoverSplitterControl1.MinSize = 0;
            this.develoverSplitterControl1.Name = "develoverSplitterControl1";
            this.develoverSplitterControl1.ShowSplitGlyph = DevExpress.Utils.DefaultBoolean.True;
            this.develoverSplitterControl1.Size = new System.Drawing.Size(10, 409);
            this.develoverSplitterControl1.TabIndex = 1;
            this.develoverSplitterControl1.TabStop = false;
            this.develoverSplitterControl1.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // gro_search
            // 
            this.gro_search.Controls.Add(this.gro_search_middle_1);
            this.gro_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.gro_search.FieldBinding = null;
            this.gro_search.IsGUID = false;
            this.gro_search.Location = new System.Drawing.Point(2, 2);
            this.gro_search.Name = "gro_search";
            this.gro_search.Size = new System.Drawing.Size(242, 409);
            this.gro_search.TabIndex = 0;
            this.gro_search.Text = "Tìm kiếm";
            this.gro_search.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // gro_search_middle_1
            // 
            this.gro_search_middle_1.Controls.Add(this.grc_search);
            this.gro_search_middle_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gro_search_middle_1.FieldBinding = null;
            this.gro_search_middle_1.IsGUID = false;
            this.gro_search_middle_1.Location = new System.Drawing.Point(2, 23);
            this.gro_search_middle_1.Name = "gro_search_middle_1";
            this.gro_search_middle_1.ShowCaption = false;
            this.gro_search_middle_1.Size = new System.Drawing.Size(238, 384);
            this.gro_search_middle_1.TabIndex = 0;
            this.gro_search_middle_1.Text = "Search Middle 1";
            this.gro_search_middle_1.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // grc_search
            // 
            this.grc_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc_search.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grc_search.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grc_search.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grc_search.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grc_search.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grc_search.FieldBinding = null;
            this.grc_search.IsGUID = false;
            this.grc_search.Location = new System.Drawing.Point(2, 2);
            this.grc_search.MainView = this.grv_search;
            this.grc_search.MenuManager = this.toolbarManager;
            this.grc_search.Name = "grc_search";
            this.grc_search.Size = new System.Drawing.Size(234, 380);
            this.grc_search.TabIndex = 0;
            this.grc_search.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            this.grc_search.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_search});
            // 
            // grv_search
            // 
            this.grv_search.FieldBinding = null;
            this.grv_search.GridControl = this.grc_search;
            this.grv_search.IndicatorWidth = 40;
            this.grv_search.IsGUID = false;
            this.grv_search.Name = "grv_search";
            this.grv_search.OptionsBehavior.AllowIncrementalSearch = true;
            this.grv_search.OptionsBehavior.SmartVertScrollBar = false;
            this.grv_search.OptionsView.ShowFooter = true;
            this.grv_search.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            this.grv_search.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grv_search_FocusedRowChanged);
            // 
            // DeveloverCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 437);
            this.Controls.Add(this.gro_content);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeveloverCatalogForm.IconOptions.Image")));
            this.Name = "DeveloverCatalogForm";
            this.Text = "DeveloverCatalogForm";
            this.Load += new System.EventHandler(this.DeveloverCatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolbarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_content)).EndInit();
            this.gro_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gro_information)).EndInit();
            this.gro_information.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab_information)).EndInit();
            this.tab_information.ResumeLayout(false);
            this.tbp_general.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gro_general)).EndInit();
            this.tbp_note.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gro_note)).EndInit();
            this.gro_note.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.develoverGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.develoverGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_detail_note)).EndInit();
            this.gro_detail_note.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mmo_note.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_search)).EndInit();
            this.gro_search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gro_search_middle_1)).EndInit();
            this.gro_search_middle_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grc_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager toolbarManager;
        private DevExpress.XtraBars.Bar toolBar;
        private DevExpress.XtraBars.BarButtonItem barButtonEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonCancel;
        private DevExpress.XtraBars.BarButtonItem barButtonDelete;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private Controls.DeveloverGroupControl gro_content;
        private Controls.DeveloverGroupControl gro_information;
        private DevExpress.XtraTab.XtraTabPage tbp_general;
        private DevExpress.XtraTab.XtraTabPage tbp_note;
        private Controls.DeveloverGroupControl gro_note;
        private Controls.DeveloverSimpleButton but_delete_note;
        private Controls.DeveloverSimpleButton but_add_note;
        private Controls.DeveloverGroupControl gro_detail_note;
        private Controls.DeveloverMemoEdit mmo_note;
        private Controls.DeveloverGroupControl gro_search_middle_1;
        private Controls.DeveloverGridControl develoverGridControl2;
        private Controls.DeveloverGridView develoverGridView2;
        private Controls.DeveloverGridView grv_search;
        private DevExpress.XtraBars.BarButtonItem BarButtonNew;
        private DevExpress.XtraBars.BarButtonItem barButtonPrint;
        public Controls.DeveloverSplitterControl develoverSplitterControl1;
        public Controls.DeveloverGridControl grc_search;
        protected Controls.DeveloverXtraTabControl tab_information;
        protected Controls.DeveloverGroupControl gro_general;
        protected Controls.DeveloverGroupControl gro_search;
    }
}