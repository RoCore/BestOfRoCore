using Microsoft.Extensions.DependencyInjection;
using Test.Application.Dto;
using TestApi.Domain.Models;

namespace Test.Application.Mapper;

public class CustomMapper : ICustomMapper
{
    private readonly IServiceProvider _serviceProvider;

    public CustomMapper(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public SearchFilterResponse MapToSearchFilterResponse(IEnumerable<User> entities)
    {
        var service = _serviceProvider.GetRequiredService<IMapperProfile<IEnumerable<User>, SearchFilterResponse>>();
        return service.Map(entities);
    }
}
