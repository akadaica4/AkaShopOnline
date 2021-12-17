using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AkaShop.Data.EntityFramework
{
    public class AkaSkopDbContextFactory : IDesignTimeDbContextFactory<AkaShopDbContext>
    {
        public AkaShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("AppSettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("AkaShopDbConnection");

            var optionsBuilder = new DbContextOptionsBuilder<AkaShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new AkaShopDbContext(optionsBuilder.Options);
        }
    }
}
