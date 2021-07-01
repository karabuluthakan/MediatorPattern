using System;
using System.Threading.Tasks;
using MediatorPattern.Abstract;
using MediatorPattern.Requests;

namespace MediatorPattern.Handlers
{
    public class PrintToConsoleBoolHandler : IHandler<PrintToConsoleBoolRequest, bool>
    {
        public Task<bool> HandleAsync(PrintToConsoleBoolRequest request)
        {
            Console.WriteLine(request.Text);
            return Task.FromResult(true);
        }
    }
}