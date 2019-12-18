using DevExpress.XtraEditors;
namespace Develover.GUI.Controls
{
    public class DeveloverTextEditReadOnly : DeveloverTextEdit, IDeveloverControl
    {
        public DeveloverTextEditReadOnly() {
            Properties.ReadOnly = true;
        }
    }
}
