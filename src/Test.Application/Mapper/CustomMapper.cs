namespace Test.Application.Mapper;

public class CustomMapper : ICustomMapper
{
    private readonly IServiceProvider _serviceProvider;

    public CustomMapper(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
}
