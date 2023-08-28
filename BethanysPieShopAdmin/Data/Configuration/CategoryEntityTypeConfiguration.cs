using BethanysPieShopAdmin.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopAdmin.Data.Configuration
{
    public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .Property(b => b.Name)
                .IsRequired();
        }
    }
}
