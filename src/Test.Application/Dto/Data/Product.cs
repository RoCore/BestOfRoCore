namespace Test.Application.Dto.Data;

/// <summary>
/// Product information
/// </summary>
public class Product
{
    /// <summary>
    /// Identifier
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Product name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Product description
    /// </summary>
    public string? Description { get; set; }
}
