using Develover.GUI.Services;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using static Develover.Utilities.DelTypeData;
using static Develover.Utilities.Enum;

namespace Develover.GUI.Controls
{
    public class DeveloverGridLookUpEdit : GridLookUpEdit, IDeveloverControl
    {
        string fieldBinding;
        EnumTypeColumns typeFieldColumns;
        public string FieldBinding { get => fieldBinding; set => fieldBinding = value; }
        public EnumTypeColumns TypeFieldColumns { get => typeFieldColumns; set => typeFieldColumns = value; }
        Functions functions = new Functions();
        string sqlData_;

        public DeveloverGridLookUpEdit() : base()
        {
            Properties.NullText = "";
            Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            Properties.PopupView = new DeveloverGridView(); 
            Properties.ShowPopupShadow = true;
        }

        public void LoadData(DataTable data, string Model, string KeyMember = "", string DisplayMember = "", string ValueMember = "", string NullText = "")
        {
            Properties.DisplayMember = DisplayMember;
            Properties.ValueMember = ValueMember;
            Properties.KeyMember = KeyMember;
            Properties.NullText = NullText;
            BuildGridView(Model);
            Properties.DataSource = data;
        }
        public void LoadData(string SQLData, string Model, string KeyMember = "", string DisplayMember = "", string ValueMember = "", string NullText = "")
        {
            sqlData_ = SQLData;

            Properties.KeyMember = KeyMember;
            Properties.DisplayMember = DisplayMember;
            Properties.ValueMember = ValueMember;
            Properties.NullText = NullText;

            BuildGridView(Model);
            LoadData();
        }

        private void LoadData()
        {
            Properties.DataSource = functions.dataBase.GetDataTable(sqlData_);
        }

        public void BuildGridView(string Model)
        {

            List<TypeColumns> typeColumns = GetSysDelGridcolumnsView(Model);
           ((DeveloverGridView)Properties.PopupView).BuidColumnsView(typeColumns);

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