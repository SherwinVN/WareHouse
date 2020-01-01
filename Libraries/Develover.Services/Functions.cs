using Develover.Core;
using Develover.GUI;
using Develover.Utilities;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Develover.Utilities.Enum;

namespace Develover.Services
{
    public class Functions : IDeveloverFunctions
    {
        public DataBase dataBase;
        public GUI.Services.Functions FunctionsGUIService = new GUI.Services.Functions();
        public Functions()
        {
            dataBase = new DataBase();
        }
        //public List<Dictionary<string, string>> LoadListControlAndFile(iDeveloverControl, string Table)
        //{
        //    List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
        //    Dictionary<string, string> dictionary = new Dictionary<string, string>();

        //    return list;
        //}
        public string GetGUID()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
        public bool CheckGuid(string guidString, out Guid guid)
        {
            try
            {
                guid = new Guid(guidString);
                return true;
            }
            catch (FormatException)
            {
                guid = default(Guid);
                return false;
            }
        }
        public bool DeleteRowTable(string tableName, string nameFieldKey, string value)
        {
            return FunctionsGUIService.DeleteRowTable(tableName, nameFieldKey, value);
        }
        public bool DeleteTable(string tableName)
        {
            return FunctionsGUIService.DeleteTable(tableName);
        }
        public bool UpdateTable(Dictionary<string, string> listFilesValues, string tableName, string nameFieldKey, string value)
        {

            return FunctionsGUIService.UpdateTable(listFilesValues, tableName, nameFieldKey, value);
        }
        public bool UpdateTable(Dictionary<string, string> listFilesValues, string tableName)
        {
            return FunctionsGUIService.UpdateTable(listFilesValues, tableName);

        }
        public bool InsertIntoTable(Dictionary<string, string> listFilesValues, string tableName, string nameFieldKey, string value)
        {
            return FunctionsGUIService.UpdateTable(listFilesValues, tableName, nameFieldKey, value);
        }
        public bool InsertIntoTable(Dictionary<string, string> listFilesValues, string tableName)
        {
            return FunctionsGUIService.UpdateTable(listFilesValues, tableName);
        }
        public bool CheckExistsValueInTable(string tableName, string columnName, string value, string nameFieldCodePrimary, string codePrimary)
        {

            return FunctionsGUIService.CheckExistsValueInTable(tableName, columnName, value, nameFieldCodePrimary, codePrimary);
        }
        public bool CheckExistsValueInTable(string tableName, string columnName, string value)
        {
            return FunctionsGUIService.CheckExistsValueInTable(tableName, columnName, value);
        }
        public bool CheckExistsValueInTableByWJere(string tableName, string where, string nameFieldCodePrimary, string codePrimary)
        {
            return FunctionsGUIService.CheckExistsValueInTableByWhere(tableName, where, nameFieldCodePrimary, codePrimary);
        }
        public bool CheckExistsValueInTableByWJere(string tableName, string where, string nameFieldCodePrimary)
        {
            return FunctionsGUIService.CheckExistsValueInTableByWhere(tableName, where, nameFieldCodePrimary);
        }
        public bool CheckExistsColumnInTableOrView(string typeObject, string objectName, string columnName)
        {
            return FunctionsGUIService.CheckExistsColumnInTableOrView(typeObject, objectName, columnName);
        }
        public bool CheckExistsObject(string typeObject, string bbjectName)
        {
            return FunctionsGUIService.CheckExistsObject(typeObject, bbjectName);
        }
        public bool CheckDuplicate(IDeveloverControl[] develoverControls, string tableName, string nameFieldCodePrimary, string codePrimary)
        {
            string Where = "1=1 ";
            string value = "";
            foreach (IDeveloverControl develoverControl in develoverControls)
            {
                value = new Controls().GetValueByTypeFieldColumns(develoverControl.TypeFieldColumns, develoverControl);
                if (!string.IsNullOrEmpty(develoverControl.FieldBinding))
                {
                    value = new Controls().GetValueByTypeFieldColumns(develoverControl.TypeFieldColumns, develoverControl);
                    Where += " AND [" + develoverControl.FieldBinding + "] = N'" + value + "'";
                }
            }
            return CheckExistsValueInTableByWJere(tableName, Where, nameFieldCodePrimary, codePrimary);

        }
        public bool CheckDuplicate(IDeveloverControl[] develoverControls, string tableName, string nameFieldCodePrimary)
        {
            string Where = "1=1 ";
            string value = "";
            foreach (IDeveloverControl develoverControl in develoverControls)
            {
                if (!string.IsNullOrEmpty(develoverControl.FieldBinding))
                {
                    value = new Controls().GetValueByTypeFieldColumns(develoverControl.TypeFieldColumns, develoverControl);
                    Where += " AND [" + develoverControl.FieldBinding + "] = N'" + value + "'";
                }
            }
            return CheckExistsValueInTableByWJere(tableName, Where, nameFieldCodePrimary);

        }



        public class Controls
        {

            public void SetNullControl(IDeveloverControl GroupControl)
            {
                foreach (IDeveloverControl iDcontrol in ((Control)GroupControl).Controls)
                {
                    if (iDcontrol is IDeveloverControl)
                    {
                        if (!string.IsNullOrEmpty(iDcontrol.FieldBinding))
                        {
                            switch (iDcontrol.TypeFieldColumns)
                            {
                                case EnumTypeColumns.Check:
                                    ((CheckEdit)iDcontrol).Checked = false;
                                    break;
                                case EnumTypeColumns.Gridlookup:
                                    ((Control)iDcontrol).Text = "";
                                    break;
                                case EnumTypeColumns.Text:
                                    ((Control)iDcontrol).Text = "";
                                    break;
                                case EnumTypeColumns.Combobox:
                                    ((Control)iDcontrol).Text = "";
                                    break;
                                case EnumTypeColumns.Date:
                                    ((DateEdit)iDcontrol).DateTime = DateTime.Now;
                                    break;
                                case EnumTypeColumns.Number:
                                    ((Control)iDcontrol).Text = "0";
                                    break;
                                case EnumTypeColumns.Time:
                                    ((TimeEdit)iDcontrol).Time = DateTime.Now;
                                    break;
                            }


                        }
                    }

                }
            }

            public bool SetStatusEdit(IDeveloverControl GroupControl, bool Enable)
            {
                foreach (IDeveloverControl iDcontrol in ((Control)GroupControl).Controls)
                {
                    if (iDcontrol is IDeveloverControl)
                    {
                        if (!string.IsNullOrEmpty(iDcontrol.FieldBinding))
                        {
                            switch (iDcontrol.TypeFieldColumns)
                            {
                                case EnumTypeColumns.Check:
                                    ((CheckEdit)iDcontrol).ReadOnly = Enable;
                                    break;
                                case EnumTypeColumns.Gridlookup:
                                    //    ((DevExpress.XtraEditors.GridLookUpEdit)iDcontrol).ReadOnly = Enable;
                                    break;
                                case EnumTypeColumns.Text:
                                    ((TextEdit)iDcontrol).ReadOnly = Enable;
                                    break;
                                case EnumTypeColumns.Combobox:
                                    ((ComboBoxEdit)iDcontrol).ReadOnly = Enable;
                                    break;
                                case EnumTypeColumns.Date:
                                    ((DateEdit)iDcontrol).ReadOnly = Enable;
                                    break;
                                case EnumTypeColumns.Number:
                                    ((CalcEdit)iDcontrol).ReadOnly = Enable;
                                    break;
                                case EnumTypeColumns.Time:
                                    ((TimeEdit)iDcontrol).ReadOnly = Enable;
                                    break;
                            }


                        }
                    }

                }

                return Enable;
            }

            public void DataBindingsControl(IDeveloverControl GroupControl, Object Datasource)
            {
                foreach (IDeveloverControl iDcontrol in ((Control)GroupControl).Controls)
                {
                    if (iDcontrol is IDeveloverControl)
                    {
                        if (!string.IsNullOrEmpty(iDcontrol.FieldBinding))
                        {
                            switch (iDcontrol.TypeFieldColumns)
                            {
                                case EnumTypeColumns.Check:
                                    ((Control)iDcontrol).DataBindings.Add(nameof(BaseCheckEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                                    break;
                                case EnumTypeColumns.Gridlookup:
                                    // ((Control)iDcontrol).DataBindings.Add(nameof(GridLookUpEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                                    break;
                                case EnumTypeColumns.Text:
                                    ((Control)iDcontrol).DataBindings.Add(nameof(TextEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                                    break;
                                case EnumTypeColumns.Combobox:
                                    ((Control)iDcontrol).DataBindings.Add(nameof(ComboBoxEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                                    break;
                                case EnumTypeColumns.Date:
                                    ((Control)iDcontrol).DataBindings.Add(nameof(DateEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                                    break;
                                case EnumTypeColumns.Number:
                                    ((Control)iDcontrol).DataBindings.Add(nameof(CalcEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                                    break;
                                case EnumTypeColumns.Time:
                                    ((Control)iDcontrol).DataBindings.Add(nameof(TimeEdit.EditValue), Datasource, ((IDeveloverControl)iDcontrol).FieldBinding, true, DataSourceUpdateMode.Never, StringMessage.DataNullOrEmty);
                                    break;
                            }


                        }
                    }

                }

            }

            public void ClearDataBindingsControl(IDeveloverControl GroupControl)
            {
                foreach (IDeveloverControl iDcontrol in ((Control)GroupControl).Controls)
                {
                    if (iDcontrol is IDeveloverControl)
                    {
                        if (!string.IsNullOrEmpty(iDcontrol.FieldBinding))
                        {
                            ((Control)iDcontrol).DataBindings.Clear();
                        }
                    }

                }

            }

            public Dictionary<string, string> LoadListControlAndField(IDeveloverControl GroupControl)
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                string text = "";
                Guid guid;
                foreach (IDeveloverControl iDcontrol in ((Control)GroupControl).Controls)
                {
                    if (iDcontrol is IDeveloverControl)
                    {
                        if (!string.IsNullOrEmpty(iDcontrol.FieldBinding))
                        {
                            switch (iDcontrol.TypeFieldColumns)
                            {
                                case EnumTypeColumns.Number:
                                    text = ((Control)iDcontrol).Text;
                                    break;
                                case EnumTypeColumns.Check:
                                    text = ((CheckEdit)iDcontrol).Checked ? "1" : "0";
                                    break;
                                case EnumTypeColumns.Combobox:
                                    text = ((Control)iDcontrol).Text;
                                    break;
                                case EnumTypeColumns.Date:
                                    text = DateTime.Parse(((Control)iDcontrol).Text).ToString("MM/dd/yyyy");
                                    break;
                                case EnumTypeColumns.Gridlookup:
                                    text = ((Control)iDcontrol).Text;
                                    break;
                                case EnumTypeColumns.Text:
                                    text = ((Control)iDcontrol).Text;
                                    break;
                                case EnumTypeColumns.Time:
                                    text = ((Control)iDcontrol).Text;
                                    break;
                            }

                            if (iDcontrol.IsGUID)
                            {
                                new Functions().CheckGuid(text, out guid);
                                text = guid.ToString();
                            }

                            dictionary.Add(iDcontrol.FieldBinding, text);

                        }

                    }

                }

                return dictionary;
            }

            public string GetValueByTypeFieldColumns(EnumTypeColumns TypeFieldColumns, IDeveloverControl develoverControl)
            {
                string text = "";
                Guid guid;
                switch (TypeFieldColumns)
                {
                    case EnumTypeColumns.Number:
                        text = ((Control)develoverControl).Text;
                        break;
                    case EnumTypeColumns.Check:
                        text = ((CheckEdit)develoverControl).Checked ? "1" : "0";
                        break;
                    case EnumTypeColumns.Combobox:
                        text = ((Control)develoverControl).Text;
                        break;
                    case EnumTypeColumns.Date:
                        text = DateTime.Parse(((Control)develoverControl).Text).ToString("MM/dd/yyyy");
                        break;
                    case EnumTypeColumns.Gridlookup:
                        text = ((Control)develoverControl).Text;
                        break;
                    case EnumTypeColumns.Text:
                        text = ((Control)develoverControl).Text;
                        break;
                    case EnumTypeColumns.Time:
                        text = ((Control)develoverControl).Text;
                        break;
                }
                if (develoverControl.IsGUID)
                {
                    new Functions().CheckGuid(text, out guid);
                    text = guid.ToString();
                }

                return text;
            }

            public bool CheckEmty(IDeveloverControl[] develoverControls)
            {
                foreach (IDeveloverControl develoverControl in develoverControls)
                {
                    if (string.IsNullOrEmpty(((Control)develoverControl).Text))
                    {
                        return true;
                    }
                }
                return false;
            }

            public bool LoadColorControlNotEmty(IDeveloverControl[] develoverControls)
            {
                try
                {
                    foreach (IDeveloverControl develoverControl in develoverControls)
                    {
                        ((Control)develoverControl).BackColor = Color.LightGoldenrodYellow;
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    DeveloverOptions.SysDel.MessageError = ex.Message;
                    return false;
                }
            }
        }

        public class DataBase
        {
            public SqlDataProvider sqlDataProvider;

            public DataBase()
            {
                sqlDataProvider = new SqlDataProvider();
            }

            public string GetSQLConnectionString()
            {

                return sqlDataProvider.GetSQLConnectionString();
            }

            public bool CheckLogin()
            {
                return sqlDataProvider.CheckLogin();
            }

            public bool OpenConection()
            {
                return sqlDataProvider.OpenConection();
            }

            public bool CloseConection()
            {
                return sqlDataProvider.CloseConection();
            }

            public bool ChangeDataBase()
            {
                return sqlDataProvider.ChangeDataBase();

            }

            public DataTable GetDataTable(string query)
            {
                return sqlDataProvider.GetDataTable(query);
            }

            public async Task<DataTable> GetDataTableAsync(string query)
            {
                return await sqlDataProvider.GetDataTableAsync(query);
            }

            public DataTable GetDataTableParallel(string query)
            {
                return sqlDataProvider.GetDataTableParallel(query);
            }

            public async Task<DataTable> GetDataTableParallelAsync(string query)
            {
                return await sqlDataProvider.GetDataTableParallelAsync(query);
            }

            public DataSet GetDataSet(string query)
            {
                return sqlDataProvider.GetDataSet(query);
            }

            public DataSet GetDataSet(string query, string tableName)
            {
                return sqlDataProvider.GetDataSet(query, tableName);
            }


            public int ExecuteNonQuery(string query)
            {
                return sqlDataProvider.ExecuteNonQuery(query);
            }

            public async Task<int> ExecuteNonQueryAsync(string query)
            {
                return await sqlDataProvider.ExecuteNonQueryAsync(query);
            }

            public object ExecuteScalar(string query)
            {
                return sqlDataProvider.ExecuteScalar(query);
            }

            public async Task<object> ExecuteScalarAsync(string query)
            {
                return await sqlDataProvider.ExecuteScalarAsync(query);
            }

            public void ExecuteProcedure(string procedureName, SqlParameter[] paramsIn)
            {
                ExecuteProcedure(procedureName, paramsIn);
            }

            public async Task ExecuteProcedureAsync(string procedureName, SqlParameter[] paramsIn)
            {
                await ExecuteProcedureAsync(procedureName, paramsIn);
            }

            public object ExecuteProcedureOut(string procedureName, SqlParameter[] paramsIn, SqlParameter paramOut)
            {

                return ExecuteProcedureOut(procedureName, paramsIn, paramOut);
            }

            public async Task<object> ExecuteProcedureOutAsync(string procedureName, SqlParameter[] paramsIn, SqlParameter paramOut)
            {
                return await ExecuteProcedureOutAsync(procedureName, paramsIn, paramOut);
            }
        }

    }
}
