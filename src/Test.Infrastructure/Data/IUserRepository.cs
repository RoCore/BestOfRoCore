using TestApi.Domain.Models;

namespace Test.Infrastructure.Data;

public interface IUserRepository
{
    Task<IEnumerable<User>> SearchAsync();
}
