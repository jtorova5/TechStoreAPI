namespace TechStoreAPI.Models;

public class Order
{
    public int Id { get; set; }
    public string? Status { get; set; }
    public DateTime DateOrder { get; set; }
    public int QuantityProduct { get; set; }
    public int IdClient { get; set; }
}
