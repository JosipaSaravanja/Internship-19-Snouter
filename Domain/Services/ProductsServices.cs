using Contracts.Request.Products;
using Contracts.Response.Products;
using Domain.Mappers;
using Domain.Repository;
using Domain.Validation;
using FluentValidation;

namespace Domain.Services;

public class ProductsServices
{
    private readonly ProductRepository _productRepository;
    private readonly ProductsMapper _productsMapper;
    private readonly ProductValidaton _productsValidaton;
    
    public ProductsServices(ProductRepository productRepository, ProductsMapper productsMapper)
    {
        _productRepository = productRepository;
        _productsMapper = productsMapper;
    }
    public async Task<GetProductResponse> GetProductById(Guid id)
    {
        var product = await _productRepository.GetProductById(id);
        return _productsMapper.ProductToGetProductResponse(product);
    }
    public async Task<GetProductsResponse> GetAllProducts()
    {
        var products = await _productRepository.GetAllProducts();
        return new GetProductsResponse
        {
            Products = products.Select(x => _productsMapper.ProductToGetProductResponse(x)).ToList()
        };
    }
    public async Task<PostProductsResponse> PostProduct(PostProductsRequest postProductRequest)
    {
        var product = _productsMapper.PostProductRequestToProduct(postProductRequest);
        await _productsValidaton.ValidateAndThrowAsync(product);
        if (product == null) return new PostProductsResponse {IsCompleted = false, Product = null};
        var addition = await _productRepository.PostProduct(product);
        if (!addition) return new PostProductsResponse {IsCompleted = false, Product = null};
        return new PostProductsResponse
        {
            IsCompleted = true,
            Product = _productsMapper.ProductToGetProductResponse(product)
        };
    }
    public async Task<PutProductResponse> PutProduct(PutProductsRequest putProductRequest)
    {
        var product = _productsMapper.PutProductRequestToProduct(putProductRequest);
        await _productsValidaton.ValidateAndThrowAsync(product);
        if (product == null) return new PutProductResponse {IsCompleted = false, Product = null};
        var update =  await _productRepository.PutProduct(product);
        if (!update) return new PutProductResponse {IsCompleted = false, Product = null};
        return new PutProductResponse
        {
            IsCompleted = true,
            Product = _productsMapper.ProductToGetProductResponse(product)
        };
    }
    public async Task<DeleteProductResponse> DeleteProduct(Guid id)
    {
        var deletion = await _productRepository.DeleteProduct(id);
        if (!deletion) return new DeleteProductResponse {IsCompleted = false};
        return new DeleteProductResponse {IsCompleted = true};
    }
    public async Task<BuyProductResponse> BuyProduct(BuyProductRequest buyProductRequest)
    {
        var product = await _productRepository.UpdateBought(buyProductRequest.Id, buyProductRequest.BuyerId);
        return new BuyProductResponse
        {
            IsCompleted = product,
        };
    }
    
    
    
}