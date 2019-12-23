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
            DisplayMember = displayMember;
            ValueMember = valueMember;
            KeyMember = keyMember;
            NullText = nullText;

            DataSource = sqlDataProvider.GetDataTable(sqlData) ;
            ((DeveloverGridView)PopupView).BuidColumnsView(typeColumns);
        }

    }
}
