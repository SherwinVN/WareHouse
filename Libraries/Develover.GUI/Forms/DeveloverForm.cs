using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Develover.GUI.Forms
{
    public class DeveloverForm: XtraForm, IDeveloverForm
    {
        bool whenCloseForm_ = true;

        public bool iwhenCloseForm {
            get { return whenCloseForm_; }
            set { whenCloseForm_ = value; }
        }
        public DeveloverForm() {
            KeyPreview = true;
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None)
            {
                switch ( keyData)
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
