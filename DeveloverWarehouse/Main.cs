using Develover.GUI;
using DevExpress.XtraBars;
using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraSplashScreen;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloverWarehouse
{
    public partial class Main : ToolbarForm, IDeveloverFormParent
    {
        public Main()
        {
            InitializeComponent();
            this.Text += " - Develover Software Co., Ltd.";
            toolbarManager.ItemClick += ToolbarManager_ItemClick;
            
        }

        Task<IDeveloverFormChild> LoadForm(object sender)
        {
            if (!(sender is BarButtonItem))
                return Task.FromResult<IDeveloverFormChild>(null);

            BarButtonItem btn = sender as BarButtonItem;

            if (!btn.Name.StartsWith("_"))
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

        private async void ToolbarManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                SplashScreenManager.CloseForm(false);

            SplashScreenManager.ShowForm(typeof(LoadingForm));
            IDeveloverFormChild form = await LoadForm(e.Item);

            if (form == null)
            {
                SplashScreenManager.CloseForm(false);
                return;
            }
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

        private void Main_Load(object sender, System.EventArgs e)
        {
        }

        public Task SetStatusAsync(string message)
        {
            return Task.Run(() =>
            {
                barButtonUserInfo.Caption = message;
            });
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None)
            {
                switch (keyData)
                {
                    case Keys.Escape:
                        break;
                    case Keys.F11:
                        WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
                        break;

                }

            }
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
    }
}
