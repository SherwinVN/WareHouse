using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develover
{
    public class DeveloverOptions
    {
        public static Color ControlRequiedInputBackColor = Color.Green;
        public static Color ControlRequiedInputForeColor = Color.White;

        public static Color ControlExistsValueBackColor = Color.Red;
        public static Color ControlExistsValueForeColor = Color.White;

        public DeveloverOptions()
        {
        }

        public class SysDel
        {
            public static string CodePersonal = "";
            public static string SerialNumber = "";
            public static string ProcessorId = "";
            public static Enum.TypeLicenses TypeLicense = Enum.TypeLicenses.None;
            public static DateTime ExpirationDate = DateTime.Now.AddDays(-5 * 365);
            public static bool StatusLicense = false;

            public static string MessageError = "";

            public static string GetTextTypeLicense()
            {
                string text = "";
                switch (TypeLicense)
                {
                    case Enum.TypeLicenses.Free:
                        text = "Giấy phép miễn phí";
                        break;
                    case Enum.TypeLicenses.Persional:
                        text = "Giấy phép cá nhân";
                        break;
                    case Enum.TypeLicenses.Company:
                        text = "Giấy phép công ty";
                        break;
                    case Enum.TypeLicenses.None:
                        text = "Chưa có giấy phép";
                        break;
                }
                return text;
            }

            public Enum.TypeLicenses GetTextTypeLicenseByIndex(int index)
            {
                switch (index)
                {
                    case 0:
                        return Enum.TypeLicenses.None;
                    case 1:
                        return Enum.TypeLicenses.Free;
                    case 2:
                        return Enum.TypeLicenses.Persional;
                    case 3:
                        return Enum.TypeLicenses.Company;
                    default:
                        return Enum.TypeLicenses.None;
                }
            }

            public static Enum.TypeLicenses GetTextTypeLicenseByString(string TypeLicense)
            {
                switch (TypeLicense)
                {
                    case "None":
                        return Enum.TypeLicenses.None;
                    case "Free":
                        return Enum.TypeLicenses.Free;
                    case "Persional":
                        return Enum.TypeLicenses.Persional;
                    case "Company":
                        return Enum.TypeLicenses.Company;
                    default:
                        return Enum.TypeLicenses.None;
                }
            }

        }
        public static class InfoDatabase
        {

            public static string ServerName = "";
            public static string DatabaseName = "";
            public static string UsernameSQL = "";
            public static string PasswordSQL = "";
        }

        public static class StatusLogins
        {
            public static string session = "";
            public static string UserID = "";
            public static bool StatusLogin = false;
            public static string Username = "";
            public static string Password = "";
            public static bool RememberPassword = false;
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


