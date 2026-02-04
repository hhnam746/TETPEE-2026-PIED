using Microsoft.EntityFrameworkCore;
using TetPee.Repository.Entity;

namespace TetPee.Repository;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

    public DbSet<User> Users { get; set; }
    public DbSet<Seller> Sellers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductStorage> ProductStorages { get; set; }
    public DbSet<Storage> Storages { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Category> Categories { get; set; }

    public static Guid UserId1 = Guid.NewGuid();
    public static Guid UserId2 = Guid.NewGuid();
    
    
    public static Guid CategoryParentId1 = Guid.NewGuid();
    public static Guid CategoryParentId2 = Guid.NewGuid();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(builder =>
        {
            builder.Property(u => u.Email).IsRequired().HasMaxLength(255);
            builder.HasIndex(u => u.Email).IsUnique(); //Indexing for faster search
            
            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(255);
            
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(255);
            
            builder.Property(u => u.ImageUrl).HasMaxLength(255);
            
            builder.Property(u => u.PhoneNumber).HasMaxLength(255);
            
            builder.Property(u => u.HashedPassword).IsRequired().HasMaxLength(255);
            
            builder.Property(u => u.Role).HasMaxLength(255).HasDefaultValue("User");
            
            builder.HasOne(u => u.Seller)
                .WithOne(s => s.User)
                .HasForeignKey<Seller>(s => s.UserId)
                .OnDelete(DeleteBehavior.Cascade); 
            //Cascade: khi mot user bi xoa thi cac seller bi xoa theo
            //Restrict: Khi ma 1 du an co task -> thi khong the xoa | khi khong co cong viec nao thi co the xoa
            
            List<User> users = new List<User>()
            {
                new ()
                {
                    Id = UserId1,
                    Email = "dafox746@gmail.com",
                    FirstName = "Nam",
                    LastName = "Ho Hoang",
                    HashedPassword = "Hashed_password_01"
                },
                new ()
                {
                    Id = UserId2,
                    Email = "dafox76@gmail.com",
                    FirstName = "NamDepTRai",
                    LastName = "Ho Hoang",
                    HashedPassword = "Hashed_password_02"
                },  
                
                
            };
            for (int i = 0; i <= 1000; i++)
            {
                var newUser = new User()
                {
                    Id = Guid.NewGuid(),
                    Email = "dafox76" + i + i + "@gmail.com",
                    FirstName = "NamDepTRai" + i ,
                    LastName = "Ho Hoang" + i,
                    HashedPassword = "Hashed_password_02"
                };
                users.Add(newUser);
            }
            builder.HasData(users);
        });

        modelBuilder.Entity<Seller>(builder =>
        {
            builder.Property(s => s.TaxCode).IsRequired().HasMaxLength(255);
            builder.Property(s => s.CompanyAddress).IsRequired().HasMaxLength(255);
            builder.Property(s => s.CompanyName).IsRequired().HasMaxLength(255);

            var seller = new List<Seller>()
            {
                new ()
                {
                    Id = Guid.NewGuid(),
                    TaxCode = "TAXCODE123134",
                    CompanyAddress = "123 , Ny, USA",
                    CompanyName = "Apple",
                    UserId = UserId1,
                }
            };
            builder.HasData(seller);
        });

        modelBuilder.Entity<Category>(builder =>
        {
            var category = new List<Category>()
            {
                new()
                {
                    Id = CategoryParentId1,
                    Name = "Áo"
                },
                
                new()
                {
                    Id = CategoryParentId2,
                    Name = "Quần"
                },
                
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Áo thể thao",
                    ParentId = CategoryParentId1,
                },
                
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Quần xì",
                    ParentId = CategoryParentId2,
                }
            };
            for (int i = 0; i <= 500; i++)
            {
                var newCategory = new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Áo size " + i,
                    ParentId = CategoryParentId1,
                };
                category.Add(newCategory);
            }
            
            for (int i = 0; i <= 500; i++)
            {
                var newCategory = new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Quần size " + i,
                    ParentId = CategoryParentId2,
                };
                category.Add(newCategory);
            }
            builder.HasData(category);
        });
    }
}