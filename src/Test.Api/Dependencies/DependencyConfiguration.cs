using Test.Application.Mapper;
using Test.Application.Services;

namespace Test.Api.Dependencies;

public static class DependencyConfiguration
{
    public static IServiceCollection AddCustomDependencies(this IServiceCollection services)
    {
        return services
            .AddScoped<IProductService, ProductService>()
            .AddScoped<ICustomMapper, CustomMapper>();
    }
}
