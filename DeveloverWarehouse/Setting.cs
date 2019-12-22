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

namespace DeveloverWarehouse
{
    public partial class Setting : DeveloverForm, IDeveloverFormChild
    {
        SqlDataProvider sqlDataProvider = new SqlDataProvider();
        public Setting()
        {
            InitializeComponent();
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
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            new IDeveloverLoginFunction().GetInfoServer();
            txtServerName.Text = DeveloverOptions.InfoDatabase.ServerName;
            txtUserName.Text = DeveloverOptions.InfoDatabase.UsernameSQL;
            txtPassWord.Text = DeveloverOptions.InfoDatabase.PasswordSQL;
            txtDatabaseName.Text = DeveloverOptions.InfoDatabase.DatabaseName;
            txtServerName.Focus();
        }
    }
}
