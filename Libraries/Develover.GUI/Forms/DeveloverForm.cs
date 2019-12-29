using Develover.GUI.OverideClass;
using Develover.Utilities;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using static Develover.Utilities.Enum;

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

        public void LoadPermission()
        {
            PermissionNew = true;
            PermissionEdit = true;
            PermissionDelete = true;
            PermissionPrint = true;
        }

        public DeveloverForm()
        {
            KeyPreview = true;
            LoadPermission();
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None)
            {
                switch (keyData)
                {
                    case Keys.Escape:
                        if (iwhenCloseForm)
                            this.Close();
                        else
                           if (DelMessageBox.DelMessageBoxYN(StringMessage.QuestionCloseForm) == DialogResult.Yes)
                            this.Close();
                        break;
                    case Keys.F11:
                        WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
                        break;

                }

            }
            return base.ProcessDialogKey(keyData);
        }

        #region CheckPermission
        public bool CheckView()
        {
            bool boo = true;

            if (!boo)
            {
                DelMessageBox.DelMessageBoxPermission(EnumPermission.View);
            }
            return boo;
        }
        public bool CheckNew()
        {
            bool boo = true;

            if (!boo)
            {
                DelMessageBox.DelMessageBoxPermission(EnumPermission.New);
            }
            return boo;
        }
        public bool CheckEdit()
        {
            bool boo = true;

            if (!boo)
            {
                DelMessageBox.DelMessageBoxPermission(EnumPermission.Edit);
            }
            return boo;
        }

        public bool CheckDelete()
        {
            bool boo = true;

            if (!boo)
            {
                DelMessageBox.DelMessageBoxPermission(EnumPermission.Delete);
            }
            return boo;
        }
        public bool CheckPrint()
        {
            bool boo = true;

            if (!boo)
            {
                DelMessageBox.DelMessageBoxPermission(EnumPermission.Print);
            }
            return boo;
        }
        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DeveloverForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 270);
            this.Name = "DeveloverForm";
            this.Load += new System.EventHandler(this.DeveloverForm_Load);
            this.ResumeLayout(false);

        }

        private void DeveloverForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
