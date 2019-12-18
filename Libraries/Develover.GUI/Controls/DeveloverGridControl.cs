using DevExpress.Data.Linq;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;

namespace Develover.GUI.Controls
{
    public partial class DeveloverGridControl : GridControl, IDeveloverControl
    {
        public EntityServerModeSource entityServerModeSource = new EntityServerModeSource();

        protected override BaseView CreateDefaultView()
        {
            return CreateView("DeveloverGridView");
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new DeveloverGridViewInfoRegistrator());
        }
    }
}
