using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Develover.Services;
using Develover.Utilities;
using Develover.Core;
using Develover.GUI.Forms;
using Develover.GUI;
using static Develover.Utilities.Enum;

namespace DeveloverWarehouse
{
    public partial class Setting : DeveloverForm, IDeveloverFormChild
    {
        IDeveloverLoginFunction flogin = new IDeveloverLoginFunction();
        SqlDataProvider sqlDataProvider = new SqlDataProvider();
        private static bool status = false;
        public bool Status { get => status; }

        public Setting()
        {
            InitializeComponent();

            SetEnableControl();
        }

        private void SetEnableControl()
        {
            if (!DeveloverOptions.SysDel.StatusLicense || DeveloverOptions.StatusLogins.StatusLogin)
            {
                grSettingSQL.Enabled = false;
            }
            else
            {

                grSettingSQL.Enabled = true;
            }
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            DeveloverOptions.InfoDatabase.ServerName = txtServerName.Text.Trim();
            DeveloverOptions.InfoDatabase.UsernameSQL = txtUserName.Text.Trim();
            DeveloverOptions.InfoDatabase.PasswordSQL = txtPassWord.Text.Trim();
            DeveloverOptions.InfoDatabase.DatabaseName = txtDatabaseName.Text.Trim();

            if (!sqlDataProvider.CheckLogin())
            {
                laberror.Text = "Kết nối tới SERVER [" + DeveloverOptions.InfoDatabase.ServerName + "] thất bại ?\n" + DeveloverOptions.SysDel.MessageError + ".";
            }
            else
            if (!sqlDataProvider.ChangeDataBase())
            {
                laberror.Text = "Không thể truy cập Database [" + DeveloverOptions.InfoDatabase.DatabaseName + "] ?\n" + DeveloverOptions.SysDel.MessageError + ".";
            }
            else laberror.Text = "Kết nối SERVER [" + DeveloverOptions.InfoDatabase.ServerName + "] - DATABASE [" + DeveloverOptions.InfoDatabase.DatabaseName + "] Thành công!";
            SetEnableControl();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            tnpSetting.SelectedPageIndex = 0;
            {
                new IDeveloverLoginFunction().GetInfoServer();
                txtServerName.Text = DeveloverOptions.InfoDatabase.ServerName;
                txtUserName.Text = DeveloverOptions.InfoDatabase.UsernameSQL;
                txtPassWord.Text = DeveloverOptions.InfoDatabase.PasswordSQL;
                txtDatabaseName.Text = DeveloverOptions.InfoDatabase.DatabaseName;
                txtServerName.Focus();
            }
            if (DeveloverOptions.StatusLogins.StatusLogin)
            {
                grSettingSQL.Enabled = false;            
            }

            txtCodePersonal.Text = DeveloverOptions.SysDel.CodePersonal;
            labTextLicense.Text = String.Format(StringMessage.TextLicense, new object[] { DeveloverOptions.SysDel.GetTextTypeLicense(), DeveloverOptions.SysDel.TypeLicense == TypeLicenses.None || DeveloverOptions.SysDel.TypeLicense == TypeLicenses.Free? "_ //_ //_" :  DeveloverOptions.SysDel.ExpirationDate.ToShortDateString() });
        }

        private void butActive_Click(object sender, EventArgs e)
        {
            if (flogin.CheckLicense(txtCodePersonal.Text))
            {
                flogin.setLicense();
                status = DeveloverOptions.SysDel.StatusLicense;
                SetEnableControl();
                flogin.GetLicense();
            }
            labTextLicense.Text = String.Format(StringMessage.TextLicense, new object[] { DeveloverOptions.SysDel.GetTextTypeLicense(), DeveloverOptions.SysDel.TypeLicense == TypeLicenses.None || DeveloverOptions.SysDel.TypeLicense == TypeLicenses.Free ? "_ //_ //_" : DeveloverOptions.SysDel.ExpirationDate.ToShortDateString() });
        }
    }
}
