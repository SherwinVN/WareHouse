using DevExpress.XtraEditors;
using static Develover.Utilities.Enum;
namespace Develover.GUI.Controls
{
    public class DeveloverTextEditReadOnly : DeveloverTextEdit, IDeveloverControl
    {
        public DeveloverTextEditReadOnly() {
            Properties.ReadOnly = true;
            TypeFieldColumns = EnumTypeColumns.Text;
        }
    }
}
