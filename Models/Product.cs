namespace TechStoreAPI.Models;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Price { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
    public int IdCategory { get; set; }
}
