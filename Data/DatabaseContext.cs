using Microsoft.EntityFrameworkCore;
using morleys_backend.Models.DbModels;

namespace morleys_backend.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Attachment>()
            .HasOne(o => o.Product) // One Attachment belongs to one Product
            .WithMany(u => u.Attachments) // One product can have many attachments
            .HasForeignKey(o => o.ProductId); //Foreign key in the Products table is 'productId'

            modelBuilder.Entity<Order>()
            .HasOne(o => o.User) // One order belongs to one user
            .WithMany(u => u.Orders) // One user can have many orders
            .HasForeignKey(o => o.UserId); //Foreign key in the Orders table is 'userId'

            modelBuilder.Entity<Cart>()
                .HasOne(o => o.User)
                .WithOne(u => u.Cart)
                .HasForeignKey<Cart>(o => o.UserId);

            modelBuilder.Entity<OrderProduct>()
            .HasKey(op => op.Id); // Composite primary key

            modelBuilder.Entity<OrderProduct>()
              .HasOne(op => op.Order)
              .WithMany(o => o.OrderProducts)
              .HasForeignKey(op => op.OrderId);

            modelBuilder.Entity<OrderProduct>()
               .HasOne(op => op.Product)
               .WithMany(p => p.OrderProducts)
               .HasForeignKey(op => op.ProductId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

    }
}
