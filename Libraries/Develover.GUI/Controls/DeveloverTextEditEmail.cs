using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;

namespace Develover.GUI.Controls
{
    public class DeveloverTextEditEmail : DeveloverTextEdit, IDeveloverControl
    {
        public DeveloverTextEditEmail()
        {
            Properties.Mask.MaskType = MaskType.RegEx;
            Properties.Mask.EditMask = @"(\w|[.\-])+@(\w|[\-]+.)*(\w|[\-]){2,63}.[a-zA-Z]{2,4}";
            Properties.Mask.PlaceHolder = '_';
            Properties.Mask.BeepOnError = true;
            Properties.Mask.UseMaskAsDisplayFormat = true;
        }
    }
}
