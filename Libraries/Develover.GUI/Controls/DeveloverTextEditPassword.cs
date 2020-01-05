using DevExpress.XtraEditors;
using static Develover.Utilities.Enum;
namespace Develover.GUI.Controls
{
    public class DeveloverTextEditPassword : DeveloverTextEdit, IDeveloverControl
    {
        public DeveloverTextEditPassword() {
            Properties.PasswordChar = '*';
            TypeFieldColumns = EnumTypeColumns.Text;
        }
    }
}
