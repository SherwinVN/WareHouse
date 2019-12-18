using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Handler;
using System.Windows.Forms;

namespace Develover.GUI.Controls
{
    public class DeveloverGridControlHandler : GridHandler
    {
        public DeveloverGridControlHandler(GridView gridView) : base(gridView) { }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyData == Keys.Delete && View.State == GridState.Normal)
                View.DeleteRow(View.FocusedRowHandle);
        }
    }
}
