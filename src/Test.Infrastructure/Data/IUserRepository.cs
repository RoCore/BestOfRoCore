using TestApi.Domain.Models;

namespace Test.Infrastructure.Data;

public class IUserRepository
{
    IEnumerable<User> SearchAsync()
}
