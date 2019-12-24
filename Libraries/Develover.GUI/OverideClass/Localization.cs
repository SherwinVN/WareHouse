using Develover.Utilities;
using DevExpress.XtraGrid.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develover.GUI.OverideClass
{
    public class Localization
    {
        public class DeveloverGridLocalizer : GridLocalizer
        {
            public override string GetLocalizedString(GridStringId id)
            {
                switch (id)
                {
                    case GridStringId.FindControlFindButton:
                        return StringMessage.Search;
                    case GridStringId.FindControlClearButton:
                        return StringMessage.Delete;
                    case GridStringId.FilterPanelCustomizeButton:
                        return StringMessage.Edit;
                    default:
                        return base.GetLocalizedString(id);
                }
            }
        }
    }
}
