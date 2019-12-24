using DevExpress.XtraEditors;
using static Develover.Utilities.Enum;

namespace Develover.GUI.Controls
{
    public class DeveloverSplitterControl : SplitterControl, IDeveloverControl
    {
        string fieldBinding;
        EnumTypeColumns typeFieldColumns;
        public string FieldBinding { get => fieldBinding; set => fieldBinding = value; }
        public EnumTypeColumns TypeFieldColumns { get => typeFieldColumns; set => typeFieldColumns = value; }
        public DeveloverSplitterControl() {
            Name = "SplitterControl";   
            MinSize = 0;
            MinExtra = 0;
            ShowSplitGlyph = DevExpress.Utils.DefaultBoolean.True;

            Paint += DeveloverSplitterControl_Paint;
            
        }

        private void DeveloverSplitterControl_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

    }
}
