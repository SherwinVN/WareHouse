using Develover.Core;
using Develover.Utilities;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Develover.GUI.RepositoryItems
{
    public class DeveloverRepositoryItemComboBox : RepositoryItemComboBox
    {
        SqlDataProvider SDP = new SqlDataProvider();
        public DeveloverRepositoryItemComboBox() : base()
        {
            AutoHeight = false;
            CloseUpKey = new KeyShortcut(Keys.Space);
            ShowPopupShadow = true;
        }

        public void LoadData(DataTable data, string columName)
        {
            foreach (DataRow dr in data.Rows)
            {
                if (!Items.Contains(dr["columName"]))
                    Items.Add(dr["columName"]);
            }
        }

        public void LoadData(string[] arrItems)
        {
               Items.AddRange(arrItems);          
        }

        public void LoadData(string sql,bool getInRow,int sttGetValue)
        {
            using (DataTable data = SDP.GetDataTable(sql)) {
                if (getInRow)
                {
                    foreach(DataColumn dc in data.Columns)
                    Items.Add(data.Rows[sttGetValue][dc.ColumnName]);
                }
                else{
                    foreach (DataRow dr in data.Rows)
                        Items.Add(dr[sttGetValue]);
                }
            }

        }
    }
}
