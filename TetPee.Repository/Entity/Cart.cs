namespace TetPee.Repository.Entity;

public class Cart
{
    public Guid Id { get; set; }
    
    public bool IsDelete { get; set; } = false; 
    // Soft Delete
    // Xoá mềm: Tránh xung đột khoá ngoại (Foreign Key Costrain)
    public DateTimeOffset CreatedAt { get; set; } //dữ liệu này được tạo ra khi nào
    public DateTimeOffset? UpdatedAt { get; set; }// dữ liệu này được cập nhật lần cuối khi nào

}