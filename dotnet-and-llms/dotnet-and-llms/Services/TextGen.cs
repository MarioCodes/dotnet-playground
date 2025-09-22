using llms.Services.interfaces;
using Microsoft.Extensions.AI;
using System.Threading;
using System.Threading.Tasks;

namespace llms.Services
{
    public class TextGen(IChatClient _chat) : ITextGen
    {

        public async Task<string> CompleteAsync(string prompt, CancellationToken ct = default)
        {
            // minimal prompt -> single-turn completion
            var result = await _chat.GetResponseAsync(prompt);
            return result.Text;
        }
    }
}
