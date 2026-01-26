using TetPee.Repository.Abstraction;

namespace TetPee.Repository.Entity;

public class Order: BaseEntity<Guid>, IAuditableEntity
{
    public decimal TotalAmount { get; set; }
    public string Status { get; set; } = "Pending";
    public string address { get; set; }
    
    public Guid UserId { get; set; } // khoá ngoại
    public User User { get; set; } // mày có mqh với User
    
    public ICollection<OrderDetail> OrderDetail { get; set; } = new List<OrderDetail>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}