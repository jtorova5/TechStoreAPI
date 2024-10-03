using TechStoreAPI.Models;

namespace TechStoreAPI.Interfaces;

public interface IProductInterface
{
    Task<IEnumerable<Product>> GetProducts();
    Task<Product> FilterProductById(int id);
    Task CreateProduct(Product product);
    Task UpdateProduct(Product product);
    Task DeleteProduct(int id);
}
