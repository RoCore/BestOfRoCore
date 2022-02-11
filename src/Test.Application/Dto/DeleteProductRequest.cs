namespace Test.Application.Dto;

/// <summary>
/// Simplify the request
/// </summary>
public class DeleteProductRequest
{
    /// <summary>
    /// Id of the product to delete
    /// </summary>
    public Guid ProductId { get; set; }
}
