using System;
using System.Threading.Tasks;
using efcore.Middleware.interfaces;

namespace efcore.Middleware
{
    public class MiddlewareService : IMiddlewareService
    {
        public async Task ProcessRequest(string request)
        {
            // do something with the request
            Console.WriteLine(request);
        }

    }
}
