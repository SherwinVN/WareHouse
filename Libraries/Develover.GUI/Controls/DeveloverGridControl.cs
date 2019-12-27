using Develover.Services;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using static Develover.Utilities.DelTypeData;
using static Develover.Utilities.Enum;

namespace Develover.GUI.Controls
{
    public partial class DeveloverGridControl : GridControl, IDeveloverControl
    {
        string fieldBinding;
        EnumTypeColumns typeFieldColumns;
        public string FieldBinding { get => fieldBinding; set => fieldBinding = value; }
        public EnumTypeColumns TypeFieldColumns { get => typeFieldColumns; set => typeFieldColumns = value; }

        Functions functions = new Functions();
        string sqlData;
        string model;

        protected override BaseView CreateDefaultView()
        {
            return CreateView("DeveloverGridView");
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new DeveloverGridViewInfoRegistrator());

        }
        public void BuildGridControls(string SQLData, List<TypeColumns> typeColumns, bool GridEdit = true)
        {
            DeveloverGridView develoverGridView = ((DeveloverGridView)this.DefaultView);
            develoverGridView.BuidColumns(typeColumns);
            DataSource = functions.dataBase.GetDataTable(SQLData);
        }
        public void BuildGridControls(string SQLData, string Model)
        {
            DeveloverGridView develoverGridView = ((DeveloverGridView)this.DefaultView);
            sqlData = SQLData;
            model = Model;
            UseEmbeddedNavigator = true;

            EmbeddedNavigator.Buttons.Append.Visible = false;
            EmbeddedNavigator.Buttons.Edit.Visible = false;
            EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            List<TypeColumns> typeColumns = GetSysDelGridcolumns(model);
            ((DeveloverGridView)this.DefaultView).BuidColumns(typeColumns);


        }
        public void BuildGridControlsView(string SQLData, string Model)
        {
            sqlData = SQLData;
            model = Model;
            UseEmbeddedNavigator = true;

            EmbeddedNavigator.Buttons.Append.Visible = false;
            EmbeddedNavigator.Buttons.Edit.Visible = false;
            EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            EmbeddedNavigator.TextStringFormat = " {0} / {1}";

            List<TypeColumns> typeColumns = GetSysDelGridcolumnsView(model);
            ((DeveloverGridView)this.DefaultView).BuidColumnsView(typeColumns);

        }

        public void LoadData()
        {
            DataSource = functions.dataBase.GetDataTable(sqlData);
        }

        private List<TypeColumns> GetSysDelGridcolumns(string Model)
        {
            List<TypeColumns> typeColumns = new List<TypeColumns>();
            TypeColumns typeColumns_;
            using (DataTable data = functions.dataBase.GetDataTable("SELECT * FROM sysDELGridColumns WHERE Model = '" + Model + "'"))
            {
                foreach (DataRow dr in data.Rows)
                {
                    typeColumns_ = new TypeColumns();
                    typeColumns_.Caption = dr["Caption"]?.ToString();
                    typeColumns_.Name = dr["Name"]?.ToString();
                    typeColumns_.FieldName = dr["Name"]?.ToString();
                    typeColumns_.Visible = false;
                    bool.TryParse(dr["Visible"]?.ToString(), out typeColumns_.Visible);
                    typeColumns_.AllowFocus = false;
                    bool.TryParse(dr["AllowFocus"]?.ToString(), out typeColumns_.AllowFocus);
                    typeColumns_.AllowEdit = false;
                    typeColumns_.Width = 10;
                    int.TryParse(dr["Width"].ToString(), out typeColumns_.Width);
                    typeColumns_.Index = 10;
                    int.TryParse(dr["OrderNo"].ToString(), out typeColumns_.Index);

                    typeColumns_.SumaryType = GetSumaryType(dr["SumaryType"]?.ToString());
                    typeColumns_.StringFormat = dr["StringFormat"]?.ToString();

                    typeColumns_.TypeColumn = GetTypeColumn(dr["Type"]?.ToString());
                    bool.TryParse(dr["AllowEdit"]?.ToString(), out typeColumns_.AllowEdit);


                    typeColumns_.ChildModel = dr["ChildModel"]?.ToString();
                    typeColumns_.SQLData = dr["DataSource"]?.ToString();
                    typeColumns_.KeyMember = dr["KeyMember"]?.ToString();
                    typeColumns_.DisplayMember = dr["DisplayMember"]?.ToString();
                    typeColumns_.ValueMember = dr["ValueMember"]?.ToString();
                    typeColumns_.NullText = dr["NullText"]?.ToString();

                    typeColumns_.TypeColumnGridLookup = GetSysDelGridcolumnsView(typeColumns_.ChildModel);
                    typeColumns.Add(typeColumns_);
                }
            }
            return typeColumns;
        }
        private List<TypeColumns> GetSysDelGridcolumnsView(string Model)
        {
            List<TypeColumns> typeColumns = new List<TypeColumns>();
            TypeColumns typeColumns_;
            using (DataTable data = functions.dataBase.GetDataTable("SELECT * FROM sysDELGridColumns WHERE Model = '" + Model + "'"))
            {
                foreach (DataRow dr in data.Rows)
                {
                    typeColumns_ = new TypeColumns();
                    typeColumns_.Caption = dr["Caption"]?.ToString();
                    typeColumns_.Name = dr["Name"]?.ToString();
                    typeColumns_.FieldName = dr["Name"]?.ToString();
                    typeColumns_.Visible = false;
                    bool.TryParse(dr["Visible"]?.ToString(), out typeColumns_.Visible);
                    typeColumns_.AllowFocus = false;
                    bool.TryParse(dr["AllowFocus"]?.ToString(), out typeColumns_.AllowFocus);
                    typeColumns_.AllowEdit = false;
                    typeColumns_.Width = 10;
                    int.TryParse(dr["Width"].ToString(), out typeColumns_.Width);
                    typeColumns_.Index = 10;
                    int.TryParse(dr["OrderNo"].ToString(), out typeColumns_.Index);

                    typeColumns_.SumaryType = GetSumaryType(dr["SumaryType"]?.ToString());
                    typeColumns_.StringFormat = dr["StringFormat"]?.ToString();

                    typeColumns_.TypeColumn = GetTypeColumn("Text");


                    typeColumns_.ChildModel = dr["ChildModel"]?.ToString();
                    typeColumns_.SQLData = dr["DataSource"]?.ToString();
                    typeColumns_.KeyMember = dr["KeyMember"]?.ToString();
                    typeColumns_.DisplayMember = dr["DisplayMember"]?.ToString();
                    typeColumns_.ValueMember = dr["ValueMember"]?.ToString();
                    typeColumns_.NullText = dr["NullText"]?.ToString();

                    //typeColumns_.TypeColumnGridLookup = GetSysDelGridcolumnsView(typeColumns_.ChildModel);
                    typeColumns.Add(typeColumns_);
                }
            }
            return typeColumns;
        }

    }
}
