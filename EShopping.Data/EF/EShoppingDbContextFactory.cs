using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace EShopping.Data.EF
{
    public class EShoppingDbContextFactory : IDesignTimeDbContextFactory<EShoppingDbContext>
    {
        public EShoppingDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("EShoppingDb");

            var optionsBuilder = new DbContextOptionsBuilder<EShoppingDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EShoppingDbContext(optionsBuilder.Options);
        }
    }
}
