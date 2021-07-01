using MediatorPattern.Abstract;

namespace MediatorPattern.Requests
{
    public class PrintToConsoleBoolRequest : IRequest<bool>
    {
        public string Text { get; set; }
    }
}