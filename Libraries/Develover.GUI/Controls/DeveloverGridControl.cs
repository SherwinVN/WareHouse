using DevExpress.Data.Linq;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using static Develover.GUI.OverideClass.Enum;

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
        public class TypeColumns {
            string Caption = "";
            string Name = "";
            string FieldName = "";
            EnumTypeColumns TypeColumn = EnumTypeColumns.Text;
        }
        public void BuildColumn(TypeColumns[] typeColumns) {
            foreach (TypeColumns typeColumn in typeColumns) {
                            
            }
        }
    }
}
