using Develover.GUI.RepositoryItems;
using Develover.Utilities;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ColorPick.Picker;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using static Develover.GUI.Controls.DeveloverGridControl;
using static Develover.Utilities.DelTypeData;
using static Develover.Utilities.Enum;

namespace Develover.GUI.Controls
{
    public partial class DeveloverGridView : GridView, IDeveloverControl
    {
        string fieldBinding;
        bool isGUID;
        EnumTypeColumns typeFieldColumns;
        public string FieldBinding { get => fieldBinding; set => fieldBinding = value; }
        public EnumTypeColumns TypeFieldColumns { get => typeFieldColumns; set => typeFieldColumns = value; }
        public bool IsGUID { get => isGUID; set => isGUID = value; }

        public DeveloverGridView() : this(null) { }

        public DeveloverGridView(GridControl grid) : base(grid)
        {
            this.OptionsView.ShowGroupPanel = false;
            this.OptionsView.ColumnAutoWidth = false;
            this.OptionsSelection.MultiSelect = true;
            this.IndicatorWidth = 40;
            this.CustomDrawRowIndicator += DeveloverGridView_CustomDrawRowIndicator;
            this.PopupMenuShowing += DeveloverGridView_PopupMenuShowing;
        }

        private void DeveloverGridView_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        protected override string ViewName { get { return "DeveloverGridView"; } }

        public void BuidColumns(List<TypeColumns> typeColumns)
        {
            Columns.Clear();
            this.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            this.OptionsView.ShowGroupPanel = false;
            this.OptionsNavigation.AutoFocusNewRow = true;
            this.OptionsNavigation.EnterMoveNextColumn = true;
            this.OptionsBehavior.AutoUpdateTotalSummary = true;
            this.OptionsBehavior.AutoSelectAllInEditor = false;
            this.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.NewItemRowText = StringMessage.NewItemRowText;


            GridColumn gridColumn;
            foreach (TypeColumns typeColumns_ in typeColumns)
            {
                gridColumn = new GridColumn();
                gridColumn.Name = typeColumns_.Name;
                gridColumn.FieldName = typeColumns_.FieldName;
                gridColumn.Caption = typeColumns_.Caption;
                gridColumn.Width = typeColumns_.Width;
                gridColumn.VisibleIndex = typeColumns_.Index;
                gridColumn.OptionsColumn.AllowFocus = typeColumns_.AllowFocus;
                gridColumn.OptionsColumn.AllowEdit = typeColumns_.AllowEdit;
                gridColumn.Visible = typeColumns_.Visible;

                gridColumn.SummaryItem.SummaryType = GetSummaryItemType(typeColumns_.SumaryType);
                if (typeColumns_.SumaryType != SumaryType.None)
                {
                    this.OptionsView.ShowFooter = true;
                }
                gridColumn.SummaryItem.DisplayFormat = typeColumns_.StringFormat;
                gridColumn.SummaryItem.FieldName = typeColumns_.FieldName;

                GetTypeColumn(ref gridColumn, typeColumns_.TypeColumn, typeColumns_.SQLData, typeColumns_.Model, typeColumns_.KeyMember, typeColumns_.ValueMember, typeColumns_.DisplayMember, typeColumns_.NullText);
                Columns.Add(gridColumn);
            }
        }

        public void BuidColumnsView(List<TypeColumns> typeColumns)
        {
            Columns.Clear();
            this.OptionsFind.AlwaysVisible = true;
            this.OptionsFind.ClearFindOnClose = true;
            this.OptionsFind.ShowClearButton = true;
            this.OptionsFind.ShowCloseButton = true;
            this.OptionsFind.SearchInPreview = true;
            this.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.OptionsFind.FindNullPrompt = StringMessage.TextFindFilter;
            this.OptionsView.ShowAutoFilterRow = true;
            this.OptionsView.ShowGroupPanel = false;
            this.GroupPanelText = StringMessage.GroupPanelText;

            this.OptionsBehavior.AutoUpdateTotalSummary = true;
            this.OptionsBehavior.AutoSelectAllInEditor = false;

            GridColumn gridColumn;
            foreach (TypeColumns typeColumns_ in typeColumns)
            {
                gridColumn = new GridColumn();
                gridColumn.Name = typeColumns_.Name;
                gridColumn.FieldName = typeColumns_.FieldName;
                gridColumn.Caption = typeColumns_.Caption;
                gridColumn.Width = typeColumns_.Width;
                gridColumn.VisibleIndex = typeColumns_.Index;
                gridColumn.OptionsColumn.AllowFocus = false;
                gridColumn.OptionsColumn.AllowEdit = false;
                gridColumn.Visible = typeColumns_.Visible;

                gridColumn.SummaryItem.SummaryType = GetSummaryItemType(typeColumns_.SumaryType);
                if (typeColumns_.SumaryType != SumaryType.None)
                {
                    this.OptionsView.ShowFooter = true;
                }
                gridColumn.SummaryItem.DisplayFormat = typeColumns_.StringFormat;
                gridColumn.SummaryItem.FieldName = typeColumns_.FieldName;

                //GetTypeColumn(ref gridColumn, typeColumns_.TypeColumn == EnumTypeColumns.Gridlookup || typeColumns_.TypeColumn == EnumTypeColumns.Combobox ? EnumTypeColumns.Text : typeColumns_.TypeColumn, typeColumns_.SQLData, typeColumns_.Model, typeColumns_.KeyMember, typeColumns_.ValueMember, typeColumns_.DisplayMember, typeColumns_.NullText);
                GetTypeColumn(ref gridColumn, typeColumns_.TypeColumn, typeColumns_.SQLData, typeColumns_.Model, typeColumns_.KeyMember, typeColumns_.ValueMember, typeColumns_.DisplayMember, typeColumns_.NullText);
                Columns.Add(gridColumn);
            }
        }

        private void GetTypeColumn(ref GridColumn gridColumn, EnumTypeColumns enumTypeColumns, string SQLData, string model, string KeyMember, string ValueMember, string DisplayMember, string NullText)
        {
            switch (enumTypeColumns)
            {
                case EnumTypeColumns.Number:
                    gridColumn.ColumnEdit = new DeveloverRepositoryItemCalcEdit();
                    break;

                case EnumTypeColumns.Check:
                    gridColumn.ColumnEdit = new DeveloverRepositoryItemCheckEdit();
                    break;
                case EnumTypeColumns.Combobox:
                    DeveloverRepositoryItemComboBox develoverRepositoryItemComboBox = new DeveloverRepositoryItemComboBox();
                    develoverRepositoryItemComboBox.LoadData(SQLData, false, 0);
                    gridColumn.ColumnEdit = develoverRepositoryItemComboBox;
                    break;
                case EnumTypeColumns.Date:
                    gridColumn.ColumnEdit = new DeveloverRepositoryItemDateEdit();
                    break;
                case EnumTypeColumns.Gridlookup:
                    DeveloverRepositoryItemGridLookUpEdit develoverRepositoryItemGridLookUpEdit = new DeveloverRepositoryItemGridLookUpEdit();
                    develoverRepositoryItemGridLookUpEdit.LoadData(SQLData, model, KeyMember, ValueMember, DisplayMember, NullText);
                    gridColumn.ColumnEdit = develoverRepositoryItemGridLookUpEdit;
                    break;
                case EnumTypeColumns.Text:
                    gridColumn.ColumnEdit = new DeveloverRepositoryItemTextEdit();
                    break;
                case EnumTypeColumns.Time:
                    gridColumn.ColumnEdit = new DeveloverRepositoryItemTimeEdit();
                    break;
            }
        }


        private void DeveloverGridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Column)
            {
                GridViewColumnMenu menu = e.Menu as GridViewColumnMenu;
                //menu.Items.Clear();
                if (menu.Column != null)
                {
                    // font chữ

                    DXMenuCheckItem font = new DXMenuCheckItem("Font chữ", true, null, new EventHandler(OnFixedClick));
                    font.Tag = new MenuInfo(menu.Column, FixedStyle.None);
                    menu.Items.Add(font);


                    // Màu nền
                    DXSubMenuItem sItem = new DXSubMenuItem("Màu nền");
                    Color mauhong = ColorTranslator.FromHtml("#FFC2BE");
                    Color mauxanh = ColorTranslator.FromHtml("#A8D5FF");
                    Color xanhduong = ColorTranslator.FromHtml("#C1F49C");
                    Color mauvang = ColorTranslator.FromHtml("#FEF7A5");
                    Color mautim = ColorTranslator.FromHtml("#E0CFE9");
                    Color xanhlam = ColorTranslator.FromHtml("#8DE9DF");
                    Color mautrang = ColorTranslator.FromHtml("#FFFFFF");
                    Color mauden = ColorTranslator.FromHtml("#000000");

                    sItem.Items.Add(CreateCheckItem("Color White", menu.Column, FixedStyle.None, mautrang));
                    sItem.Items.Add(CreateCheckItem("Color Black", menu.Column, FixedStyle.None, mauden));
                    sItem.Items.Add(CreateCheckItem("Color Pink", menu.Column, FixedStyle.None, mauhong));
                    sItem.Items.Add(CreateCheckItem("Color Blue", menu.Column, FixedStyle.None, mauxanh));
                    sItem.Items.Add(CreateCheckItem("Color Green", menu.Column, FixedStyle.None, xanhduong));
                    sItem.Items.Add(CreateCheckItem("Color Yellow", menu.Column, FixedStyle.None, mauvang));
                    sItem.Items.Add(CreateCheckItem("Color Purple", menu.Column, FixedStyle.None, mautim));
                    sItem.Items.Add(CreateCheckItem("Color Cyan", menu.Column, FixedStyle.None, xanhlam));

                    sItem.Items.Add(CreateCheckItem("Color Customize...", menu.Column, FixedStyle.None, Color.Transparent));
                    menu.Items.Add(sItem);

                    // màu chữ
                    DXSubMenuItem mauchu = new DXSubMenuItem("Màu chữ");
                    Color red = ColorTranslator.FromHtml("#F44336");
                    Color pink = ColorTranslator.FromHtml("#E91E63");
                    Color purple = ColorTranslator.FromHtml("#9C27B0");
                    Color DeepPurple = ColorTranslator.FromHtml("#673AB7");
                    Color Indigo = ColorTranslator.FromHtml("#E0CFE9");
                    Color blue = ColorTranslator.FromHtml("#3F51B5");
                    Color cyan = ColorTranslator.FromHtml("#00BCD4");
                    Color Teal = ColorTranslator.FromHtml("#009688");
                    Color green = ColorTranslator.FromHtml("#4CAF50");
                    Color Lime = ColorTranslator.FromHtml("#CDDC39");
                    Color Amber = ColorTranslator.FromHtml("#FFC107");
                    Color Orange = ColorTranslator.FromHtml("#FF9800");
                    Color depOrange = ColorTranslator.FromHtml("#FF5722");
                    Color brown = ColorTranslator.FromHtml("#795548");
                    Color grey = ColorTranslator.FromHtml("#9E9E9E");
                    Color BlueGrey = ColorTranslator.FromHtml("#607D8B");
                    Color Black = ColorTranslator.FromHtml("#000000");
                    Color White = ColorTranslator.FromHtml("#FFFFFF");

                    mauchu.Items.Add(CreateCheckItem("Black", menu.Column, FixedStyle.None, Black));
                    mauchu.Items.Add(CreateCheckItem("White", menu.Column, FixedStyle.None, White));
                    mauchu.Items.Add(CreateCheckItem("Red", menu.Column, FixedStyle.None, red));
                    mauchu.Items.Add(CreateCheckItem("Pink", menu.Column, FixedStyle.None, pink));
                    mauchu.Items.Add(CreateCheckItem("Purple", menu.Column, FixedStyle.None, purple));
                    mauchu.Items.Add(CreateCheckItem("Deep Purple", menu.Column, FixedStyle.None, DeepPurple));
                    mauchu.Items.Add(CreateCheckItem("Indigo", menu.Column, FixedStyle.None, Indigo));
                    mauchu.Items.Add(CreateCheckItem("Blue", menu.Column, FixedStyle.None, blue));
                    mauchu.Items.Add(CreateCheckItem("Cyan", menu.Column, FixedStyle.None, cyan));
                    mauchu.Items.Add(CreateCheckItem("Teal", menu.Column, FixedStyle.None, Teal));
                    mauchu.Items.Add(CreateCheckItem("Green", menu.Column, FixedStyle.None, green));
                    mauchu.Items.Add(CreateCheckItem("Lime", menu.Column, FixedStyle.None, Lime));
                    mauchu.Items.Add(CreateCheckItem("Amber", menu.Column, FixedStyle.None, Amber));
                    mauchu.Items.Add(CreateCheckItem("Orange", menu.Column, FixedStyle.None, Orange));
                    mauchu.Items.Add(CreateCheckItem("Deep Orange", menu.Column, FixedStyle.None, depOrange));
                    mauchu.Items.Add(CreateCheckItem("Brown", menu.Column, FixedStyle.None, brown));
                    mauchu.Items.Add(CreateCheckItem("Grey", menu.Column, FixedStyle.None, grey));
                    mauchu.Items.Add(CreateCheckItem("Blue Grey", menu.Column, FixedStyle.None, BlueGrey));

                    mauchu.Items.Add(CreateCheckItem("Chọn màu...", menu.Column, FixedStyle.None, Color.Transparent));
                    menu.Items.Add(mauchu);

                }
            }

            //((GridView)sender).SaveLayoutToXml("data.xml", OptionsLayoutBase.FullLayout);
        }
        public Image createImage(Color color)
        {
            Bitmap flag = new Bitmap(16, 16);
            Graphics flagGraphics = Graphics.FromImage(flag);
            Pen blackPen = new Pen(Color.Black, 2);
            Rectangle rect = new Rectangle(0, 0, 16, 16);
            flagGraphics.DrawRectangle(blackPen, rect);
            flagGraphics.FillRectangle(new SolidBrush(color), 1, 1, 14, 14);
            return flag;
        }
        DXMenuCheckItem CreateCheckItem(string caption, GridColumn column, FixedStyle style, Color color)
        {
            Image image = createImage(color);
            DXMenuCheckItem item = new DXMenuCheckItem(caption, column.Fixed == style, image, new EventHandler(OnFixedClick));
            item.Tag = new MenuInfo(column, style);
            return item;
        }
        void OnFixedClick(object sender, EventArgs e)
        {
            DXMenuItem item = sender as DXMenuItem;
            MenuInfo info = item.Tag as MenuInfo;
            if (info == null) return;

            if (item.Caption.Substring(0, 3) == "Col")
            {
                if (item.Caption == "Color Customize...")
                {
                    ColorPickEdit colorPickerEdit = new ColorPickEdit();
                    FrmColorPicker frm = new FrmColorPicker(colorPickerEdit.Properties);
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.TopMost = true;
                    if (frm.ShowDialog(colorPickerEdit.FindForm()) == System.Windows.Forms.DialogResult.OK)
                    {
                        info.Column.AppearanceCell.BackColor = frm.SelectedColor;
                    }

                }
                else
                {
                    info.Column.AppearanceCell.BackColor = ((Bitmap)item.Image).GetPixel(5, 5);
                }
            }
            else if (item.Caption.Substring(0, 3) == "Fon")
            {
                FontDialog fontDialog = new FontDialog();
                fontDialog.ShowDialog();
                info.Column.AppearanceCell.Font = fontDialog.Font;
            }
            else
            {
                if (item.Caption == "Chọn màu...")
                {
                    ColorPickEdit colorPickerEdit = new ColorPickEdit();
                    FrmColorPicker frm = new FrmColorPicker(colorPickerEdit.Properties);
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.TopMost = true;
                    if (frm.ShowDialog(colorPickerEdit.FindForm()) == System.Windows.Forms.DialogResult.OK)
                    {
                        info.Column.AppearanceCell.ForeColor = frm.SelectedColor;
                    }

                }
                else
                {
                    info.Column.AppearanceCell.ForeColor = ((Bitmap)item.Image).GetPixel(5, 5);
                }
            }


        }
    }
    class MenuInfo
    {
        public MenuInfo(GridColumn column, FixedStyle style)
        {
            this.Column = column;
            this.Style = style;
        }
        public FixedStyle Style;
        public GridColumn Column;
    }
}
