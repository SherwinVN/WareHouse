using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Develover.Utilities
{
    public class AutoCompleteStringCollections
    {
        public async Task<AutoCompleteStringCollection> SERVERTableName() {
            SqlDataSourceEnumerators sqlDataSourceEnumerators = new SqlDataSourceEnumerators();
            DataTable dataTable = await sqlDataSourceEnumerators.GetNameInstanceAsync();

            AutoCompleteStringCollection SERVERTableName = null;
            SERVERTableName = new AutoCompleteStringCollection();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                SERVERTableName.Add(dataRow["ServerName"].ToString() + "\\" + dataRow["InstanceName"].ToString());
            }
            return SERVERTableName;
        }
    }
}
