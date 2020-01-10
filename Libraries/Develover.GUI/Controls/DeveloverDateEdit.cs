using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using static Develover.Utilities.Enum;

namespace Develover.GUI.Controls
{
    public class DeveloverDateEdit : DateEdit, IDeveloverControl
    {
        string fieldBinding;
        bool isGUID;
        EnumTypeColumns typeFieldColumns;
        public string FieldBinding { get => fieldBinding; set => fieldBinding = value; }
        public EnumTypeColumns TypeFieldColumns { get => typeFieldColumns; set => typeFieldColumns = value; }
        public bool IsGUID { get => isGUID; set => isGUID = value; }

        public DeveloverDateEdit()
        {
            Properties.CloseUpKey = new KeyShortcut(Keys.Space);
            TypeFieldColumns = EnumTypeColumns.Date;
        }

    }
}
