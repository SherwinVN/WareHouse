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
using DevExpress.XtraSplashScreen;
using Develover.GUI.Forms;
using Develover.GUI;
using DeveloverWarehouse.Modules.File;

namespace DeveloverWarehouse
{
    public partial class Login : DeveloverForm, IDeveloverFormChild
    {
        IDeveloverLoginFunction flogin = new IDeveloverLoginFunction();
        public Login()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {

            SplashScreenManager.CloseForm(false);
            SplashScreenManager.ShowForm(typeof(LoadingForm));

            DeveloverOptions.StatusLogins.Username = txtUserName.Text;
            DeveloverOptions.StatusLogins.Password = txtPassWord.Text;
            DeveloverOptions.StatusLogins.RememberPassword = chkGhiNhoDangNhap.Checked;

            flogin.GetInfoServer();

            Functions functions = new Functions();
            if (!functions.dataBase.CheckLogin() || !functions.dataBase.ChangeDataBase())
            {
                Setting setting = new Setting();
                setting.ShowDialog();
            }

            flogin.UserName = txtUserName.Text.ToLower();
            flogin.PassWord = txtPassWord.Text;
            flogin.RememberStatus = chkGhiNhoDangNhap.Checked;

            if (flogin.Login())
            {
                this.Hide();
            }
            else
            {
                laberrorLogin.Text = "Tài khoản đăng nhập hoặc mật khẩu không đúng?";
                if (flogin.CountLoginFailed > 5)
                    laberrorLogin.Text = "Bạn đăng nhập sai quá nhiều lần?";
            }
            SplashScreenManager.CloseForm(false);
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            flogin.GetLicense();
            if (!DeveloverOptions.SysDel.StatusLicense || DeveloverOptions.SysDel.ExpirationDate < DateTime.Now)
            {
                Setting setting = new Setting();
                setting.ShowDialog();
                if (!setting.Status) Application.Exit();
            }

            if (!flogin.checkRegistryKey())
            {
                Setting setting = new Setting();
                setting.ShowDialog();
            }

            flogin.GetInfoServer();
            flogin.GetInfoUser();
            chkGhiNhoDangNhap.Checked = DeveloverOptions.StatusLogins.RememberPassword;
            txtUserName.Text = DeveloverOptions.StatusLogins.Username;
            txtPassWord.Text = DeveloverOptions.StatusLogins.Password;
            txtUserName.Focus();
        }
    }
}
