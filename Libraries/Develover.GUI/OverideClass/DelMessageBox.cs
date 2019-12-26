using Develover.Utilities;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using static Develover.Utilities.Enum;

namespace Develover.GUI.OverideClass
{
    public class DelMessageBox
    {
        public DelMessageBox()
        {
        }

        public static DialogResult DelMessageBoxDefaul(string text, string caption = "Thông báo từ hệ thống", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            return XtraMessageBox.Show(text, caption, buttons, icon, defaultButton);
        }

        public static DialogResult DelMessageBoxYNC(string text, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            return XtraMessageBox.Show(text, StringMessage.MessageSystem, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, defaultButton);
        }

        public static DialogResult DelMessageBoxYN(string text, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            return XtraMessageBox.Show(text, StringMessage.MessageSystem, MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton);
        }

        public static DialogResult DelMessageBoxError(string text, string caption = "Có lỗi xảy ra", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Error, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            return XtraMessageBox.Show(text, caption, buttons, icon, defaultButton);
        }
       
        public static DialogResult DelMessageBoxPermission(EnumPermission enumPermission)
        {
            string text = StringMessage.Unknown;
            switch (enumPermission)
            {
                case EnumPermission.View:
                    {

                        text = StringMessage.PermissionDenialView;
                    }
                    break;
                case EnumPermission.New:
                    {
                        text = StringMessage.PermissionDenialNew;
                    }
                    break;
                case EnumPermission.Edit:
                    {
                        text = StringMessage.PermissionDenialEdit;
                    }
                    break;
                case EnumPermission.Delete:
                    {
                        text = StringMessage.PermissionDenialDelete;
                    }
                    break;
                case EnumPermission.Print:
                    {

                        text = StringMessage.PermissionDenialPrint;
                    }
                    break;

                case EnumPermission.Denial:
                    {
                        text = StringMessage.PermissionDenial;

                    }
                    break;
            }
            return XtraMessageBox.Show(text, StringMessage.MessageSystem, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

        }

    }
}
