using Develover.Core;
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
        SqlDataProvider sqlDataProvider = new SqlDataProvider();
        string sqlData_; List<TypeColumns> typeColumns_; string keyMember_; string displayMember_; string valueMember_; string nullText_;
        public DeveloverGridLookUpEdit()
        {
            Properties.NullText = "";
            Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            Properties.PopupView = new DeveloverGridView();
            Properties.ShowPopupShadow = true;
        }

        public void LoadData(DataTable data)
        {
            Properties.DataSource = data;
        }
        public void LoadData(string sqlData, List<TypeColumns> typeColumns, string keyMember = "", string displayMember = "", string valueMember = "", string nullText = "")
        {
            sqlData_ = sqlData;
            typeColumns_ = typeColumns;
            keyMember_ = keyMember;
            displayMember_ = displayMember;
            valueMember_ = valueMember;
            nullText_ = nullText;

            LoadData();
        }

        private void LoadData()
        {
           Properties.DisplayMember = displayMember_;
           Properties.ValueMember = valueMember_;
           Properties.KeyMember = keyMember_;
            Properties.NullText = nullText_;

            Properties.DataSource = sqlDataProvider.GetDataTable(sqlData_);
            ((DeveloverGridView)Properties.PopupView).BuidColumnsView(typeColumns_);
        }
    }
}