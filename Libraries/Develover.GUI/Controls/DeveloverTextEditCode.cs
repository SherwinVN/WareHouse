
using DevExpress.XtraEditors;
using System.Windows.Forms;
using static Develover.Utilities.Enum;

namespace Develover.GUI.Controls
{
    public class DeveloverTextEditCode : DeveloverTextEdit, IDeveloverControl
    {
        public DeveloverTextEditCode() {
            Properties.CharacterCasing = CharacterCasing.Upper;
            TypeFieldColumns = EnumTypeColumns.Text;
        }
    }
}
