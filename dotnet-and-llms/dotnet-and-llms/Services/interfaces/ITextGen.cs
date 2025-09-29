using System.Threading;
using System.Threading.Tasks;

namespace llms.Services.interfaces
{
    public interface ITextGen
    {
        // this is the interface your app will depend on
        Task<string> CompleteAsync(string prompt, CancellationToken ct = default);
    }
}
