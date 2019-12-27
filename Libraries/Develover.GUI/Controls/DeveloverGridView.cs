using Develover.GUI.RepositoryItems;
using Develover.Utilities;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using static Develover.GUI.Controls.DeveloverGridControl;
using static Develover.Utilities.DelTypeData;
using static Develover.Utilities.Enum;

namespace Develover.GUI.Controls
{
    public partial class DeveloverGridView : GridView, IDeveloverControl
    {
        string fieldBinding;
        EnumTypeColumns typeFieldColumns;
        public string FieldBinding { get => fieldBinding; set => fieldBinding = value; }
        public EnumTypeColumns TypeFieldColumns { get => typeFieldColumns; set => typeFieldColumns = value; }
        public DeveloverGridView() : this(null) { }

        public DeveloverGridView(GridControl grid) : base(grid)
        {
            this.OptionsView.ShowGroupPanel = false;
            this.OptionsView.ColumnAutoWidth = false;
            this.OptionsSelection.MultiSelect = true;
            this.IndicatorWidth = 40;
            this.CustomDrawRowIndicator += DeveloverGridView_CustomDrawRowIndicator;

        }

        private void DeveloverGridView_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        protected override string ViewName { get { return "DeveloverGridView"; } }

        public void BuidColumns(List<TypeColumns> typeColumns)
        {
            this.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            this.OptionsView.ShowGroupPanel = false;
            this.OptionsNavigation.AutoFocusNewRow = true;
            this.OptionsNavigation.EnterMoveNextColumn = true;
            this.OptionsView.ShowFooter = true;
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
                gridColumn.SummaryItem.DisplayFormat = typeColumns_.StringFormat;
                gridColumn.SummaryItem.FieldName = typeColumns_.FieldName;

                GetTypeColumn(ref gridColumn, typeColumns_.TypeColumn, typeColumns_.SQLData, typeColumns_.TypeColumnGridLookup, typeColumns_.KeyMember, typeColumns_.ValueMember, typeColumns_.DisplayMember, typeColumns_.NullText);
                Columns.Add(gridColumn);
            }
        }

        public void BuidColumnsView(List<TypeColumns> typeColumns)
        {
            this.OptionsFind.AlwaysVisible = true;
            this.OptionsFind.ClearFindOnClose = true;
            this.OptionsFind.ShowClearButton = true;
            this.OptionsFind.ShowCloseButton = true;
            this.OptionsFind.SearchInPreview = true;
            this.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.OptionsFind.FindNullPrompt = StringMessage.TextFindFilter;
            this.OptionsView.ShowAutoFilterRow = true;
            this.OptionsView.ShowGroupPanel = false;
            this.GroupPanelText = StringMessage.GroupPanelText;

            this.OptionsView.ShowFooter = true;
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
                gridColumn.SummaryItem.DisplayFormat = typeColumns_.StringFormat;
                gridColumn.SummaryItem.FieldName = typeColumns_.FieldName;

                GetTypeColumn(ref gridColumn, typeColumns_.TypeColumn == EnumTypeColumns.Gridlookup || typeColumns_.TypeColumn == EnumTypeColumns.Combobox ? EnumTypeColumns.Text : typeColumns_.TypeColumn, typeColumns_.SQLData, typeColumns_.TypeColumnGridLookup, typeColumns_.KeyMember, typeColumns_.ValueMember, typeColumns_.DisplayMember, typeColumns_.NullText);
                Columns.Add(gridColumn);
            }
        }

        private void GetTypeColumn(ref GridColumn gridColumn, EnumTypeColumns enumTypeColumns, string SQLData, List<TypeColumns> typeColumnGridLookup, string KeyMember, string ValueMember, string DisplayMember, string NullText)
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
                    develoverRepositoryItemGridLookUpEdit.LoadData(SQLData, typeColumnGridLookup, KeyMember, ValueMember, DisplayMember, NullText);
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

    }
}
