using System;
using Microsoft.Extensions.DependencyInjection;


namespace ToDoApp
{
    public static class DependencyInjectionContainer
    {
        public static IServiceCollection ConfigureServices(this
            IServiceCollection services)
        {
            services.AddSingleton<IMyService, MyService>();

            return services;
        }
    }
}
