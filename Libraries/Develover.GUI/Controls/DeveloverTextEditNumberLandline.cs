using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;

namespace Develover.GUI.Controls
{
    public class DeveloverTextEditNumberLandline : DeveloverTextEdit, IDeveloverControl
    {
        public DeveloverTextEditNumberLandline() {

            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"(\d?\d?\d?) \d \d\d\d \d\d\d\d";
            Properties.Mask.PlaceHolder = '_';
            Properties.Mask.BeepOnError = true;
            Properties.Mask.UseMaskAsDisplayFormat = true;
        }
    }
}
