using Develover.GUI.RepositoryItems;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
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
        public DeveloverGridView() : this(null) { }
        public DeveloverGridView(GridControl grid) : base(grid)
        {
            this.OptionsView.ShowGroupPanel = false;
        }
        protected override string ViewName { get { return "DeveloverGridView"; } }

        public void BuidColumns(List<TypeColumns> typeColumns)
        {
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
                GetTypeColumn(ref gridColumn, typeColumns_.TypeColumn, typeColumns_.SQLData, typeColumns_.TypeColumnGridLookup);
                Columns.Add(gridColumn);
            }
        }

        public void BuidColumnsView(List<TypeColumns> typeColumns)
        {
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
                gridColumn.OptionsColumn.AllowEdit =false;
                gridColumn.Visible = typeColumns_.Visible;
                GetTypeColumn(ref gridColumn, typeColumns_.TypeColumn == EnumTypeColumns.Gridlookup || typeColumns_.TypeColumn == EnumTypeColumns.Combobox ? EnumTypeColumns.Text: typeColumns_.TypeColumn, typeColumns_.SQLData, typeColumns_.TypeColumnGridLookup);
                Columns.Add(gridColumn);
            }
        }

        private void GetTypeColumn(ref GridColumn gridColumn, EnumTypeColumns enumTypeColumns, string SQLData, List<TypeColumns> typeColumnGridLookup)
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
                    develoverRepositoryItemGridLookUpEdit.LoadData(SQLData, typeColumnGridLookup);
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
