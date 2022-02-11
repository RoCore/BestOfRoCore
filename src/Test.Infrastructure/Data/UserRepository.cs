using TestApi.Domain.Models;

namespace Test.Infrastructure.Data;

public class UserRepository : IUserRepository
{
    public async Task<IEnumerable<User>> SearchAsync()
    {
        return await Task.FromResult(new List<User> { new User { Created = DateTime.UtcNow, Id = 1, Name = "Chris", IsActive = true } });
    }
}
