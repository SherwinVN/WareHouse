using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develover.Utilities
{
    public class SqlDataSourceEnumerators
    {
        public static string StringFormatDateISO8601 = "MM/dd/yyyy HH:mm:ss.fff";
        public  async Task<DataTable> GetNameInstanceAsync()
        {
            SqlDataSourceEnumerator instance = System.Data.Sql.SqlDataSourceEnumerator.Instance;
            return await Task.Run(() => instance.GetDataSources());
        }
        public DataTable GetNameInstance()
        {
            SqlDataSourceEnumerator instance = System.Data.Sql.SqlDataSourceEnumerator.Instance;
            return instance.GetDataSources();
        }
    }
}
