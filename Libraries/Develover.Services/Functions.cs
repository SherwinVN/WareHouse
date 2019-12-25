using Develover.Core;
using System.Collections.Generic;
using System.Text;

namespace Develover.Services
{
    public class Functions : IDeveloverFunctions
    {
        public SqlDataProvider sqlDataProvider = new SqlDataProvider();

        public Functions()
        {
            sqlDataProvider = new SqlDataProvider();
        }

      

    }
}
