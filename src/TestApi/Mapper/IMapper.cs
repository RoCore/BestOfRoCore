using TestApi.Dto;
using TestApi.Models;

namespace TestApi.Mapper
{
    /// <summary>
    /// Req. for dependency injection
    /// </summary>
    public interface IMapper
    {
        /// <summary>
        /// Concrete mapping
        /// </summary>
        SearchFilterResponse MapToSearchFilterResponse(IEnumerable<Entity> entities);
    }
}
