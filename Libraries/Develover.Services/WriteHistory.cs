using Develover.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develover.Services
{
    public class WriteHistory
    {
        public Functions functions = new Functions();
        public bool StartSession()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            DeveloverOptions.StatusLogins.session = functions.GetGUID();
            keyValuePairs.Add("ID", DeveloverOptions.StatusLogins.session);
            keyValuePairs.Add("UserID", DeveloverOptions.StatusLogins.UserID);
            keyValuePairs.Add("DateLogin", DateTime.Now.ToString(SqlDataSourceEnumerators.StringFormatDateISO8601));
            keyValuePairs.Add("DateLogout", DateTime.Now.ToString(SqlDataSourceEnumerators.StringFormatDateISO8601));

            return functions.InsertIntoTable(keyValuePairs, "SysDELHistoryLogin");
        }
        public bool EndSession()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            keyValuePairs.Add("ID", DeveloverOptions.StatusLogins.session);
            keyValuePairs.Add("UserID", DeveloverOptions.StatusLogins.UserID);
            keyValuePairs.Add("DateLogout", DateTime.Now.ToString(SqlDataSourceEnumerators.StringFormatDateISO8601));

            return functions.UpdateTable(keyValuePairs, "SysDELHistoryLogin","ID", DeveloverOptions.StatusLogins.session);
        }
    }
}
