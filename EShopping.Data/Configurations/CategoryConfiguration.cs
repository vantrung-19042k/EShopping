using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EShopping.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EShopping.Data.Enums;

namespace EShopping.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
