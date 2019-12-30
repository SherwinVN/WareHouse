using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using static Develover.Utilities.Enum;

namespace Develover.GUI.Controls
{
    public class DeveloverTimeEdit: TimeEdit, IDeveloverControl
    {
        string fieldBinding;
        bool isGUID;
        EnumTypeColumns typeFieldColumns;
        public string FieldBinding { get => fieldBinding; set => fieldBinding = value; }
        public EnumTypeColumns TypeFieldColumns { get => typeFieldColumns; set => typeFieldColumns = value; }
        public bool IsGUID { get => isGUID; set => isGUID = value; }

        public DeveloverTimeEdit()
        {
            Properties.Mask.EditMask = "hh:mm tt";
             Properties.Mask.MaskType = MaskType.DateTime;
        }
    }
}
