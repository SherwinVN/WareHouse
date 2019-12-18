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
            this.toolbarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.toolBar = new DevExpress.XtraBars.Bar();
            this.barButtonNew = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gro_content = new Develover.GUI.Controls.DeveloverGroupControl();
            this.gro_information = new Develover.GUI.Controls.DeveloverGroupControl();
            this.tab_information = new Develover.GUI.Controls.DeveloverXtraTabControl();
            this.tbp_general = new DevExpress.XtraTab.XtraTabPage();
            this.gro_general = new Develover.GUI.Controls.DeveloverGroupControl();
            this.txt_id = new Develover.GUI.Controls.DeveloverTextEditCode();
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
            this.gro_search_middle_2 = new Develover.GUI.Controls.DeveloverGroupControl();
            this.pic_picture_search = new Develover.GUI.Controls.DeveloverPictureEdit();
            this.gro_sreach_bottom = new Develover.GUI.Controls.DeveloverGroupControl();
            this.but_view = new Develover.GUI.Controls.DeveloverSimpleButton();
            this.lab_active = new Develover.GUI.Controls.DeveloverLabelControl();
            this.lab_available_search = new Develover.GUI.Controls.DeveloverLabelControl();
            this.chk_show_pricture = new Develover.GUI.Controls.DeveloverCheckEdit();
            this.lab_active_ = new Develover.GUI.Controls.DeveloverLabelControl();
            this.lab_available_search_ = new Develover.GUI.Controls.DeveloverLabelControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toolbarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_content)).BeginInit();
            this.gro_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_information)).BeginInit();
            this.gro_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_information)).BeginInit();
            this.tab_information.SuspendLayout();
            this.tbp_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gro_general)).BeginInit();
            this.gro_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.gro_search_middle_2)).BeginInit();
            this.gro_search_middle_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_picture_search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_sreach_bottom)).BeginInit();
            this.gro_sreach_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_show_pricture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbarManager
            // 
            this.toolbarManager.AllowCustomization = false;
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
            this.barButtonNew,
            this.barButtonEdit,
            this.barButtonCancel,
            this.barButtonDelete});
            this.toolbarManager.MainMenu = this.toolBar;
            this.toolbarManager.MaxItemId = 8;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Caption, this.barButtonNew, "New"),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonCancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonDelete)});
            this.toolBar.OptionsBar.AllowQuickCustomization = false;
            this.toolBar.OptionsBar.DisableCustomization = true;
            this.toolBar.OptionsBar.DrawDragBorder = false;
            this.toolBar.OptionsBar.MultiLine = true;
            this.toolBar.OptionsBar.UseWholeRow = true;
            this.toolBar.Text = "Standard";
            // 
            // barButtonNew
            // 
            this.barButtonNew.Caption = "New";
            this.barButtonNew.Id = 3;
            this.barButtonNew.Name = "barButtonNew";
            this.barButtonNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonNew_ItemClick);
            // 
            // barButtonEdit
            // 
            this.barButtonEdit.Caption = "Edit";
            this.barButtonEdit.Id = 4;
            this.barButtonEdit.Name = "barButtonEdit";
            this.barButtonEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonEdit_ItemClick);
            // 
            // barButtonCancel
            // 
            this.barButtonCancel.Caption = "Cancel";
            this.barButtonCancel.Id = 5;
            this.barButtonCancel.Name = "barButtonCancel";
            this.barButtonCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonCancel_ItemClick);
            // 
            // barButtonDelete
            // 
            this.barButtonDelete.Caption = "Delete";
            this.barButtonDelete.Id = 6;
            this.barButtonDelete.Name = "barButtonDelete";
            this.barButtonDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonDelete_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.toolbarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(838, 22);
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
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.toolbarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 415);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(838, 22);
            this.barDockControlRight.Manager = this.toolbarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 415);
            // 
            // gro_content
            // 
            this.gro_content.Controls.Add(this.gro_information);
            this.gro_content.Controls.Add(this.develoverSplitterControl1);
            this.gro_content.Controls.Add(this.gro_search);
            this.gro_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gro_content.Location = new System.Drawing.Point(0, 22);
            this.gro_content.Name = "gro_content";
            this.gro_content.ShowCaption = false;
            this.gro_content.Size = new System.Drawing.Size(838, 415);
            this.gro_content.TabIndex = 4;
            this.gro_content.Text = "develoverGroupControl2";
            // 
            // gro_information
            // 
            this.gro_information.Controls.Add(this.tab_information);
            this.gro_information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gro_information.Location = new System.Drawing.Point(249, 2);
            this.gro_information.Name = "gro_information";
            this.gro_information.ShowCaption = false;
            this.gro_information.Size = new System.Drawing.Size(587, 411);
            this.gro_information.TabIndex = 0;
            this.gro_information.Text = "develoverGroupControl3";
            // 
            // tab_information
            // 
            this.tab_information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_information.Location = new System.Drawing.Point(2, 2);
            this.tab_information.Name = "tab_information";
            this.tab_information.SelectedTabPage = this.tbp_general;
            this.tab_information.Size = new System.Drawing.Size(583, 407);
            this.tab_information.TabIndex = 0;
            this.tab_information.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tbp_general,
            this.tbp_note});
            // 
            // tbp_general
            // 
            this.tbp_general.Controls.Add(this.gro_general);
            this.tbp_general.Name = "tbp_general";
            this.tbp_general.Size = new System.Drawing.Size(577, 379);
            this.tbp_general.Text = "General";
            // 
            // gro_general
            // 
            this.gro_general.Controls.Add(this.txt_id);
            this.gro_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gro_general.Location = new System.Drawing.Point(0, 0);
            this.gro_general.Name = "gro_general";
            this.gro_general.ShowCaption = false;
            this.gro_general.Size = new System.Drawing.Size(577, 379);
            this.gro_general.TabIndex = 0;
            this.gro_general.Text = "General";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(34, 16);
            this.txt_id.MenuManager = this.toolbarManager;
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 0;
            // 
            // tbp_note
            // 
            this.tbp_note.Controls.Add(this.gro_note);
            this.tbp_note.Name = "tbp_note";
            this.tbp_note.Size = new System.Drawing.Size(577, 379);
            this.tbp_note.Text = "Note";
            // 
            // gro_note
            // 
            this.gro_note.Controls.Add(this.develoverGridControl2);
            this.gro_note.Controls.Add(this.but_delete_note);
            this.gro_note.Controls.Add(this.but_add_note);
            this.gro_note.Controls.Add(this.gro_detail_note);
            this.gro_note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gro_note.Location = new System.Drawing.Point(0, 0);
            this.gro_note.Name = "gro_note";
            this.gro_note.ShowCaption = false;
            this.gro_note.Size = new System.Drawing.Size(577, 379);
            this.gro_note.TabIndex = 2;
            this.gro_note.Text = "develoverGroupControl12";
            // 
            // develoverGridControl2
            // 
            this.develoverGridControl2.Location = new System.Drawing.Point(5, 5);
            this.develoverGridControl2.MainView = this.develoverGridView2;
            this.develoverGridControl2.MenuManager = this.toolbarManager;
            this.develoverGridControl2.Name = "develoverGridControl2";
            this.develoverGridControl2.Size = new System.Drawing.Size(529, 203);
            this.develoverGridControl2.TabIndex = 4;
            this.develoverGridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.develoverGridView2});
            // 
            // develoverGridView2
            // 
            this.develoverGridView2.GridControl = this.develoverGridControl2;
            this.develoverGridView2.Name = "develoverGridView2";
            this.develoverGridView2.OptionsView.ShowGroupPanel = false;
            // 
            // but_delete_note
            // 
            this.but_delete_note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_delete_note.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.but_delete_note.Location = new System.Drawing.Point(540, 37);
            this.but_delete_note.Name = "but_delete_note";
            this.but_delete_note.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.but_delete_note.Size = new System.Drawing.Size(30, 23);
            this.but_delete_note.TabIndex = 2;
            this.but_delete_note.Text = "Del";
            // 
            // but_add_note
            // 
            this.but_add_note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_add_note.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.but_add_note.Location = new System.Drawing.Point(540, 8);
            this.but_add_note.Name = "but_add_note";
            this.but_add_note.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.but_add_note.Size = new System.Drawing.Size(28, 23);
            this.but_add_note.TabIndex = 3;
            this.but_add_note.Text = "Add";
            // 
            // gro_detail_note
            // 
            this.gro_detail_note.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gro_detail_note.Controls.Add(this.mmo_note);
            this.gro_detail_note.Location = new System.Drawing.Point(5, 214);
            this.gro_detail_note.Name = "gro_detail_note";
            this.gro_detail_note.Size = new System.Drawing.Size(565, 158);
            this.gro_detail_note.TabIndex = 0;
            this.gro_detail_note.Text = "Note";
            // 
            // mmo_note
            // 
            this.mmo_note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mmo_note.Location = new System.Drawing.Point(2, 20);
            this.mmo_note.Name = "mmo_note";
            this.mmo_note.Size = new System.Drawing.Size(561, 136);
            this.mmo_note.TabIndex = 0;
            // 
            // develoverSplitterControl1
            // 
            this.develoverSplitterControl1.Location = new System.Drawing.Point(244, 2);
            this.develoverSplitterControl1.MinExtra = 0;
            this.develoverSplitterControl1.MinSize = 0;
            this.develoverSplitterControl1.Name = "develoverSplitterControl1";
            this.develoverSplitterControl1.ShowSplitGlyph = DevExpress.Utils.DefaultBoolean.True;
            this.develoverSplitterControl1.Size = new System.Drawing.Size(5, 411);
            this.develoverSplitterControl1.TabIndex = 1;
            this.develoverSplitterControl1.TabStop = false;
            // 
            // gro_search
            // 
            this.gro_search.Controls.Add(this.gro_search_middle_1);
            this.gro_search.Controls.Add(this.gro_search_middle_2);
            this.gro_search.Controls.Add(this.gro_sreach_bottom);
            this.gro_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.gro_search.Location = new System.Drawing.Point(2, 2);
            this.gro_search.Name = "gro_search";
            this.gro_search.Size = new System.Drawing.Size(242, 411);
            this.gro_search.TabIndex = 0;
            this.gro_search.Text = "Search";
            // 
            // gro_search_middle_1
            // 
            this.gro_search_middle_1.Controls.Add(this.grc_search);
            this.gro_search_middle_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gro_search_middle_1.Location = new System.Drawing.Point(2, 20);
            this.gro_search_middle_1.Name = "gro_search_middle_1";
            this.gro_search_middle_1.ShowCaption = false;
            this.gro_search_middle_1.Size = new System.Drawing.Size(238, 174);
            this.gro_search_middle_1.TabIndex = 0;
            this.gro_search_middle_1.Text = "Search Middle 1";
            // 
            // grc_search
            // 
            this.grc_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc_search.Location = new System.Drawing.Point(2, 2);
            this.grc_search.MainView = this.grv_search;
            this.grc_search.MenuManager = this.toolbarManager;
            this.grc_search.Name = "grc_search";
            this.grc_search.Size = new System.Drawing.Size(234, 170);
            this.grc_search.TabIndex = 0;
            this.grc_search.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_search});
            // 
            // grv_search
            // 
            this.grv_search.GridControl = this.grc_search;
            this.grv_search.Name = "grv_search";
            this.grv_search.OptionsView.ShowGroupPanel = false;
            // 
            // gro_search_middle_2
            // 
            this.gro_search_middle_2.Controls.Add(this.pic_picture_search);
            this.gro_search_middle_2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gro_search_middle_2.Location = new System.Drawing.Point(2, 194);
            this.gro_search_middle_2.Name = "gro_search_middle_2";
            this.gro_search_middle_2.Size = new System.Drawing.Size(238, 126);
            this.gro_search_middle_2.TabIndex = 0;
            this.gro_search_middle_2.Text = "Picture";
            // 
            // pic_picture_search
            // 
            this.pic_picture_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_picture_search.Location = new System.Drawing.Point(2, 20);
            this.pic_picture_search.Name = "pic_picture_search";
            this.pic_picture_search.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_picture_search.Size = new System.Drawing.Size(234, 104);
            this.pic_picture_search.TabIndex = 4;
            // 
            // gro_sreach_bottom
            // 
            this.gro_sreach_bottom.Controls.Add(this.but_view);
            this.gro_sreach_bottom.Controls.Add(this.lab_active);
            this.gro_sreach_bottom.Controls.Add(this.lab_available_search);
            this.gro_sreach_bottom.Controls.Add(this.chk_show_pricture);
            this.gro_sreach_bottom.Controls.Add(this.lab_active_);
            this.gro_sreach_bottom.Controls.Add(this.lab_available_search_);
            this.gro_sreach_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gro_sreach_bottom.Location = new System.Drawing.Point(2, 320);
            this.gro_sreach_bottom.Name = "gro_sreach_bottom";
            this.gro_sreach_bottom.ShowCaption = false;
            this.gro_sreach_bottom.Size = new System.Drawing.Size(238, 89);
            this.gro_sreach_bottom.TabIndex = 0;
            this.gro_sreach_bottom.Text = "Search Bottom";
            // 
            // but_view
            // 
            this.but_view.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_view.Location = new System.Drawing.Point(158, 58);
            this.but_view.Name = "but_view";
            this.but_view.Size = new System.Drawing.Size(75, 23);
            this.but_view.TabIndex = 7;
            this.but_view.Text = "View";
            // 
            // lab_active
            // 
            this.lab_active.Location = new System.Drawing.Point(5, 33);
            this.lab_active.Name = "lab_active";
            this.lab_active.Size = new System.Drawing.Size(34, 13);
            this.lab_active.TabIndex = 6;
            this.lab_active.Text = "Active:";
            // 
            // lab_available_search
            // 
            this.lab_available_search.Location = new System.Drawing.Point(5, 8);
            this.lab_available_search.Name = "lab_available_search";
            this.lab_available_search.Size = new System.Drawing.Size(47, 13);
            this.lab_available_search.TabIndex = 6;
            this.lab_available_search.Text = "Available:";
            // 
            // chk_show_pricture
            // 
            this.chk_show_pricture.Location = new System.Drawing.Point(5, 61);
            this.chk_show_pricture.Name = "chk_show_pricture";
            this.chk_show_pricture.Properties.AutoWidth = true;
            this.chk_show_pricture.Properties.Caption = "Display picture";
            this.chk_show_pricture.Size = new System.Drawing.Size(92, 19);
            this.chk_show_pricture.TabIndex = 4;
            // 
            // lab_active_
            // 
            this.lab_active_.Location = new System.Drawing.Point(51, 33);
            this.lab_active_.Name = "lab_active_";
            this.lab_active_.Size = new System.Drawing.Size(29, 13);
            this.lab_active_.TabIndex = 8;
            this.lab_active_.Text = "active";
            // 
            // lab_available_search_
            // 
            this.lab_available_search_.Location = new System.Drawing.Point(58, 8);
            this.lab_available_search_.Name = "lab_available_search_";
            this.lab_available_search_.Size = new System.Drawing.Size(6, 13);
            this.lab_available_search_.TabIndex = 8;
            this.lab_available_search_.Text = "0";
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
            this.Name = "DeveloverCatalogForm";
            this.Text = "DeveloverCatalogForm";
            ((System.ComponentModel.ISupportInitialize)(this.toolbarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_content)).EndInit();
            this.gro_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gro_information)).EndInit();
            this.gro_information.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab_information)).EndInit();
            this.tab_information.ResumeLayout(false);
            this.tbp_general.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gro_general)).EndInit();
            this.gro_general.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.gro_search_middle_2)).EndInit();
            this.gro_search_middle_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_picture_search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gro_sreach_bottom)).EndInit();
            this.gro_sreach_bottom.ResumeLayout(false);
            this.gro_sreach_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_show_pricture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager toolbarManager;
        private DevExpress.XtraBars.Bar toolBar;
        private DevExpress.XtraBars.BarButtonItem barButtonNew;
        private DevExpress.XtraBars.BarButtonItem barButtonEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonCancel;
        private DevExpress.XtraBars.BarButtonItem barButtonDelete;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private Controls.DeveloverGroupControl gro_content;
        private Controls.DeveloverGroupControl gro_information;
        private Controls.DeveloverXtraTabControl tab_information;
        private DevExpress.XtraTab.XtraTabPage tbp_general;
        private Controls.DeveloverGroupControl gro_general;
        private DevExpress.XtraTab.XtraTabPage tbp_note;
        private Controls.DeveloverGroupControl gro_note;
        private Controls.DeveloverSimpleButton but_delete_note;
        private Controls.DeveloverSimpleButton but_add_note;
        private Controls.DeveloverGroupControl gro_detail_note;
        private Controls.DeveloverMemoEdit mmo_note;
        private Controls.DeveloverSplitterControl develoverSplitterControl1;
        private Controls.DeveloverGroupControl gro_search;
        private Controls.DeveloverGroupControl gro_search_middle_1;
        private Controls.DeveloverGroupControl gro_search_middle_2;
        private Controls.DeveloverPictureEdit pic_picture_search;
        private Controls.DeveloverGroupControl gro_sreach_bottom;
        private Controls.DeveloverSimpleButton but_view;
        private Controls.DeveloverLabelControl lab_active;
        private Controls.DeveloverLabelControl lab_available_search;
        private Controls.DeveloverCheckEdit chk_show_pricture;
        private Controls.DeveloverLabelControl lab_active_;
        private Controls.DeveloverLabelControl lab_available_search_;
        private Controls.DeveloverGridControl develoverGridControl2;
        private Controls.DeveloverGridView develoverGridView2;
        private Controls.DeveloverGridControl grc_search;
        private Controls.DeveloverGridView grv_search;
        private Controls.DeveloverTextEditCode txt_id;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}