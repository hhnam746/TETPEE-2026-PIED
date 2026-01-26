using TetPee.Repository.Abstraction;

namespace TetPee.Repository.Entity;

public class Seller: BaseEntity<Guid>, IAuditableEntity
{
    public string TaxCode { get; set; }
    public string CompanyAddress { get; set; }
    
    public Guid UserId { get; set; } // khoá ngoại
    public User User { get; set; } // mày có mqh với User
     
    public ICollection<Product> Product { get; set; } = new List<Product>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}