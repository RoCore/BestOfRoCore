namespace Test.Application.Dto;

/// <summary>
/// Simplify the request
/// </summary>
public class GetProductRequest
{
    /// <summary>
    /// Identifier of the product
    /// </summary>
    public Guid ProductId { get; set; }
}
