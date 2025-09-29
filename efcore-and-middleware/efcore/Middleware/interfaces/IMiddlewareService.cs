using System.Threading.Tasks;

namespace efcore.Middleware.interfaces
{
    public interface IMiddlewareService
    {
        Task ProcessRequest(string request);
    }
}
