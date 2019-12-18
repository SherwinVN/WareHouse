using System.Threading.Tasks;

namespace Develover.Services
{
    public interface IDeveloverLogger
    {
        bool Log(string message);
        Task<bool> LogAsync(string message);
    }
}
