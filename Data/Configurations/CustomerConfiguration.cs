using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopEasy.Models;

namespace ShopEasy.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable(name: "Customers", schema: "shop");
            builder.HasKey(c => c.CustomerId).HasName("customer_id");
            builder.Property(c => c.FullName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("full_name")
                    .HasComment("Customer full legal name");
            builder.Property(c => c.Email)
                    .HasMaxLength(250);
            builder.HasIndex(c => c.Email);
            builder.Property(c => c.PhoneNumber)
                    .IsRequired(false)
                    .HasMaxLength(20);
            builder.Property(c => c.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
        }
    }
}