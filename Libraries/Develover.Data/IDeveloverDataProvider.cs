using System.Data;
using System.Threading.Tasks;

namespace Develover.Data
{
    public interface IDeveloverDataProvider
    {
        string ConnectionString { get; }
        string ErrorMessage { get; }

        bool TryOpenConnection();
        Task<bool> TryOpenConnectionAsync();

        int ExecuteNonQuery(string queryString, params IDbDataParameter[] parameters);
        object ExecuteScalar(string queryString, params IDbDataParameter[] parameters);
        int ExecuteProcedure(string procedureName, params IDbDataParameter[] parameters);
        object ExecuteProcedureOut(string procedureName, IDbDataParameter output, params IDbDataParameter[] parameters);

        Task<int> ExecuteNonQueryAsync(string queryString, params IDbDataParameter[] parameters);
        Task<object> ExecuteScalarAsync(string queryString, params IDbDataParameter[] parameters);
        Task<int> ExecuteProcedureAsync(string procedureName, params IDbDataParameter[] parameters);
        Task<object> ExecuteProcedureOutAsync(string procedureName, IDbDataParameter output, params IDbDataParameter[] parameters);
    }
}
