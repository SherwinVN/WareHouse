using System;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Develover.Utilities;

namespace Develover.Core {
    public sealed class SqlDataProvider
    {

        public static string ConnectionString { get => connectionString; set => connectionString = value; }
        SqlConnection sqlConnection = new SqlConnection();
        private static string connectionString;

        public SqlDataProvider()
        {
            //connectionString = ConfigurationManager.ConnectionStrings["DeveloverConnection"].ToString();
            // "Server=192.168.1.116,2828;Database=Develover;User Id=dev;Password=123;"
        }

        public string GetSQLConnectionString()
        {
            return sqlConnection.ConnectionString = "Server=" + DeveloverOptions.InfoDatabase.ServerName + ";User Id=" + DeveloverOptions.InfoDatabase.UsernameSQL + ";Password=" + DeveloverOptions.InfoDatabase.PasswordSQL + ";";
        }

        public bool CheckLogin()
        {
            GetSQLConnectionString();
            if (sqlConnection.State != ConnectionState.Open)
            {
                try { sqlConnection.Open(); }
                catch (Exception ex)
                {
                    DeveloverOptions.SysDel.MessageError = ex.Message;
                    return false;
                };
                sqlConnection.Close();
            }
            return true;
        }

        public bool OpenConection()
        {
            GetSQLConnectionString();
            if (sqlConnection.State != ConnectionState.Open)
                try { sqlConnection.Open(); }
                catch (Exception ex)
                {
                    DeveloverOptions.SysDel.MessageError = ex.Message;
                    return false;
                };
            return true;

        }

        public bool CloseConection()
        {
            if (sqlConnection.State == ConnectionState.Open)
                try { sqlConnection.Close(); }
                catch (Exception ex)
                {
                    DeveloverOptions.SysDel.MessageError = ex.Message;
                    return false;
                };
            return true;

        }

        public bool ChangeDataBase()
        {
            GetSQLConnectionString();
            if (sqlConnection.State != ConnectionState.Open)
            {
                try { sqlConnection.Open(); }
                catch (Exception ex)
                {
                    DeveloverOptions.SysDel.MessageError = ex.Message;
                    return false;
                };
            }
            try
            {
                sqlConnection.ChangeDatabase(DeveloverOptions.InfoDatabase.DatabaseName);
                connectionString = "Server=" + DeveloverOptions.InfoDatabase.ServerName + ";Database=" + DeveloverOptions.InfoDatabase.DatabaseName + ";User Id=" + DeveloverOptions.InfoDatabase.UsernameSQL + ";Password=" + DeveloverOptions.InfoDatabase.PasswordSQL + ";";
            }
            catch (Exception ex)
            {
                DeveloverOptions.SysDel.MessageError = ex.Message;
                return false;
            };
            return true;

        }

        public DataTable GetDataTable(string query)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                DataTable resultTable = new DataTable();

                using (SqlDataReader reader = ExecuteReader(query, connection))
                {
                    if (reader is null) return resultTable;

                    using (DataTable schemaTable = reader.GetSchemaTable())
                    {
                        foreach (DataRow dataRow in schemaTable.Rows)
                        {
                            DataColumn dataColumn = new DataColumn
                            {
                                ColumnName = dataRow["ColumnName"].ToString(),
                                DataType = Type.GetType(dataRow["DataType"].ToString()),
                                ReadOnly = (bool)dataRow["IsReadOnly"],
                                AutoIncrement = (bool)dataRow["IsAutoIncrement"],
                                Unique = (bool)dataRow["IsUnique"]
                            };

                            resultTable.Columns.Add(dataColumn);
                        }
                    }
                    while (reader.Read())
                    {
                        DataRow dataRow = resultTable.NewRow();
                        for (int i = 0; i < resultTable.Columns.Count; i++)
                        {
                            dataRow[i] = reader[i];
                        }
                        resultTable.Rows.Add(dataRow);
                    }
                }
                return resultTable;
            }
        }

        public async Task<DataTable> GetDataTableAsync(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                DataTable resultTable = new DataTable();

                using (SqlDataReader reader = await ExecuteReaderAsync(query, connection))
                {
                    using (DataTable schemaTable = reader.GetSchemaTable())
                    {
                        foreach (DataRow dataRow in schemaTable.Rows)
                        {
                            DataColumn dataColumn = new DataColumn
                            {
                                ColumnName = dataRow["ColumnName"].ToString(),
                                DataType = Type.GetType(dataRow["DataType"].ToString()),
                                ReadOnly = (bool)dataRow["IsReadOnly"],
                                AutoIncrement = (bool)dataRow["IsAutoIncrement"],
                                Unique = (bool)dataRow["IsUnique"]
                            };

                            resultTable.Columns.Add(dataColumn);
                        }
                    }

                    while (reader.Read())
                    {
                        DataRow dataRow = resultTable.NewRow();
                        for (int i = 0; i < resultTable.Columns.Count; i++)
                        {
                            dataRow[i] = reader[i];
                        }
                        resultTable.Rows.Add(dataRow);
                    }
                }
                return resultTable;
            }
        }

        public DataTable GetDataTableParallel(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                DataTable resultTable = new DataTable();

                using (SqlDataReader reader = ExecuteReader(query, connection))
                {
                    using (DataTable schemaTable = reader.GetSchemaTable())
                    {
                        Parallel.For(0, schemaTable.Rows.Count, (i) =>
                        {
                            DataRow dataRow = schemaTable.Rows[i];
                            DataColumn dataColumn = new DataColumn
                            {
                                ColumnName = dataRow["ColumnName"].ToString(),
                                DataType = Type.GetType(dataRow["DataType"].ToString()),
                                ReadOnly = (bool)dataRow["IsReadOnly"],
                                AutoIncrement = (bool)dataRow["IsAutoIncrement"],
                                Unique = (bool)dataRow["IsUnique"]
                            };

                            resultTable.Columns.Add(dataColumn);
                        });
                    }
                    while (reader.Read())
                    {
                        DataRow dataRow = resultTable.NewRow();
                        Parallel.For(0, resultTable.Columns.Count - 1, (i) =>
                        {
                            string name = resultTable.Columns[i].ColumnName;
                            dataRow[name] = reader[name];
                        });
                        resultTable.Rows.Add(dataRow);
                    }
                }
                return resultTable;
            }
        }

        public async Task<DataTable> GetDataTableParallelAsync(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                DataTable resultTable = new DataTable();

                using (SqlDataReader reader = await ExecuteReaderAsync(query, connection))
                {
                    using (DataTable schemaTable = reader.GetSchemaTable())
                    {
                        Parallel.For(0, schemaTable.Rows.Count, (i) =>
                        {
                            DataRow dataRow = schemaTable.Rows[i];
                            DataColumn dataColumn = new DataColumn
                            {
                                ColumnName = dataRow["ColumnName"].ToString(),
                                DataType = Type.GetType(dataRow["DataType"].ToString()),
                                ReadOnly = (bool)dataRow["IsReadOnly"],
                                AutoIncrement = (bool)dataRow["IsAutoIncrement"],
                                Unique = (bool)dataRow["IsUnique"]
                            };

                            resultTable.Columns.Add(dataColumn);
                        });
                    }
                    while (reader.Read())
                    {
                        DataRow dataRow = resultTable.NewRow();
                        Parallel.For(0, resultTable.Columns.Count - 1, (i) =>
                        {
                            string name = resultTable.Columns[i].ColumnName;
                            dataRow[name] = reader[name];
                        });
                        resultTable.Rows.Add(dataRow);
                    }
                }
                return resultTable;
            }
        }

        public DataSet GetDataSet(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                DataSet dataSet = new DataSet();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                {
                    dataAdapter.Fill(dataSet);

                    return dataSet;
                }
            }
        }

        public DataSet GetDataSet(string query, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                DataSet dataSet = new DataSet();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                {
                    dataAdapter.Fill(dataSet, tableName);

                    return dataSet;
                }
            }
        }

        public SqlDataReader ExecuteReader(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection) { CommandType = CommandType.Text })
                {
                    return command.ExecuteReader();
                }
            }
        }

        public async Task<SqlDataReader> ExecuteReaderAsync(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection) { CommandType = CommandType.Text })
                {
                    return await command.ExecuteReaderAsync();
                }
            }
        }

        public SqlDataReader ExecuteReader(string query, SqlConnection connection)
        {
            SqlDataReader dataReader;

            if (connection.State != ConnectionState.Open)
                connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection) { CommandType = CommandType.Text })
            {
                try
                {
                    dataReader = command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    dataReader = null;
                    DeveloverOptions.SysDel.MessageError = ex.Message;
                }
            }

            return dataReader;
        }

        public async Task<SqlDataReader> ExecuteReaderAsync(string query, IDbConnection connection)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            using (SqlCommand command = new SqlCommand(query, (SqlConnection)connection) { CommandType = CommandType.Text })
            {
                return await command.ExecuteReaderAsync();
            }
        }

        public int ExecuteNonQuery(string query)
        {
            int value;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand command = new SqlCommand(query, connection, transaction) { CommandType = CommandType.Text })
                    {
                        try
                        {
                            value = command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                        catch(Exception ex)
                        {
                            DeveloverOptions.SysDel.MessageError = ex.Message;
                            value = -1;
                            transaction.Rollback();
                        }

                    }
                }
            }
            return value;
        }

        public async Task<int> ExecuteNonQueryAsync(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection) { CommandType = CommandType.Text })
                {
                    return await command.ExecuteNonQueryAsync();
                }
            }
        }

        public object ExecuteScalar(string query)
        {
            object value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand command = new SqlCommand(query, connection, transaction) { CommandType = CommandType.Text })
                    {
                        try
                        {
                            value = command.ExecuteScalar();
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {

                            DeveloverOptions.SysDel.MessageError = ex.Message;
                            value = null;
                            transaction.Rollback();
                        }
                    }
                }
            }

            return value;
        }

        public async Task<object> ExecuteScalarAsync(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection) { CommandType = CommandType.Text })
                {
                    return await command.ExecuteScalarAsync();
                }
            }
        }

        public void ExecuteProcedure(string procedureName, SqlParameter[] paramsIn)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand command = new SqlCommand(procedureName, connection, transaction) { CommandType = CommandType.StoredProcedure })
                    {
                        try
                        {
                            command.Parameters.AddRange(paramsIn);

                            command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                        catch { transaction.Rollback(); }
                    }
                }
            }
        }

        public async Task ExecuteProcedureAsync(string procedureName, SqlParameter[] paramsIn)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(procedureName, connection) { CommandType = CommandType.StoredProcedure })
                {
                    command.Parameters.AddRange(paramsIn);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public object ExecuteProcedureOut(string procedureName, SqlParameter[] paramsIn, SqlParameter paramOut)
        {
            object value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand command = new SqlCommand(procedureName, connection, transaction) { CommandType = CommandType.StoredProcedure })
                    {
                        try
                        {
                            command.Parameters.AddRange(paramsIn);
                            command.Parameters.Add(paramOut);

                            command.ExecuteNonQuery();

                            value = paramOut.Value;
                            transaction.Commit();
                        }
                        catch
                        {
                            value = null;
                            transaction.Rollback();
                        }
                    }
                }
            }

            return value;
        }

        public async Task<object> ExecuteProcedureOutAsync(string procedureName, SqlParameter[] paramsIn, SqlParameter paramOut)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(procedureName, connection) { CommandType = CommandType.StoredProcedure })
                {
                    command.Parameters.AddRange(paramsIn);
                    command.Parameters.Add(paramOut);

                    await command.ExecuteNonQueryAsync();

                    return paramOut.Value;
                }
            }
        }
    }
}