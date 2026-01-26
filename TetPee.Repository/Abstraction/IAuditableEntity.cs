namespace TetPee.Repository.Abstraction;

public interface IAuditableEntity
{
    public DateTimeOffset CreatedAt { get; set; } //dữ liệu này được tạo ra khi nào
    public DateTimeOffset? UpdatedAt { get; set; }// dữ liệu này được cập nhật lần cuối khi nào

}