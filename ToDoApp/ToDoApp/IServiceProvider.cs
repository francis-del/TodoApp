using System;
using Microsoft.Extensions.DependencyInjection;

namespace ToDoAppExtension
{
    public static class Startup
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceProvider Init()
        {
            var serviceProvider = new ServiceCollection()
                .ConfigureServices()
                .BuildServiceProvider();

            ServiceProvider = serviceProvider;

            return serviceProvider;
        }
    }
}