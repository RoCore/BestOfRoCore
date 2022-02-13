using Microsoft.EntityFrameworkCore;
using TestApi.Domain.Models;

namespace Test.Infrastructure.Data;

public class TestContext : DbContext, IProductRepository
{
}
