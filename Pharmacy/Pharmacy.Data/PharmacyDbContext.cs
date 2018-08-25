namespace Pharmacy.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Pharmacy.Models;

    public class PharmacyDbContext : IdentityDbContext<User>
    {
        public PharmacyDbContext(DbContextOptions<PharmacyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<DrugIngredient> DrugIngredients { get; set; }

        public DbSet<CrossIngredient> CrossIngredients { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductsCategories> ProductsCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Product>()
                .HasOne(d => d.DrugType)
                .WithMany(dt => dt.Products)
                .HasForeignKey(d => d.DrugTypeId);

            builder
                .Entity<Product>()
                .HasIndex(p => p.Name)
                .IsUnique(true);

            builder
                .Entity<CrossIngredient>()
                .HasKey(cd => new { cd.DrugIngredientId, cd.CrossId });

            builder
                .Entity<CrossIngredient>()
                .HasOne(gd => gd.DrugType)
                .WithMany(dt => dt.CrossIngredients)
                .HasForeignKey(dt => dt.DrugIngredientId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Entity<CrossIngredient>()
                .HasOne(gd => gd.Cross)
                .WithMany(dt => dt.CrossOf)
                .HasForeignKey(gd => gd.CrossId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Order>()
                .HasMany(o => o.Items)
                .WithOne(i => i.Order)
                .HasForeignKey(i => i.OrderId);

            builder
                .Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Entity<ProductsCategories>()
                .HasKey(pc => new { pc.ProductId, pc.CategoryId });

            builder
                .Entity<ProductsCategories>()
                .HasOne(pc => pc.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(pc => pc.CategoryId);

            builder
                .Entity<ProductsCategories>()
                .HasOne(pc => pc.Product)
                .WithMany(p => p.Categories)
                .HasForeignKey(pc => pc.ProductId);

            builder
                .Entity<Category>()
                .HasOne(c => c.ParentCategory)
                .WithMany(pc => pc.ChiledCategories)
                .HasForeignKey(c => c.ParentCategoryId)
                .IsRequired(false);

            builder
                .Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique(true);

            base.OnModelCreating(builder);
        }
    }
}
