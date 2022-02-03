namespace TestApi.Domain.Models;

public record User
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public bool IsActive { get; init; }
    public DateTime Created { get; init; }
}
