using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using System;
using System.Linq;

namespace Develover.GUI.Controls
{
    public class DeveloverGridLookUpEdit : GridLookUpEdit, IDeveloverControl
    {
        public DeveloverGridLookUpEdit()
        {
            Properties.NullText = "";
            Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            Properties.PopupView = new DeveloverGridView();
        }
    }
}