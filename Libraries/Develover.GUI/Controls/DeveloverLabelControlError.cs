using DevExpress.XtraEditors;
using System.Drawing;
using static Develover.Utilities.Enum;

namespace Develover.GUI.Controls
{
    public class DeveloverLabelControlError : LabelControl, IDeveloverControl
    {
        string fieldBinding;
        EnumTypeColumns typeFieldColumns;
        public string FieldBinding { get => fieldBinding; set => fieldBinding = value; }
        public EnumTypeColumns TypeFieldColumns { get => typeFieldColumns; set => typeFieldColumns = value; }
        public DeveloverLabelControlError()
        {
            ForeColor = Color.Red;
        }
    }
}
