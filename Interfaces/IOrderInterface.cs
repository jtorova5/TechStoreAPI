using TechStoreAPI.Models;

namespace TechStoreAPI.Interfaces;

public interface IOrderInterface
{
    Task CreateOrder(Order order);
    Task UpdateOrder(Order order);
    Task DeleteOrder(int id);
    Task FilterOrderByClient(string client);
    Task FilterOrderByStatus(string status);
    Task FilterOrderByCreationDate(DateTime dateTime);
}