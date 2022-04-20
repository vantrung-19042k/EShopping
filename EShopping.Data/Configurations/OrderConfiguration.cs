﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EShopping.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShopping.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {         
            builder.ToTable("Orders");
            builder.HasKey(x => x.Id);
        }
    }
}
