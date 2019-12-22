using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Develover.GUI.Forms
{
    public class DeveloverForm : XtraForm, IDeveloverForm
    {
        bool permissionNew = false;
        bool permissionEdit = false;
        bool permissionDelete = false;
        bool permissionPrint = false;
        string stringNameForm = "";

        bool whenCloseForm_ = true;

        public bool PermissionNew { get => permissionNew; set => permissionNew = value; }
        public bool PermissionEdit { get => permissionEdit; set => permissionEdit = value; }
        public bool PermissionDelete { get => permissionDelete; set => permissionDelete = value; }
        public string StringNameForm { get => stringNameForm; set => stringNameForm = value; }
        public bool PermissionPrint { get => permissionPrint; set => permissionPrint = value; }

        public bool WhenCloseForm_ { get => whenCloseForm_; set => whenCloseForm_ = value; }
        public bool iwhenCloseForm
        {
            get { return WhenCloseForm_; }
            set { WhenCloseForm_ = value; }
        }


        public DeveloverForm()
        {
            KeyPreview = true;
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None)
            {
                switch (keyData)
                {
                    case Keys.Escape:
                        if (iwhenCloseForm) this.Close();
                        break;
                    case Keys.F11:
                        WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
                        break;

                }

            }
            return base.ProcessDialogKey(keyData);
        }

    }
}
