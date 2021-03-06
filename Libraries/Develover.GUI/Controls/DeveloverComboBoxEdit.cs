﻿using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.Data;
using System.Windows.Forms;
using static Develover.Utilities.Enum;
using Develover.GUI.Services;

namespace Develover.GUI.Controls
{
    public class DeveloverComboBoxEdit : ComboBoxEdit, IDeveloverControl
    {
        string fieldBinding;
        bool isGUID;
        EnumTypeColumns typeFieldColumns;
        public string FieldBinding { get => fieldBinding; set => fieldBinding = value; }
        public EnumTypeColumns TypeFieldColumns { get => typeFieldColumns; set => typeFieldColumns = value; }
        public bool IsGUID { get => isGUID; set => isGUID = value; }

        Functions functions = new Functions(); 

        private string sql_ = "";
        private bool getInRow_ = false;
        private int indexGetValue_ = 0;
        public DeveloverComboBoxEdit() : base()
        {
            Properties.AutoHeight = false;
            Properties.CloseUpKey = new KeyShortcut(Keys.Space);
            Properties.ShowPopupShadow = true;
            TypeFieldColumns = EnumTypeColumns.Combobox;
        }

        public void LoadData(DataTable data, string columName)
        {
            foreach (DataRow dr in data.Rows)
            {
                if (!Properties.Items.Contains(dr["columName"]))
                    Properties.Items.Add(dr["columName"]);
            }
        }

        public void LoadData(string[] arrItems)
        {
            Properties.Items.AddRange(arrItems);
        }

        public void LoadData(string sql, bool getInRow, int indexGetValue)
        {
            sql_ = sql;
            indexGetValue_ = indexGetValue;
            getInRow_ = getInRow;
            LoadData();

        }

        private void LoadData()
        {
            using (DataTable data = functions.dataBase.GetDataTable(sql_))
            {
                if (getInRow_)
                {
                    foreach (DataColumn dc in data.Columns)
                        Properties.Items.Add(data.Rows[indexGetValue_][dc.ColumnName]);
                }
                else
                {
                    foreach (DataRow dr in data.Rows)
                        Properties.Items.Add(dr[indexGetValue_]);
                }
            }
        }
    }
}
