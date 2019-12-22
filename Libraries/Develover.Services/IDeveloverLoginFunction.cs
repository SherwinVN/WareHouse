using Develover.Core;
using Develover.Utilities;
using DevExpress.XtraEditors;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Develover.Services
{
    public class IDeveloverLoginFunction
    {
        private SqlDataProvider sqlDataProvider = new SqlDataProvider();
        private string userName = "", passWord = "", SQLPassWord = "";
        private bool rememberStatus = false;
        private static int countLoginFailed = 0;

        public bool RememberStatus { get => rememberStatus; set => rememberStatus = value; }
        public string PassWord { set => passWord = value; }
        public string UserName { get => userName; set => userName = value; }
        public int CountLoginFailed { get => countLoginFailed; }
        public IDeveloverLoginFunction()
        {
            GetInfoServer();
        }
        public bool Login()
        {
            getSQLPassWord();
            if (countLoginFailed > 5) return false;
            else
            if (passWord == SQLPassWord)
            {
                setInfoServer();
                getInfo();
                getInfoCompany();
                countLoginFailed = 0; return true;
            }
            else
            {
                countLoginFailed++; return false;
            };
        }

        private void getInfo()
        {
            DeveloverOptions.StatusLogins.StatusLogin = true;
            DeveloverOptions.StatusLogins.Username = userName;
            DeveloverOptions.StatusLogins.Password = passWord;
            DeveloverOptions.InfoUser.Username = userName;
            using (DataTable data = sqlDataProvider.GetDataTable("SELECT Name,Address FROM sysDELUser WHERE UserName = '" + userName + "'"))
            {
                if (data.Rows.Count > 0)
                {
                    DeveloverOptions.InfoUser.Name = data.Rows[0]["Name"]?.ToString();
                    DeveloverOptions.InfoUser.Permission = "Administator";
                    DeveloverOptions.InfoUser.Address = data.Rows[0]["Address"]?.ToString();
                }
            }

        }
        private void getInfoCompany()
        {
            using (DataTable data = sqlDataProvider.GetDataTable("SELECT ID,CodePersonal,Name,Acronym,Address ,NameDirector,Code,MobilePhone,Landline,Email,Website FROM sysDELOptions WHERE CodePersonal = '" + DeveloverOptions.SysDel.CodePersonal + "'"))
            {
                if (data.Rows.Count > 0)
                {
                    DeveloverOptions.InfoCompany.Name = data.Rows[0]["Name"]?.ToString();
                    DeveloverOptions.InfoCompany.Acronym = data.Rows[0]["Acronym"]?.ToString();
                    DeveloverOptions.InfoCompany.Address = data.Rows[0]["Address"]?.ToString();
                    DeveloverOptions.InfoCompany.NameDirector = data.Rows[0]["NameDirector"]?.ToString();
                    DeveloverOptions.InfoCompany.CodePersonal = data.Rows[0]["CodePersonal"]?.ToString();
                    DeveloverOptions.InfoCompany.MobilePhone = data.Rows[0]["MobilePhone"]?.ToString();
                    DeveloverOptions.InfoCompany.Landline = data.Rows[0]["Landline"]?.ToString();
                    DeveloverOptions.InfoCompany.Email = data.Rows[0]["Email"]?.ToString();
                    DeveloverOptions.InfoCompany.Website = data.Rows[0]["Website"]?.ToString();
                }
            }
        }

        private void getSQLPassWord()
        {
            SQLPassWord = sqlDataProvider.ExecuteScalar("SELECT PassWord FROM sysDELUser WHERE UserName = '" + userName + "'")?.ToString();
        }

        public void GetInfoMachine()
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor"))
            {
                foreach (ManagementObject share in searcher.Get())
                {
                    DeveloverOptions.SysDel.ProcessorId = share.GetPropertyValue("ProcessorId").ToString();
                    DeveloverOptions.SysDel.SerialNumber = share.GetPropertyValue("SerialNumber").ToString();
                }
            }
        }

        public bool CheckLicense()
        {
            GetInfoMachine();
            return CheckLicenseServer() ? true : false;
        }

        private bool CheckLicenseServer()
        {

            return true;
        }

        public void GetInfoServer()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Develover");
            if (key != null)
            {
                DeveloverOptions.InfoDatabase.ServerName = key.GetValue("ServerName")?.ToString();
                DeveloverOptions.InfoDatabase.DatabaseName = key.GetValue("DatabaseName")?.ToString();
                DeveloverOptions.InfoDatabase.UsernameSQL = key.GetValue("UsernameSQL")?.ToString();
                DeveloverOptions.InfoDatabase.PasswordSQL = key.GetValue("PasswordSQL")?.ToString();
                key.Close();
            }

        }
        public void GetInfoUser()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Develover");
            if (key != null)
            {
                DeveloverOptions.StatusLogins.Username = key.GetValue("Username")?.ToString();
                DeveloverOptions.StatusLogins.Password = key.GetValue("Password")?.ToString();
                DeveloverOptions.StatusLogins.RememberPassword = false;
                bool.TryParse( key.GetValue("RememberPassword")?.ToString(),out DeveloverOptions.StatusLogins.RememberPassword);
                key.Close();
            }
        }

        public bool checkRegistryKey()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Develover");
            if (registryKey != null)
            {
                try
                {
                    return (registryKey.GetValueNames().Contains("NameApplication"));
                }
                catch (Exception ex)
                {
                    DeveloverOptions.SysDel.MessageError = ex.Message;
                    return false;
                };
            }
            else
            {
                return false;
            }
        }

        private void setInfoServer()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Develover");

            key.SetValue("NameApplication", "Develover");
            key.SetValue("ServerName", DeveloverOptions.InfoDatabase.ServerName);
            key.SetValue("DatabaseName", DeveloverOptions.InfoDatabase.DatabaseName);
            key.SetValue("UsernameSQL", DeveloverOptions.InfoDatabase.UsernameSQL);
            key.SetValue("PasswordSQL", DeveloverOptions.InfoDatabase.PasswordSQL);

            key.SetValue("Username", DeveloverOptions.StatusLogins.Username);
            key.SetValue("Password", rememberStatus ? DeveloverOptions.InfoDatabase.PasswordSQL : "");
            key.SetValue("RememberPassword", rememberStatus);
            key.Close();
        }     
    }
}
