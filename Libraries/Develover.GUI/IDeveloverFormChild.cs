using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Develover.GUI
{
    public interface IDeveloverFormChild : IDeveloverForm
    {
        Form MdiParent { get; set; }

        void Show();

        void Activate();

        void Close();

        Icon Icon { get; set; }

        //void RefreshControlDataSource();
    }
}
