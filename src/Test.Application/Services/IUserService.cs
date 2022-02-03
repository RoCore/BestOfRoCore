using Test.Application.Dto;

namespace Test.Application.Services;

public interface IUserService
{
    Task<SearchFilterResponse> SearchAsync(SearchFilterRequest request, CancellationToken cancellationToken);
}
