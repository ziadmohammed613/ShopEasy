using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopEasy.Models;
namespace ShopEasy.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders", schema: "shop");
 
            builder.Property(o => o.Status)
                .IsRequired()
                .HasMaxLength(30)
                .HasConversion<string>()
                .HasDefaultValue("Pending");
 
            builder.Property(o => o.TotalAmount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");
 
            builder.Property(o => o.PlacedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");
 
            builder.HasIndex(o => o.Status)
                .HasFilter("[Status] = 'Pending'")
                .HasDatabaseName("IX_Orders_PendingStatus");
 
            builder.HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}