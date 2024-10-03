using TechStoreAPI.Models;

namespace TechStoreAPI.Interfaces;

public interface IClientInterface
{
    Task<IEnumerable<Client>> GetAll();
    Task Add(Client client);
    Task Update(Client client);
}
