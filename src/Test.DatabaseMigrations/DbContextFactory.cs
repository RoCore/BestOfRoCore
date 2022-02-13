using Test.Infrastructure.Data;

namespace Test.DatabaseMigrations;

public class DbContextFactory : DesignTimeDbContextFactory<TestContext> { }