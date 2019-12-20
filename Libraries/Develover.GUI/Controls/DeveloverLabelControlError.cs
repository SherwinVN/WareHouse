using DevExpress.XtraEditors;
using System.Drawing;

namespace Develover.GUI.Controls
{
    public class DeveloverLabelControlError : LabelControl, IDeveloverControl
    {
        public DeveloverLabelControlError()
        {
            ForeColor = Color.Red;
        }
    }
}
