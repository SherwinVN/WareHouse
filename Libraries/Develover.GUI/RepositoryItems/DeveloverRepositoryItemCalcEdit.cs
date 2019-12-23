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
    public class DeveloverRepositoryItemCalcEdit : RepositoryItemCalcEdit
    {
        public DeveloverRepositoryItemCalcEdit() : base()
        {
            AutoHeight = false;
            Mask.UseMaskAsDisplayFormat = true;
            ShowCloseButton = true;
           NullText = "0";
            CloseUpKey = new KeyShortcut(Keys.Space);
            ShowPopupShadow = true;
        }
    }
}
