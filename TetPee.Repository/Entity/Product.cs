using TetPee.Repository.Abstraction;

namespace TetPee.Repository.Entity;

public class Product: BaseEntity<Guid>, IAuditableEntity
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public string UrlImage { get; set; } = string.Empty;
    public decimal Price { get; set; }
    
    public Guid SellerId { get; set; } // khoá ngoại
    public Seller Seller { get; set; } // mày có mqh với User
    
    public ICollection<OrderDetail> OrderDetail { get; set; } = new List<OrderDetail>();
    public ICollection<ProductCategory> ProductCategory { get; set; } = new List<ProductCategory>();
    public ICollection<ProductStorage> ProductStorage { get; set; } = new List<ProductStorage>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}