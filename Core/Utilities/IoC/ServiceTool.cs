using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    public static class ServiceTool
    {

        public static IServiceProvider ServiceProvider { get; private set; }

        //Bu kod web apide autofac de oluşturulan injection ları oluşturmaya yarıyor.
        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
