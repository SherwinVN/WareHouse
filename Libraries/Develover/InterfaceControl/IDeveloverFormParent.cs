using System.Threading.Tasks;
using System.Windows.Forms;

namespace Develover
{
    public interface IDeveloverFormParent : IDeveloverForm
    {
        Task SetStatusAsync(string message);


    }
}
