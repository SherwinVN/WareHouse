using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using static Develover.Utilities.Enum;

namespace Develover.GUI.Controls
{
    public class DeveloverTextEditNumberPhone : DeveloverTextEdit, IDeveloverControl
    {
        public DeveloverTextEditNumberPhone()
        {
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"(\d?\d?\d?) \d\d\d-\d\d\d\d";
            Properties.Mask.PlaceHolder = '_';
            Properties.Mask.BeepOnError = true;
            Properties.Mask.UseMaskAsDisplayFormat = true;
            TypeFieldColumns = EnumTypeColumns.Text;

        }
    }
}
