using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EShopping.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EShopping.Data.Enums;


namespace EShopping.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(x => new {
                x.CategoryId,
                x.ProductId
            });

            builder.ToTable("ProductInCategory");

            builder.HasOne(p => p.Product).WithMany(pc => pc.ProductInCategories)
                .HasForeignKey(pc => pc.ProductId);

            builder.HasOne(p => p.Category).WithMany(pc => pc.ProductInCategories)
                .HasForeignKey(pc => pc.CategoryId);
        }
    }
}
