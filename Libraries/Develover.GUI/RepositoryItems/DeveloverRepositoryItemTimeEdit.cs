using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develover.GUI.RepositoryItems
{
    public class DeveloverRepositoryItemTimeEdit : RepositoryItemTimeEdit
    {
        public DeveloverRepositoryItemTimeEdit() : base()
        {
            Mask.EditMask = "hh:mm tt";
            Mask.MaskType = MaskType.DateTime;
        }
    }
}
