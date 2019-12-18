using Develover.GUI.Controls;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors.Repository;
using System;

namespace Develover.GUI.RepositoryItems
{
    public class DeveloverRepositoryItemGridLookUpEdit : RepositoryItemGridLookUpEdit
    {
        public DeveloverRepositoryItemGridLookUpEdit() : base()
        {
            PopupView = new DeveloverGridView();
        }
    }
}
