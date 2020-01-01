using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;

namespace Develover.GUI.Controls
{
    public class DeveloverTextEditPercent : DeveloverTextEdit, IDeveloverControl
    {
        public DeveloverTextEditPercent()
        {
            Properties.Mask.MaskType = MaskType.Numeric;
            Properties.Mask.EditMask = "p";
            Properties.Mask.PlaceHolder = '_';
            Properties.Mask.BeepOnError = true;
            Properties.Mask.UseMaskAsDisplayFormat = true;
        }
    }
}
