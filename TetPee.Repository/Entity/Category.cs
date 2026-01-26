using TetPee.Repository.Abstraction;

namespace TetPee.Repository.Entity;

public class Category: BaseEntity<Guid>, IAuditableEntity
{
    public Guid? ParentId { get; set; } // Nếu nó là null, thì nó là thằng cha cao nhất,
                                        // không có cha khác
                                        //Nếu có giá trị thì nó là thằng con của parentID 
    public Category? Parent { get; set; }
    public string Name { get; set; }
    
    public ICollection<Category> Children { get; set; } = new List<Category>();
    public ICollection<ProductCategory> ProductCategory { get; set; } = new List<ProductCategory>();
    
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}