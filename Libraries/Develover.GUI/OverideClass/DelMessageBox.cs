using Develover.Utilities;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Develover.GUI.OverideClass.Enum;

namespace Develover.GUI.OverideClass
{
    public class DelMessageBox
    {
        static string messageSystem = "Thông báo từ hệ thống";
        public DelMessageBox()
        {
        }

        public static DialogResult DelMessageBoxDefaul(string text, string caption = "Thông báo từ hệ thống", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            return XtraMessageBox.Show(text, caption, buttons, icon, defaultButton);
        }

        public static DialogResult DelMessageBoxYNC(string text, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            return XtraMessageBox.Show(text, messageSystem, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, defaultButton);
        }

        public static DialogResult DelMessageBoxYN(string text, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            return XtraMessageBox.Show(text, messageSystem, MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton);
        }

        public static DialogResult DelMessageBoxError(string text, string caption = "Có lỗi xảy ra", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Error, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            return XtraMessageBox.Show(text, caption, buttons, icon, defaultButton);
        }
        public static DialogResult DelMessageBoxPermission(EnumPermission enumPermission)
        {
            string text = "Không xác định";
            switch (enumPermission)
            {
                case EnumPermission.View:
                    {

                        text = "Bạn không có quyền xem!";
                    }
                    break;
                case EnumPermission.New:
                    {
                        text = "Bạn không có quyền thêm mới!";
                    }
                    break;
                case EnumPermission.Edit:
                    {
                        text = "Bạn không có quyền sửa!";
                    }
                    break;
                case EnumPermission.Delete:
                    {
                        text = "Bạn không có quyền xóa!";
                    }
                    break;
                case EnumPermission.Print:
                    {

                        text = "Bạn không có quyền in!";
                    }
                    break;

                case EnumPermission.Every:
                    {
                        text = "Bạn không được phép ở đây.";

                    }
                    break;
            }
            return XtraMessageBox.Show(text, messageSystem, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

        }

    }
}
