using Test.Application.Dto;
using TestApi.Domain.Models;

namespace Test.Application.Mapper;

/// <summary>
/// Req. for dependency injection
/// </summary>
public interface ICustomMapper
{
    /// <summary>
    /// Concrete mapping
    /// </summary>
    SearchFilterResponse MapToSearchFilterResponse(IEnumerable<User> entities);
}
