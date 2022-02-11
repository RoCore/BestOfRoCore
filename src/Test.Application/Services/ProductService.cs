using Test.Application.Dto;
using Test.Application.Dto.Data;
using Test.Application.Mapper;

namespace Test.Application.Services;

public class ProductService : IProductService
{
    private readonly ICustomMapper _mapper;

    public ProductService(ICustomMapper mapper)
    {
        _mapper = mapper;
    }

    public Task<Product> CreateAsync(CreateProductRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new Product { Id= Guid.NewGuid(), Name = "Test", Description = "Test" });
    }

    public Task UpdateAsync(UpdateProductRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(DeleteProductRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetAsync(GetProductRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
