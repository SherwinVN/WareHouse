using Develover.GUI.Services;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Data;
using static Develover.Utilities.DelTypeData;
using static Develover.Utilities.Enum;

namespace Develover.GUI.Controls
{
    public class DeveloverLookUpEdit : LookUpEdit, IDeveloverControl
    {
        string fieldBinding;
        bool isGUID;
        EnumTypeColumns typeFieldColumns;
        public string FieldBinding { get => fieldBinding; set => fieldBinding = value; }
        public EnumTypeColumns TypeFieldColumns { get => typeFieldColumns; set => typeFieldColumns = value; }
        public bool IsGUID { get => isGUID; set => isGUID = value; }

        Functions functions = new Functions();

        string sqlData_;string keyMember_; string displayMember_; string valueMember_; string nullText_;
        public DeveloverLookUpEdit() : base()
        {
            Properties.ShowPopupShadow = true;
        }

        public void LoadData(DataTable data)
        {
            Properties.DataSource = data;
        }
        public void LoadData(string sqlData, string keyMember = "", string displayMember = "", string valueMember = "", string nullText = "")
        {
            sqlData_ = sqlData;
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

            Properties.DataSource = functions.dataBase.GetDataTable(sqlData_);
        }
    }
}
