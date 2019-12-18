using DevExpress.XtraEditors;

namespace Develover.GUI.Controls
{
    public class DeveloverSplitterControl : SplitterControl, IDeveloverControl
    {
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
