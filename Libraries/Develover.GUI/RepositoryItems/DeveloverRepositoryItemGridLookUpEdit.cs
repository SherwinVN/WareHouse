using Develover.Core;
using Develover.GUI.Controls;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Data;
using static Develover.Utilities.DelTypeData;

namespace Develover.GUI.RepositoryItems
{
    public class DeveloverRepositoryItemGridLookUpEdit : RepositoryItemGridLookUpEdit
    {
        SqlDataProvider sqlDataProvider = new SqlDataProvider(); 

        string sqlData_;  List<TypeColumns> typeColumns_;  string keyMember_;  string displayMember_;  string valueMember_;  string nullText_;
        public DeveloverRepositoryItemGridLookUpEdit() : base()
        {
            PopupView = new DeveloverGridView();
            ShowPopupShadow = true;
        }

        public void LoadData(DataTable data)
        {
            DataSource = data;
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
            DisplayMember = displayMember_;
            ValueMember = valueMember_;
            KeyMember = keyMember_;
            NullText = nullText_;

            DataSource = sqlDataProvider.GetDataTable(sqlData_);
            ((DeveloverGridView)PopupView).BuidColumnsView(typeColumns_);
        }
    }
}
