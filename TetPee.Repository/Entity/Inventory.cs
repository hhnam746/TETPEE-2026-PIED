using TetPee.Repository.Abstraction;

namespace TetPee.Repository.Entity;

public class Inventory : BaseEntity<Guid>, IAuditableEntity
{
    public int TotalSell { get; set; }
    public int TotalInstock { get; set; }
    
    public Guid ProductId { get; set; }
    public Product Product { get; set; }

public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}