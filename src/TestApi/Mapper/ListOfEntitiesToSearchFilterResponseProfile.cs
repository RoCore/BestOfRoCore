using TestApi.Dto;
using TestApi.Dto.Data;
using TestApi.Models;

namespace TestApi.Mapper
{
    public class ListOfEntitiesToSearchFilterResponseProfile : IMapperProfile<IEnumerable<Entity>, SearchFilterResponse>
    {
        public SearchFilterResponse Map(IEnumerable<Entity> value) => new (value.Select(entity => new EntityDto { Id = entity.Id, Name = entity.Name, IsActive = entity.IsActive }));
    }
}
