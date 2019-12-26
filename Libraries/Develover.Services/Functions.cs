using Develover.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Develover.Services
{
    public class Functions : IDeveloverFunctions
    {

        public DataBase dataBase;
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
        public bool DeleteRowTable(string Table, string NameFieldKey, string value)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("DELETE FROM [" + Table + "] WHERE [" + NameFieldKey + "] = '" + value + "'");

            string result = stringBuilder.ToString();
            return dataBase.ExecuteNonQuery(result) != -1;

        }

        public bool DeleteRowTable(string Table)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("DELETE FROM [" + Table + "]");

            string result = stringBuilder.ToString();
            return dataBase.ExecuteNonQuery(result) != -1;

        }
        public bool UpdateTable(Dictionary<string, string> ListFilesValues, string Table, string NameFieldKey, string value)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("UPDATE a SET ");
            foreach (string key in ListFilesValues.Keys)
            {
                stringBuilder.Append("[" + key + "] = N'" + ListFilesValues[key].Replace("'", "''") + "',");
            }

            string result = stringBuilder.ToString(0, stringBuilder.Length - 1) + " FROM  [" + Table + "] a  WHERE  [" + NameFieldKey + "] = N'" + value + "' ";
            return dataBase.ExecuteNonQuery(result) != -1;

        }
        public bool UpdateTable(Dictionary<string, string> ListFilesValues, string Table)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("UPDATE a SET ");
            foreach (string key in ListFilesValues.Keys)
            {
                stringBuilder.Append("[" + key + "] = N'" + ListFilesValues[key].Replace("'", "''") + "',");
            }

            string result = stringBuilder.ToString(0, stringBuilder.Length - 1) + ")" + " FROM  [" + Table + "] a ";
            return dataBase.ExecuteNonQuery(result) != -1;

        }

        public bool InsertIntoTable(Dictionary<string, string> ListFilesValues, string Table, string NameFieldKey, string value)
        {
            StringBuilder stringBuilderField = new StringBuilder();
            StringBuilder stringBuilderValue = new StringBuilder();
            stringBuilderField.Append("INSERT INTO [" + Table + "] ([" + NameFieldKey + "],");
            stringBuilderValue.Append(" Values(N'" + value + "',");
            foreach (string key in ListFilesValues.Keys)
            {
                stringBuilderField.Append("[" + key + "],");
                stringBuilderValue.Append("N'" + ListFilesValues[key].Replace("'", "''") + "',");
            }
            string result = stringBuilderField.ToString(0, stringBuilderField.Length - 1) + ")    " + stringBuilderValue.ToString(0, stringBuilderValue.Length - 1) + ")";
            return dataBase.ExecuteNonQuery(result) != -1;

        }
        public bool InsertIntoTable(Dictionary<string, string> ListFilesValues, string Table)
        {
            StringBuilder stringBuilderField = new StringBuilder();
            StringBuilder stringBuilderValue = new StringBuilder();
            stringBuilderField.Append("INSERT INTO [" + Table + "] (");
            stringBuilderValue.Append("Values(");
            foreach (string key in ListFilesValues.Keys)
            {
                stringBuilderField.Append("[" + key + "],");
                stringBuilderValue.Append("N'" + ListFilesValues[key].Replace("'", "''") + "',");
            }
            string result = stringBuilderField.ToString(0, stringBuilderField.Length - 1) + ")    " + stringBuilderValue.ToString(0, stringBuilderValue.Length - 1) + ")";
            return dataBase.ExecuteNonQuery(result) != -1;

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
