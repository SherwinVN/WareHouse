using Develover.Core;
using System.Collections.Generic;
using System.Text;

namespace Develover.Services
{
    public class Functions : IDeveloverFunctions
    {
        public SqlDataProvider sqlDataProvider;

        public Functions()
        {
            sqlDataProvider = new SqlDataProvider();
        }

      

    }
}
