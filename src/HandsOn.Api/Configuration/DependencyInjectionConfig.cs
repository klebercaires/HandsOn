using System;
using HandsOn.Business.Interfaces;
using HandsOn.Business.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HandsOn.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDivisorService, DivisorService>();
            return services;
        }
    }
}