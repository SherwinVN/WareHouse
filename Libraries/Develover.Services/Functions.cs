using Develover.Core;

namespace Develover.Services
{
    public class Functions : IDeveloverFunctions
    {
        private SqlDataProvider sqlDataProvider;

        public Functions()
        {
            sqlDataProvider = new SqlDataProvider();
        }


    }
}
