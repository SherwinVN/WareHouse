using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develover.Utilities
{
    public class DeveloverOptions
    {
        public DeveloverOptions()
        {

        }
        public static class sysdel
        {
            public static bool StatusLogin = false;
        }

        public static class StatusLogin
        {
            public static string Username = "";
            public static string Name = "";
            public static string Permission = "";
        }
        public static class InforUser
        {
            public static string Username = "";
            public static string Name = "";
            public static string Permission = "";
        }
        public static class InforCompany
        {
            public static string Name = "";
            public static string Address = "";
            public static string NameDirector = "";
            public static string Code = "";
            public static string MobilePhone = "";
            public static string Landline = "";
            public static string Email = "";
            public static string Website = "";
        }
    }

}
