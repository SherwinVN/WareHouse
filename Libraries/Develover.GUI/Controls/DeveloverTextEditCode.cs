using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Develover.GUI.Controls
{
    public class DeveloverTextEditCode : DeveloverTextEdit, IDeveloverControl
    {
        public DeveloverTextEditCode() {
            Properties.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
