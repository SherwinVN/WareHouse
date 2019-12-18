using System.Threading.Tasks;
using System.Windows.Forms;

namespace Develover.GUI
{
    public interface IDeveloverFormParent : IDeveloverForm
    {
        Task SetStatusAsync(string message);


    }
}
