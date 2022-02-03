using Test.Application.Dto;
using Test.Application.Mapper;

namespace Test.Application.Services;

public class UserService : IUserService
{
    private readonly ICustomMapper _mapper;

    public UserService(ICustomMapper mapper)
    {
        _mapper = mapper;
    }

    public Task<SearchFilterResponse> SearchAsync(SearchFilterRequest request, CancellationToken cancellationToken)
    {
        _mapper.MapToSearchFilterResponse();
    }
}
