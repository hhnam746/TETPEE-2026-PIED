using TetPee.Repository.Abstraction;

namespace TetPee.Repository.Entity;

public class User: BaseEntity<Guid>, IAuditableEntity
{
    public required string Email { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public required string HashedPassword { get; set; }
    public string? Adress { get; set; }
    public string? ImageUrl { get; set; } = null;
    public string? Role { get; set; } = "User"; //User, Seller, Admin
    public bool IsVerify { get; set; } = false; // Khi user register thì phải verify email hợp lệ
    public int VerifyCode { get; set; } // Mã verify gửi về email
    
    public Seller? Seller { get; set; }
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    // Soft Delete
    // Xoá mềm: Tránh xung đột khoá ngoại (Foreign Key Costrain)
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}