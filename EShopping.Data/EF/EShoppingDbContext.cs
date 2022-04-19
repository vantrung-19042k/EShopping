﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EShopping.Data.Entities;

namespace EShopping.Data.EF
{
    public class EShoppingDbContext : DbContext
    {
        public EShoppingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }  
        public DbSet<Category> Categories { get; set; }  
        public DbSet<AppConfig> AppConfigs { get; set; }  
        public DbSet<Cart> Carts { get; set; }  
        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }  
        public DbSet<Contact> Contacts { get; set; }  
        public DbSet<Language> Languages { get; set; }  
        public DbSet<Order> Orders { get; set; }  
        public DbSet<OrderDetail> OrderDetails { get; set; }  
        public DbSet<ProductTranslation> ProductTranslations { get; set; }  
        public DbSet<Promotion> Promotions { get; set; }  
        public DbSet<Transaction> Transactions { get; set; }  
    }
}