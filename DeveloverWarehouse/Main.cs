using Develover.GUI;
using Develover.GUI.OverideClass;
using Develover.Services;
using Develover.Utilities;
using DeveloverWarehouse.Modules.File;
using DeveloverWarehouse.Modules.Sales;
using DevExpress.XtraBars;
using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraSplashScreen;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Develover.GUI.OverideClass.Localization;
/// <summary>
/// Test push :))
/// </summary>
namespace DeveloverWarehouse
{
    public partial class Main : ToolbarForm, IDeveloverFormParent
    {
        IDeveloverLoginFunction flogin = new IDeveloverLoginFunction();
        Login login;
        Timer timer;

        public Main()
        {

            InitializeComponent();
            this.Text += " - Develover Software Co., Ltd.";
            toolbarManager.ItemClick += ToolbarManager_ItemClick;
            _010100.Enabled = false;
        }

        Task<IDeveloverFormChild> GetForm(object sender)
        {
            if (!(sender is BarButtonItem))
                return Task.FromResult<IDeveloverFormChild>(null);

            BarButtonItem btn = sender as BarButtonItem;

            if (!btn.Name.StartsWith("_"))
                return Task.FromResult<IDeveloverFormChild>(null);

            if (btn.Name.StartsWith("_1"))
                return Task.FromResult<IDeveloverFormChild>(null);


            if (btn.Tag == null)
                return Task.FromResult<IDeveloverFormChild>(null);
            return Task.Run(() =>
            {
                Type type = Type.GetType("DeveloverWarehouse.Modules." + btn.Tag.ToString());
                IDeveloverFormChild f = null;
                for (int i = 0; i < MdiChildren.Length; i++)
                {
                    f = (IDeveloverFormChild)MdiChildren[i];
                    if (f.GetType().FullName == type.FullName)
                    {
                        return f;
                    }
                }

                f = (IDeveloverFormChild)Activator.CreateInstance(type);

                return f;
            });
        }

        private void ToolbarManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadForm(e.Item);
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            RunTime();
            login = new Login();
            login.ShowDialog();
            LoadInfoApplication();
            LoadGridLocalizer();
        }

        private static void LoadGridLocalizer()
        {
            GridLocalizer.Active = new DeveloverGridLocalizer();
        }

        private void LoadInfoApplication()
        {
            barButtonServerName.Caption = "Máy chủ: " + DeveloverOptions.InfoDatabase.ServerName;
            barButtonDatabaseName.Caption = "CSDL: " + DeveloverOptions.InfoDatabase.DatabaseName;
            barUserLogin.Caption = DeveloverOptions.InfoUser.Name;
            barUserLogin.Caption = DeveloverOptions.InfoUser.Name;
        }

        private void RunTime()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            barButtonDateTime.Caption = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        public Task SetStatusAsync(string message)
        {
            return Task.Run(() =>
            {
                barButtonStatus.Caption = message;
            });
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        break;
                    case Keys.F11:
                        WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
                        break;
                    case Keys.W:
                        {
                            //if (MdiChildren.Length > 0)
                            //{
                            //    n
                            //}
                            //else { Application.Exit(); }
                        }
                        break;
                }
            }


        }
        protected override bool ProcessDialogKey(Keys keyData)
        {

            return base.ProcessDialogKey(keyData);
        }

        private void Bei_viewatabpage_EditValueChanged(object sender, EventArgs e)
        {
            this.SuspendLayout();
            tabbedMdiManager.MdiParent = (bool)((BarEditItem)sender).EditValue ? null : this;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void BarButtonHowTo_ItemClick(object sender, ItemClickEventArgs e)
        {

            var form = new Form1();
            form.MdiParent = this;
            form.Show();
        }

        private void _010100_ItemClick(object sender, ItemClickEventArgs e)
        {
            _010100.Enabled = false;
            _010200.Enabled = true;

            if (!DeveloverOptions.StatusLogins.StatusLogin)
                login.ShowDialog();

        }

        private void _010200_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (DeveloverOptions.StatusLogins.StatusLogin)
            {
                if (MdiChildren.Length > 0)
                {
                    DialogResult dialogResult = DelMessageBox.DelMessageBoxYNC("Hiện có phiếu đang mở bạn có muốn thoát?", MessageBoxDefaultButton.Button1);
                    if (dialogResult == DialogResult.Yes)
                    {
                        for (int i = 0; i < MdiChildren.Length; i++)
                        {
                            IDeveloverFormChild f = (IDeveloverFormChild)MdiChildren[0];
                            f.Close();
                            i--;
                        }
                    }
                }
                DeveloverOptions.StatusLogins.StatusLogin = false;
                login.ShowDialog();
            }
        }

        private void _010600_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExitApplications();
        }

        private void ExitApplications()
        {
            if (MdiChildren.Length > 0)
            {
                if (DelMessageBox.DelMessageBoxYN(StringMessage.QuestionResetApplication) == DialogResult.Yes)
                    Application.Exit();
            }
            else { Application.Exit(); }
        }

        private void _010700_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (DeveloverOptions.StatusLogins.StatusLogin)
            {
                ShowFormChildren(false);
                login.ShowDialog();
                ShowFormChildren(true);
            }
        }
        public void ShowFormChildren(bool show)
        {
            foreach (Form form in MdiChildren)
            {
                DeveloverOptions.StatusLogins.StatusLogin = show;
                IDeveloverFormChild f = (IDeveloverFormChild)form;
                if (show) f.Show(); else f.Hide();
            }
        }

        private void _010502_ItemClick(object sender, ItemClickEventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
        }

        private void barButtonTasks_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void _010507_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadForm(sender);
        }

        private async void LoadForm(object sender)
        {

            SplashScreenManager.CloseForm(false);
            SplashScreenManager.ShowForm(typeof(LoadingForm));

            IDeveloverFormChild form = await GetForm(sender);
            if (form == null)
            {
                SplashScreenManager.CloseForm(false);
                return;
            }

            if (!DeveloverOptions.StatusLogins.StatusLogin) return;

            for (int i = 0; i < MdiChildren.Length; i++)
            {
                IDeveloverFormChild f = (IDeveloverFormChild)MdiChildren[i];
                if (f.GetType().FullName == form.GetType().FullName)
                {
                    SplashScreenManager.CloseForm(false);
                    f.Activate();
                    return;
                }
            }

            form.MdiParent = this;
            form.Show();
            SplashScreenManager.CloseForm(false);
        }

        private void _010506_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void _010505_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadForm(sender);

        }

        private void _010503_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadForm(sender);
        }

        private void _010504_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadForm(sender);
        }

        private void _010800_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                if (DelMessageBox.DelMessageBoxYN(StringMessage.QuestionResetApplication) == DialogResult.Yes)
                    Application.Restart();
            }
            else { Application.Restart(); }
        }

        private void _010501_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadForm(sender);
        }
    }
}
