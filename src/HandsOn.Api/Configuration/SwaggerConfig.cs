using System;
using Microsoft.Extensions.DependencyInjection;

namespace HandsOn.Api.Configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfig(this IServiceCollection services)
        {
            services.AddSwaggerGen();

            return services;
        }
    }
}
