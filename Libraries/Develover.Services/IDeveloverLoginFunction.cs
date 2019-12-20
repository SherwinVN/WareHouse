using Develover.Core;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develover.Services
{
    public class IDeveloverLoginFunction
    {
        SqlDataProvider sqlDataProvider = new SqlDataProvider();
        private string userName = "", passWord = "", SQLPassWord = "";
        private bool rememberStatus = false;
        private static int countLoginFailed = 0;

        public bool RememberStatus { get => rememberStatus; set => rememberStatus = value; }
        public string PassWord { set => passWord = value; }
        public string UserName { get => userName; set => userName = value; }
        public int CountLoginFailed { get => countLoginFailed; }

        public bool Login()
        {
            getSQLPassWord();
            if (countLoginFailed > 5) return false;
            else
            if (passWord == SQLPassWord)
            {
                countLoginFailed = 0; return true;
            }
            else
            {
                countLoginFailed++; return false;
            };
        }

        private void getSQLPassWord()
        {
            SQLPassWord = sqlDataProvider.ExecuteScalar("SELECT PassWord FROM sysDELUser WHERE UserName = '" + userName + "'")?.ToString();
        }
        private void remember()
        {
            if (rememberStatus)
            {
                throw new NotImplementedException();

            }
        }

    }
}
