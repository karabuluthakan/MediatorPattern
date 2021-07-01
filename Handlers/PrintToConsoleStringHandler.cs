using System.Threading.Tasks;
using MediatorPattern.Abstract;
using MediatorPattern.Requests;

namespace MediatorPattern.Handlers
{
    public class PrintToConsoleStringHandler : IHandler<PrintToConsoleStringRequest, string>
    {
        public Task<string> HandleAsync(PrintToConsoleStringRequest request)
        {
            return Task.FromResult("Hello from PrintToConsoleStringHandler"); 
        }
    }
}