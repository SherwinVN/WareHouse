using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Develover.GUI.Controls
{
    public class DeveloverCalcEdit : CalcEdit, IDeveloverControl
    {
        string fieldBinding;
        bool isGUID;
        Enum.EnumTypeColumns typeFieldColumns;
        public string FieldBinding { get => fieldBinding; set => fieldBinding = value; }
        public Enum.EnumTypeColumns TypeFieldColumns { get => typeFieldColumns; set => typeFieldColumns = value; }
        public bool IsGUID { get => isGUID; set => isGUID = value; }

        public DeveloverCalcEdit()
        {
            Properties.Mask.UseMaskAsDisplayFormat = true;
            Properties.ShowCloseButton = true;
            Properties.NullText = "0";
            Properties.CloseUpKey = new KeyShortcut(Keys.Space);
            Properties.ShowPopupShadow = true;

            TypeFieldColumns = Enum.EnumTypeColumns.Number;
        }

    }
}
