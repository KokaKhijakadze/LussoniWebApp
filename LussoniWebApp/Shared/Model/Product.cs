namespace LussoniWebApp.Shared.Model;

public class Product : Entity
{
    public string? ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int ProductQuantity { get; set; }

}
