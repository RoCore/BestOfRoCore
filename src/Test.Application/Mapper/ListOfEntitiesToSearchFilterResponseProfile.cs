using Test.Application.Dto;
using Test.Application.Dto.Data;
using TestApi.Domain.Models;

namespace Test.Application.Mapper;

public class ListOfEntitiesToSearchFilterResponseProfile : IMapperProfile<IEnumerable<User>, SearchFilterResponse>
{
    public SearchFilterResponse Map(IEnumerable<User> value)
        => new(value.Select(entity => new UserDto { Id = entity.Id, Name = entity.Name, IsActive = entity.IsActive }));
}
