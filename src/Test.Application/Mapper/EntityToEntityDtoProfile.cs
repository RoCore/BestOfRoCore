using Test.Application.Dto.Data;
using TestApi.Domain.Models;

namespace Test.Application.Mapper;

public class EntityToEntityDtoProfile : IMapperProfile<User, UserDto>
{
    public UserDto Map(User value) => new() { Id = value.Id, Name = value.Name, IsActive = value.IsActive };
}
