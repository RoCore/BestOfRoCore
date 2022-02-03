using Test.Application.Dto.Data;

namespace Test.Application.Dto;

public class SearchFilterResponse : List<UserDto>
{
    public SearchFilterResponse(IEnumerable<UserDto> entities)
    {
        AddRange(entities);
    }
}
