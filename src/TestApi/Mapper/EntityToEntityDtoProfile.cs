using TestApi.Dto.Data;
using TestApi.Models;

namespace TestApi.Mapper
{
    public class EntityToEntityDtoProfile : IMapperProfile<Entity, EntityDto>
    {
        public EntityDto Map(Entity value) => new() { Id = value.Id, Name = value.Name, IsActive = value.IsActive };
    }
}
