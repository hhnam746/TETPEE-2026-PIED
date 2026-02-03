using TetPee.Repository.Abstraction;

namespace TetPee.Repository.Entity;

public class OrderDetail: BaseEntity<Guid>, IAuditableEntity
{
    public Guid OrderId { get; set; } // khoá ngoại
    public Order Order { get; set; } // mày có mqh với User

    public Guid ProductId { get; set; } // khoá ngoại
    public Product Product { get; set; } // mày có mqh với User
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}