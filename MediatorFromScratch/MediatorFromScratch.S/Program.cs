using Microsoft.Extensions.DependencyInjection;
using System;

namespace MediatorFromScratch.S
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<PrintToConsoleHandler>()
                .BuildServiceProvider();

            var request = new PrintToConsoleRequest
            {
                Text = "Hello from Mediator"
            };

            IMediator mediator = new Mediator(serviceProvider.GetRequiredService);

            //mediator
            //request => mediator => handler => response
        }
    }
}
