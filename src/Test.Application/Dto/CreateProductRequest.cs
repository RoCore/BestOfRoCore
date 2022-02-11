namespace Test.Application.Dto;

/// <summary>
/// Simplify the request
/// </summary>
public class CreateProductRequest
{
    /// <summary>
    /// Product name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Product description
    /// </summary>
    public string? Description { get; set; }
}
