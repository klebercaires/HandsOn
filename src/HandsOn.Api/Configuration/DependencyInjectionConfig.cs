using System;
using Microsoft.Extensions.DependencyInjection;

namespace HandsOn.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            return services;
        }
    }
}