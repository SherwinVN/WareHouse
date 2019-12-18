using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Drawing;

namespace Develover.GUI.Controls
{
    public class DeveloverGridViewInfo : GridViewInfo
    {
        public DeveloverGridViewInfo(GridView gridView) : base(gridView) { }

        public override int CalcRowHeight(Graphics graphics, int rowHandle, int rowVisibleIndex, int min, int level, bool useCache, GridColumnsInfo columns)
        {
            return base.CalcRowHeight(graphics, rowHandle, rowVisibleIndex, MinRowHeight, level, useCache, columns);
        }

        public override int MinRowHeight
        {
            get
            {
                return base.MinRowHeight - 2;
            }
        }
    }
}
