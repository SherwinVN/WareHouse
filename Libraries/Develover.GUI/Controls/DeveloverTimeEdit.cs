using DevExpress.XtraEditors;
namespace Develover.GUI.Controls
{
    public class DeveloverTimeEdit: TimeEdit, IDeveloverControl
    {
        public DeveloverTimeEdit()
        {
            Mask.EditMask = "hh:mm tt";
            Mask.MaskType = MaskType.DateTime;
        }
    }
}
