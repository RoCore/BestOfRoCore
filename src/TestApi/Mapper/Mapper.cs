using TestApi.Dto;
using TestApi.Models;

namespace TestApi.Mapper
{
    public class Mapper : IMapper
    {
        private readonly IServiceProvider _service;

        public Mapper(IServiceProvider service)
        {
            _service = service;
        }

        public SearchFilterResponse MapToSearchFilterResponse(IEnumerable<Entity> entities)
        {
            var service = _service.GetRequiredService<IMapperProfile<IEnumerable<Entity>, SearchFilterResponse>>();
            return service.Map(entities);
        }
    }
}
