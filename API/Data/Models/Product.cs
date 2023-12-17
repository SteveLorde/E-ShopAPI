using System.ComponentModel.DataAnnotations;

namespace API.Data.Models;

public class Product
{
    [Key]
    public Guid Id { get; set; }
    public string name { get; set; }
    public string? description { get; set; }
    public string? descriptionbullets { get; set; }
    
    public Guid? ParentCategoryId { get; set; }
    public Guid? SubCategoryId { get; set; }
    public int? price { get; set; }
    public int? barcode { get; set; }
    public int storequantity { get; set; }
    public DateOnly? addedon { get; set; }
    public int? discount { get; set; }
    public string[]? images { get; set; }
    public int? sells { get; set; }
    
}