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
        public static class SysDel
        {
            public static string CodePersonal = "";
            public static string SerialNumber = "";
            public static string ProcessorId = "";

            public static string MessageError = "";

        }
        public static class InfoDatabase {

            public static string ServerName = "";
            public static string DatabaseName = "";
            public static string UsernameSQL = "";
            public static string PasswordSQL = "";
        }

        public static class StatusLogins
        {
            public static bool StatusLogin = false;
            public static string Username = "";
            public static string Password = "";
            public static bool RememberPassword =false;
        }
        public static class InfoUser
        {
            public static string Username = "";
            public static string Name = "";
            public static string Permission = "";
            public static string Address = "";
        }
        public static class InfoCompany
        {
            public static string Name = "";
            public static string Acronym = "";
            public static string Address = "";
            public static string NameDirector = "";
            public static string CodePersonal = "";
            public static string MobilePhone = "";
            public static string Landline = "";
            public static string Email = "";
            public static string Website = "";
        }
    }

}
