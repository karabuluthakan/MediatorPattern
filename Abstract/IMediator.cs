using System.Threading.Tasks;

namespace MediatorPattern.Abstract
{
    public interface IMediator
    {
        Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request);
    }
}