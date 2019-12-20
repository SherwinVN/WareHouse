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

namespace DeveloverWarehouse
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        IDeveloverLoginFunction flogin = new IDeveloverLoginFunction();
        public Login()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            flogin.UserName = txtUserName.Text;
            flogin.PassWord = txtPassWord.Text;
            flogin.RememberStatus = chkGhiNhoDangNhap.Checked;

            if (flogin.Login())
            {
                this.Hide();
                DeveloverOptions.sysdel.StatusLogin = true;
                DeveloverOptions.InforUser.Username = txtUserName.Text;
                DeveloverOptions.InforUser.Name = "DEV";
                DeveloverOptions.InforUser.Permission =  "Administator";

            }
            else
            {
                laberrorLogin.Text = "Tài khoản đăng nhập hoặc mật khẩu không đúng?";
                if (flogin.CountLoginFailed > 5)
                    laberrorLogin.Text = "Bạn đăng nhập sai quá nhiều lần?";
                return;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassWord.Text = "";
            txtUserName.Text = DeveloverOptions.InforUser.Username;
            txtUserName.Focus();
        }
    }
}