using Nadin.Domain.Model;

namespace Nadin.Domain.Contract;

public interface IProductRepositories
{
    Task<Product> GetProductByIdAsync(int id);
    Task<List<Product>> GetAllProductsAsync();
    Task AddProductAsync(Product product);
    Task UpdateProductAsync(Product product);
    Task DeleteProductAsync(int id);
}