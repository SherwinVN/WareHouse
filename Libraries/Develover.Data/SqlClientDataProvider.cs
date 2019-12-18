using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Develover.Data
{
    public class SqlClientDataProvider : IDeveloverDataProvider
    {
        public string ConnectionString { get; private set; }
        public string ErrorMessage { get; private set; }

        public SqlClientDataProvider()
        {
            //ConnectionString = _dbConfig.GetConnectionString();
        }

        #region Sync Methods
        public bool TryOpenConnection()
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    ErrorMessage = "";
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return false;
        }

        public int ExecuteNonQuery(string queryString, params IDbDataParameter[] parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(queryString, connection))
                {
                    command.CommandType = CommandType.Text;
                    if (parameters != null) command.Parameters.AddRange(parameters);

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public object ExecuteScalar(string queryString, params IDbDataParameter[] parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(queryString, connection))
                {
                    command.CommandType = CommandType.Text;
                    if (parameters != null) command.Parameters.AddRange(parameters);

                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }

        public int ExecuteProcedure(string procedureName, params IDbDataParameter[] parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (parameters != null) command.Parameters.AddRange(parameters);

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public object ExecuteProcedureOut(string procedureName, IDbDataParameter output, params IDbDataParameter[] parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (parameters != null) command.Parameters.AddRange(parameters);

                    connection.Open();
                    command.ExecuteNonQuery();

                    return output.Value;
                }
            }
        }

        public DataTable GetDataTable(string queryString)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var adapter = new SqlDataAdapter(queryString, connection))
                {
                    connection.Open();
                    DataTable table = null;
                    adapter.Fill(table);

                    return table;
                }
            }
        }
        #endregion


        #region Async Methods
        public async Task<bool> TryOpenConnectionAsync()
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    await connection.OpenAsync();
                    ErrorMessage = "";
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return false;
        }

        public async Task<int> ExecuteNonQueryAsync(string queryString, params IDbDataParameter[] parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(queryString, connection))
                {
                    command.CommandType = CommandType.Text;
                    if (parameters != null) command.Parameters.AddRange(parameters);

                    await connection.OpenAsync();
                    return await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<object> ExecuteScalarAsync(string queryString, params IDbDataParameter[] parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(queryString, connection))
                {
                    command.CommandType = CommandType.Text;
                    if (parameters != null) command.Parameters.AddRange(parameters);

                    await connection.OpenAsync();
                    return await command.ExecuteScalarAsync();
                }
            }
        }

        public async Task<int> ExecuteProcedureAsync(string procedureName, params IDbDataParameter[] parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (parameters != null) command.Parameters.AddRange(parameters);

                    await connection.OpenAsync();
                    return await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<object> ExecuteProcedureOutAsync(string procedureName, IDbDataParameter output, params IDbDataParameter[] parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (parameters != null) command.Parameters.AddRange(parameters);

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();

                    return output.Value;
                }
            }
        }
        #endregion
    }
}
