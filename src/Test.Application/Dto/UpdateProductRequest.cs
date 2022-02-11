using Microsoft.AspNetCore.Mvc;

namespace Test.Application.Dto;

public class UpdateProductRequest
{
    [FromRoute]
    public Guid ProductId { get; set; }

    /// <summary>
    /// Product name
    /// </summary>
    [FromBody]
    public string? Name { get; set; }

    /// <summary>
    /// Product description
    /// </summary>
    [FromBody]
    public string? Description { get; set; }
}
