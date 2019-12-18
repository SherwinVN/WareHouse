using Develover.GUI.RepositoryItems;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Develover.GUI.Controls
{
    public partial class DeveloverGridView : GridView, IDeveloverControl
    {
        public DeveloverGridView() : this(null) { }
        public DeveloverGridView(GridControl grid) : base(grid)
        {
            this.OptionsView.ShowGroupPanel = false;
        }
        protected override string ViewName { get { return "DeveloverGridView"; } }
     }
}
