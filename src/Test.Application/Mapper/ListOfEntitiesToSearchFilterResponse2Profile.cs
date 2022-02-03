using Test.Application.Dto;
using Test.Application.Dto.Data;
using TestApi.Domain.Models;

namespace Test.Application.Mapper;

public class ListOfEntitiesToSearchFilterResponse2Profile : IMapperProfile<IEnumerable<User>, SearchFilterResponse>
{
    private readonly IMapperProfile<User, UserDto> _entityMapper;

    public ListOfEntitiesToSearchFilterResponse2Profile(IMapperProfile<User, UserDto> entityMapper)
    {
        _entityMapper = entityMapper;
    }

    public SearchFilterResponse Map(IEnumerable<User> value)
    {
        var mapped = _entityMapper.Map(value.First());
        mapped.Name = "";
        return new(value.Select(entity => _entityMapper.Map(entity)));
    }
}
