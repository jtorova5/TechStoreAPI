using TechStoreAPI.Models;

namespace TechStoreAPI.Interfaces;

public interface ICategoryInterface
{
    Task<IEnumerable<Category>> GetAll();
    Task Create(Category category);
    Task Update(Category category);
    Task Delete(int id);
}
