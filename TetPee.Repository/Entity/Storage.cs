using TetPee.Repository.Abstraction;

namespace TetPee.Repository.Entity;

public class Storage:BaseEntity<Guid>, IAuditableEntity
{
    public required string Type { get; set; } //Export, Import
    public decimal Price { get; set; }
    
    public ICollection<ProductStorage> ProductStorage { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}