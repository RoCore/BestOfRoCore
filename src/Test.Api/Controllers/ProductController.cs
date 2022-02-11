using Microsoft.AspNetCore.Mvc;
using Test.Application.Dto;
using Test.Application.Dto.Data;
using Test.Application.Services;

namespace Test.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private const string GetByIdRoute = "GetById";

    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    /// <summary>
    /// Create new Entry.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateProductRequest product, CancellationToken cancellationToken)
    {
        var createdProduct = await _productService.CreateAsync(product, cancellationToken);
        return CreatedAtAction(GetByIdRoute, new { productId = createdProduct.Id.ToString("N") }, createdProduct);
    }

    [HttpGet("{productId}")]
    [ActionName(GetByIdRoute)]
    public async Task<Product> Get([FromRoute] GetProductRequest request, CancellationToken cancellationToken)
    {
        return await _productService.GetAsync(request, cancellationToken);
    }

    /// <summary>
    /// Update current product
    /// </summary>
    [HttpPut]
    public async Task<IActionResult> UpdateAsync(UpdateProductRequest updateProductRequest, CancellationToken cancellationToken)
    {
        await _productService.UpdateAsync(updateProductRequest, cancellationToken);
        return NoContent();
    }

    /// <summary>
    /// Remove product
    /// </summary>
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync([FromRoute] DeleteProductRequest deleteProductRequest, CancellationToken cancellationToken)
    {
        await _productService.DeleteAsync(deleteProductRequest, cancellationToken);
        return NoContent();
    }
}
