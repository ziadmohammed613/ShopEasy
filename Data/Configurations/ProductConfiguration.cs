using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopEasy.Models;
namespace ShopEasy.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(name: "Products", schema: "shop");
            builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
            builder.Property(p => p.IsActive).HasDefaultValue(true);
            builder.Property(p => p.DisplayName).HasComputedColumnSql("[Name] + '(' + [SKU] + ')'");

            builder.HasQueryFilter(p => p.IsActive);

            builder.HasIndex(p => p.SKU)
                    .IsUnique();

            builder.HasOne(p => p.Category)
                    .WithMany(c => c.Products)
                    .HasForeignKey(p => p.CategoryId)
                    .HasConstraintName("IX_Products_SKU")
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}