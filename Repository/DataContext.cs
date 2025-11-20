using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QLBH.Models;

namespace QLBH.Repository
{
    public class DataContext : IdentityDbContext<AppUserModel>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<BrandModel> Brands { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<RatingModel> Ratings { get; set; }
        public DbSet<SliderModle> Sliders { get; set; }
        public DbSet<ContactModel> Contacts { get; set; }
        public DbSet<CompareModel> Compare { get; set; }
        public DbSet<WishlistModel> Wishlist { get; set; }

        public DbSet<ShippingModel> Shippings { get; set; }

        public DbSet<ProductQuantityModel> ProductQuantities { get; set; }
        public DbSet<CouPonModel> CouPons { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ensure decimal precision/scale is specified to avoid truncation warnings
            modelBuilder.Entity<ProductModel>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            // Unique indexes to prevent duplicate Slug values
            modelBuilder.Entity<CategoryModel>()
                .HasIndex(c => c.Slug)
                .IsUnique();

            modelBuilder.Entity<BrandModel>()
                .HasIndex(b => b.Slug)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}
