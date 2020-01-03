namespace Develover.GUI.Forms
{
    partial class DeveloverVoucherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeveloverVoucherForm));
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
            this.develoverSplitterControl1 = new Develover.GUI.Controls.DeveloverSplitterControl();
            this.gro_search = new Develover.GUI.Controls.DeveloverGroupControl();
            this.gro_search_middle_1 = new Develover.GUI.Controls.DeveloverGroupControl();
            this.grcSearch = new Develover.GUI.Controls.DeveloverGridControl();
            this.grvSearch = new Develover.GUI.Controls.DeveloverGridView();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.tabDetail = new Develover.GUI.Controls.DeveloverXtraTabControl();
            this.tapDetail = new DevExpress.XtraTab.XtraTabPage();
            this.grcDetai = new Develover.GUI.Controls.DeveloverGridControl();
            this.grvDetail = new Develover.GUI.Controls.DeveloverGridView();
            this.repositoryItemCalcEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.groHeader = new Develover.GUI.Controls.DeveloverGroupControl();
            this.develoverSplitterControl2 = new Develover.GUI.Controls.DeveloverSplitterControl();
            this.grbVoucherInfo = new System.Windows.Forms.GroupBox();
            this.txtVoucherNo = new Develover.GUI.Controls.DeveloverTextEdit();
            this.txtDateNo = new Develover.GUI.Controls.DeveloverDateEdit();
            this.develoverLabelControl1 = new Develover.GUI.Controls.DeveloverLabelControl();
            this.develoverLabelControl2 = new Develover.GUI.Controls.DeveloverLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_content)).BeginInit();
            this.gro_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_information)).BeginInit();
            this.gro_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_search)).BeginInit();
            this.gro_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_search_middle_1)).BeginInit();
            this.gro_search_middle_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).BeginInit();
            this.tabDetail.SuspendLayout();
            this.tapDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDetai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groHeader)).BeginInit();
            this.groHeader.SuspendLayout();
            this.grbVoucherInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateNo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateNo.Properties)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(838, 28);
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
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.toolbarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 409);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(838, 28);
            this.barDockControlRight.Manager = this.toolbarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 409);
            // 
            // gro_content
            // 
            this.gro_content.Controls.Add(this.gro_information);
            this.gro_content.Controls.Add(this.develoverSplitterControl1);
            this.gro_content.Controls.Add(this.gro_search);
            this.gro_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gro_content.FieldBinding = null;
            this.gro_content.IsGUID = false;
            this.gro_content.Location = new System.Drawing.Point(0, 28);
            this.gro_content.Name = "gro_content";
            this.gro_content.ShowCaption = false;
            this.gro_content.Size = new System.Drawing.Size(838, 409);
            this.gro_content.TabIndex = 4;
            this.gro_content.Text = "develoverGroupControl2";
            this.gro_content.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // gro_information
            // 
            this.gro_information.Controls.Add(this.tabDetail);
            this.gro_information.Controls.Add(this.groHeader);
            this.gro_information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gro_information.FieldBinding = null;
            this.gro_information.IsGUID = false;
            this.gro_information.Location = new System.Drawing.Point(205, 2);
            this.gro_information.Name = "gro_information";
            this.gro_information.ShowCaption = false;
            this.gro_information.Size = new System.Drawing.Size(631, 405);
            this.gro_information.TabIndex = 0;
            this.gro_information.Text = "develoverGroupControl3";
            this.gro_information.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // develoverSplitterControl1
            // 
            this.develoverSplitterControl1.FieldBinding = null;
            this.develoverSplitterControl1.IsGUID = false;
            this.develoverSplitterControl1.Location = new System.Drawing.Point(195, 2);
            this.develoverSplitterControl1.MinExtra = 0;
            this.develoverSplitterControl1.MinSize = 0;
            this.develoverSplitterControl1.Name = "develoverSplitterControl1";
            this.develoverSplitterControl1.ShowSplitGlyph = DevExpress.Utils.DefaultBoolean.True;
            this.develoverSplitterControl1.Size = new System.Drawing.Size(10, 405);
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
            this.gro_search.Size = new System.Drawing.Size(193, 405);
            this.gro_search.TabIndex = 0;
            this.gro_search.Text = "Tra cứu phiếu";
            this.gro_search.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // gro_search_middle_1
            // 
            this.gro_search_middle_1.Controls.Add(this.grcSearch);
            this.gro_search_middle_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gro_search_middle_1.FieldBinding = null;
            this.gro_search_middle_1.IsGUID = false;
            this.gro_search_middle_1.Location = new System.Drawing.Point(2, 27);
            this.gro_search_middle_1.Name = "gro_search_middle_1";
            this.gro_search_middle_1.ShowCaption = false;
            this.gro_search_middle_1.Size = new System.Drawing.Size(189, 376);
            this.gro_search_middle_1.TabIndex = 0;
            this.gro_search_middle_1.Text = "Search Middle 1";
            this.gro_search_middle_1.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // grcSearch
            // 
            this.grcSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcSearch.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grcSearch.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grcSearch.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grcSearch.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grcSearch.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grcSearch.FieldBinding = null;
            this.grcSearch.IsGUID = false;
            this.grcSearch.Location = new System.Drawing.Point(2, 2);
            this.grcSearch.MainView = this.grvSearch;
            this.grcSearch.MenuManager = this.toolbarManager;
            this.grcSearch.Name = "grcSearch";
            this.grcSearch.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1});
            this.grcSearch.Size = new System.Drawing.Size(185, 372);
            this.grcSearch.TabIndex = 0;
            this.grcSearch.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            this.grcSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvSearch});
            // 
            // grvSearch
            // 
            this.grvSearch.FieldBinding = null;
            this.grvSearch.GridControl = this.grcSearch;
            this.grvSearch.IndicatorWidth = 40;
            this.grvSearch.IsGUID = false;
            this.grvSearch.Name = "grvSearch";
            this.grvSearch.OptionsBehavior.AllowIncrementalSearch = true;
            this.grvSearch.OptionsBehavior.SmartVertScrollBar = false;
            this.grvSearch.OptionsView.ShowFooter = true;
            this.grvSearch.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            this.grvSearch.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grv_search_FocusedRowChanged);
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // tabDetail
            // 
            this.tabDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDetail.FieldBinding = null;
            this.tabDetail.IsGUID = false;
            this.tabDetail.Location = new System.Drawing.Point(2, 196);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.SelectedTabPage = this.tapDetail;
            this.tabDetail.Size = new System.Drawing.Size(627, 207);
            this.tabDetail.TabIndex = 5;
            this.tabDetail.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tapDetail});
            this.tabDetail.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // tapDetail
            // 
            this.tapDetail.Controls.Add(this.grcDetai);
            this.tapDetail.Name = "tapDetail";
            this.tapDetail.Size = new System.Drawing.Size(625, 178);
            this.tapDetail.Text = "Hàng hóa";
            // 
            // grcDetai
            // 
            this.grcDetai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDetai.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grcDetai.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grcDetai.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grcDetai.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grcDetai.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grcDetai.FieldBinding = null;
            this.grcDetai.IsGUID = false;
            this.grcDetai.Location = new System.Drawing.Point(0, 0);
            this.grcDetai.MainView = this.grvDetail;
            this.grcDetai.MenuManager = this.toolbarManager;
            this.grcDetai.Name = "grcDetai";
            this.grcDetai.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit2});
            this.grcDetai.Size = new System.Drawing.Size(625, 178);
            this.grcDetai.TabIndex = 2;
            this.grcDetai.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            this.grcDetai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDetail});
            // 
            // grvDetail
            // 
            this.grvDetail.FieldBinding = null;
            this.grvDetail.GridControl = this.grcDetai;
            this.grvDetail.IndicatorWidth = 40;
            this.grvDetail.IsGUID = false;
            this.grvDetail.Name = "grvDetail";
            this.grvDetail.OptionsBehavior.AllowIncrementalSearch = true;
            this.grvDetail.OptionsBehavior.SmartVertScrollBar = false;
            this.grvDetail.OptionsView.ShowFooter = true;
            this.grvDetail.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // repositoryItemCalcEdit2
            // 
            this.repositoryItemCalcEdit2.AutoHeight = false;
            this.repositoryItemCalcEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit2.Name = "repositoryItemCalcEdit2";
            // 
            // groHeader
            // 
            this.groHeader.AppearanceCaption.Options.UseTextOptions = true;
            this.groHeader.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groHeader.Controls.Add(this.grbVoucherInfo);
            this.groHeader.Controls.Add(this.develoverSplitterControl2);
            this.groHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.groHeader.FieldBinding = null;
            this.groHeader.IsGUID = false;
            this.groHeader.Location = new System.Drawing.Point(2, 2);
            this.groHeader.Name = "groHeader";
            this.groHeader.Size = new System.Drawing.Size(627, 194);
            this.groHeader.TabIndex = 4;
            this.groHeader.Text = "Thông tin chung";
            this.groHeader.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // develoverSplitterControl2
            // 
            this.develoverSplitterControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.develoverSplitterControl2.FieldBinding = null;
            this.develoverSplitterControl2.IsGUID = false;
            this.develoverSplitterControl2.Location = new System.Drawing.Point(2, 182);
            this.develoverSplitterControl2.MinExtra = 0;
            this.develoverSplitterControl2.MinSize = 0;
            this.develoverSplitterControl2.Name = "develoverSplitterControl2";
            this.develoverSplitterControl2.ShowSplitGlyph = DevExpress.Utils.DefaultBoolean.True;
            this.develoverSplitterControl2.Size = new System.Drawing.Size(623, 10);
            this.develoverSplitterControl2.TabIndex = 0;
            this.develoverSplitterControl2.TabStop = false;
            this.develoverSplitterControl2.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // grbVoucherInfo
            // 
            this.grbVoucherInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbVoucherInfo.Controls.Add(this.develoverLabelControl2);
            this.grbVoucherInfo.Controls.Add(this.develoverLabelControl1);
            this.grbVoucherInfo.Controls.Add(this.txtDateNo);
            this.grbVoucherInfo.Controls.Add(this.txtVoucherNo);
            this.grbVoucherInfo.Location = new System.Drawing.Point(419, 30);
            this.grbVoucherInfo.Name = "grbVoucherInfo";
            this.grbVoucherInfo.Size = new System.Drawing.Size(200, 72);
            this.grbVoucherInfo.TabIndex = 1;
            this.grbVoucherInfo.TabStop = false;
            this.grbVoucherInfo.Text = "Thông tin chứng từ";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.FieldBinding = null;
            this.txtVoucherNo.IsGUID = false;
            this.txtVoucherNo.Location = new System.Drawing.Point(94, 20);
            this.txtVoucherNo.MenuManager = this.toolbarManager;
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(100, 20);
            this.txtVoucherNo.TabIndex = 2;
            this.txtVoucherNo.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // txtDateNo
            // 
            this.txtDateNo.EditValue = null;
            this.txtDateNo.FieldBinding = null;
            this.txtDateNo.IsGUID = false;
            this.txtDateNo.Location = new System.Drawing.Point(94, 43);
            this.txtDateNo.MenuManager = this.toolbarManager;
            this.txtDateNo.Name = "txtDateNo";
            this.txtDateNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateNo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateNo.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Space);
            this.txtDateNo.Size = new System.Drawing.Size(100, 20);
            this.txtDateNo.TabIndex = 3;
            this.txtDateNo.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // develoverLabelControl1
            // 
            this.develoverLabelControl1.FieldBinding = null;
            this.develoverLabelControl1.IsGUID = false;
            this.develoverLabelControl1.Location = new System.Drawing.Point(7, 20);
            this.develoverLabelControl1.Name = "develoverLabelControl1";
            this.develoverLabelControl1.Size = new System.Drawing.Size(59, 13);
            this.develoverLabelControl1.TabIndex = 4;
            this.develoverLabelControl1.Text = "Số chứng từ";
            this.develoverLabelControl1.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // develoverLabelControl2
            // 
            this.develoverLabelControl2.FieldBinding = null;
            this.develoverLabelControl2.IsGUID = false;
            this.develoverLabelControl2.Location = new System.Drawing.Point(7, 43);
            this.develoverLabelControl2.Name = "develoverLabelControl2";
            this.develoverLabelControl2.Size = new System.Drawing.Size(72, 13);
            this.develoverLabelControl2.TabIndex = 4;
            this.develoverLabelControl2.Text = "Ngày chứng từ";
            this.develoverLabelControl2.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // DeveloverVoucherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 437);
            this.Controls.Add(this.gro_content);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeveloverVoucherForm.IconOptions.Image")));
            this.Name = "DeveloverVoucherForm";
            this.Text = "DeveloverCatalogForm";
            this.Load += new System.EventHandler(this.DeveloverCatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolbarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_content)).EndInit();
            this.gro_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gro_information)).EndInit();
            this.gro_information.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gro_search)).EndInit();
            this.gro_search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gro_search_middle_1)).EndInit();
            this.gro_search_middle_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).EndInit();
            this.tabDetail.ResumeLayout(false);
            this.tapDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcDetai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groHeader)).EndInit();
            this.groHeader.ResumeLayout(false);
            this.grbVoucherInfo.ResumeLayout(false);
            this.grbVoucherInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateNo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateNo.Properties)).EndInit();
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
        private Controls.DeveloverGroupControl gro_search_middle_1;
        private Controls.DeveloverGridView grvSearch;
        private DevExpress.XtraBars.BarButtonItem BarButtonNew;
        private DevExpress.XtraBars.BarButtonItem barButtonPrint;
        public Controls.DeveloverSplitterControl develoverSplitterControl1;
        public Controls.DeveloverGroupControl gro_search;
        public Controls.DeveloverGridControl grcSearch;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private Controls.DeveloverXtraTabControl tabDetail;
        private DevExpress.XtraTab.XtraTabPage tapDetail;
        public Controls.DeveloverGridControl grcDetai;
        private Controls.DeveloverGridView grvDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit2;
        private Controls.DeveloverGroupControl groHeader;
        private Controls.DeveloverSplitterControl develoverSplitterControl2;
        private System.Windows.Forms.GroupBox grbVoucherInfo;
        private Controls.DeveloverDateEdit txtDateNo;
        private Controls.DeveloverTextEdit txtVoucherNo;
        private Controls.DeveloverLabelControl develoverLabelControl2;
        private Controls.DeveloverLabelControl develoverLabelControl1;
    }
}