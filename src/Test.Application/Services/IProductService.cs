using Test.Application.Dto;
using Test.Application.Dto.Data;

namespace Test.Application.Services;

/// <summary>
/// Service definition
/// </summary>
public interface IProductService
{
    /// <summary>
    /// Allow to create new Product
    /// </summary>
    Task<Product> CreateAsync(CreateProductRequest request, CancellationToken cancellationToken);

    /// <summary>
    /// Get a single product
    /// </summary>
    Task<Product> GetAsync(GetProductRequest request, CancellationToken cancellationToken);

    /// <summary>
    /// Allow to create new Product
    /// </summary>
    Task UpdateAsync(UpdateProductRequest request, CancellationToken cancellationToken);

    /// <summary>
    /// Allow to delete a product from datasource
    /// </summary>
    Task DeleteAsync(DeleteProductRequest request, CancellationToken cancellationToken);
}
