using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;

namespace Develover.GUI.Controls
{
    public class DeveloverTextEditNumber : DeveloverTextEdit, IDeveloverControl
    {
        public DeveloverTextEditNumber() {
            Properties.Mask.MaskType = MaskType.Numeric;
        }
    }
}
