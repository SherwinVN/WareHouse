using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Develover.GUI
{
    public interface IDeveloverFormChild : IDeveloverForm
    {
        Form MdiParent { get; set; }

        void Show();

        void Hide();

        void Activate();

        void Close();

        bool Visible { get; set; }

        Icon Icon { get; set; }

        //void RefreshControlDataSource();
    }
}
