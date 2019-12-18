using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace Develover.GUI.Controls
{
    public class DeveloverGridViewInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName { get { return "DeveloverGridView"; } }
        public override BaseView CreateView(GridControl grid) { return new DeveloverGridView(grid as GridControl); }
        public override BaseViewInfo CreateViewInfo(BaseView view) { return new DeveloverGridViewInfo(view as DeveloverGridView); }
        public override BaseViewHandler CreateHandler(BaseView view) { return new DeveloverGridControlHandler(view as DeveloverGridView); }
    }
}
