using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Develover.GUI.RepositoryItems
{
    public class DeveloverRepositoryItemDateEdit : RepositoryItemDateEdit
    {
        public DeveloverRepositoryItemDateEdit() : base()
        {
            CloseUpKey = new KeyShortcut(Keys.Space);
        }
    }
}
