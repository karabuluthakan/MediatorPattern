using System;
using System.Threading.Tasks;
using MediatorPattern.Abstract;
using MediatorPattern.Extensions;
using MediatorPattern.Requests;
using Microsoft.Extensions.DependencyInjection;

namespace MediatorPattern
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddMediator(ServiceLifetime.Scoped, typeof(Program))
                .BuildServiceProvider();

            var request = new PrintToConsoleBoolRequest
            {
                Text = "Hello World!"
            };
            var mediator = serviceProvider.GetRequiredService<IMediator>();
            await mediator.SendAsync(request);
            var result = await mediator.SendAsync(new PrintToConsoleStringRequest());
            Console.WriteLine(result);
        }
    }
}