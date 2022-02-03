using TestApi.Dto;
using TestApi.Dto.Data;
using TestApi.Models;

namespace TestApi.Mapper
{
    public class ListOfEntitiesToSearchFilterResponse2Profile : IMapperProfile<IEnumerable<Entity>, SearchFilterResponse>
    {
        private readonly IMapperProfile<Entity, EntityDto> _entityMapper;

        public ListOfEntitiesToSearchFilterResponse2Profile(IMapperProfile<Entity, EntityDto> entityMapper)
        {
            _entityMapper = entityMapper;
        }

        public SearchFilterResponse Map(IEnumerable<Entity> value) => new (value.Select(entity => _entityMapper.Map(entity)));
    }
}
