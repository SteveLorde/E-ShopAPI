namespace API.Data.Models;

public class Product
{
    public int ProductId { get; set; }
    public string name { get; set; }
    public string? description { get; set; }
    public string? descriptionbullets { get; set; }
    public int? price { get; set; }
    public DateTime? addedon { get; set; }
    public int? discount { get; set; }
    
}