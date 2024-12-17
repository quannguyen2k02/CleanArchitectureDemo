using Domain.Models;

namespace Application.Interfaces;

public interface IProductService
{
    public Task<ProductDTO> AddProduct(ProductDTO product);
    public Task<ProductDTO> UpdateProduct(ProductDTO product);
    public Task<List<ProductDTO>> GetAllProducts();
    public Task<ProductDTO> GetProductById(int id);
}
