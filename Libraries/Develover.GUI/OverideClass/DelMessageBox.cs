using Develover.Utilities;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Develover.GUI.OverideClass
{
    public class DelMessageBox
    {
        public DelMessageBox()
        {
        }

        public static DialogResult DelMessageBoxDefaul (string text, string caption ="Thông báo từ hệ thống", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
           return XtraMessageBox.Show( text,  caption,  buttons, icon, defaultButton);
        }
        public static DialogResult DelMessageBoxYNO(string text, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            return XtraMessageBox.Show(text, "Thông báo từ hệ thống", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, defaultButton);
        }
        public static DialogResult DelMessageBoxError(string text, string caption = "Có lỗi xảy ra", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Error, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            return XtraMessageBox.Show(text, caption, buttons, icon, defaultButton);
        }
  
    }
}
