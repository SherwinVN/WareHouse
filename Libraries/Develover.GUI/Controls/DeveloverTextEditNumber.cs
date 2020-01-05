using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using static Develover.Utilities.Enum;

namespace Develover.GUI.Controls
{
    public class DeveloverTextEditNumber : DeveloverTextEdit, IDeveloverControl
    {
        public DeveloverTextEditNumber() {
            Properties.Mask.MaskType = MaskType.Numeric;
            TypeFieldColumns = EnumTypeColumns.Text;
        }
    }
}
