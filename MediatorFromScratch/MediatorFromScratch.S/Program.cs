using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediatorFromScratch.S
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<PrintToConsoleHandler>()
                .BuildServiceProvider();

            var handlerDetails = new Dictionary<Type, Type>
            {
                {typeof(PrintToConsoleRequest), typeof(PrintToConsoleHandler)},
            };

            var request = new PrintToConsoleRequest
            {
                Text = "Hello from Mediator"
            };

            IMediator mediator = new Mediator(serviceProvider.GetRequiredService, handlerDetails);

            await mediator.SendAsync(request);
            //mediator
            //request => mediator => handler => response
        }
    }
}
