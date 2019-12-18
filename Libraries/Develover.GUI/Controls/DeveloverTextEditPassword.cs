using DevExpress.XtraEditors;
namespace Develover.GUI.Controls
{
    public class DeveloverTextEditPassword : DeveloverTextEdit, IDeveloverControl
    {
        public DeveloverTextEditPassword() {
            Properties.PasswordChar = '*';
        }
    }
}
