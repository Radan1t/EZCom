using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Infrastructure.Persistence.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) 
                .AddUserSecrets<ApplicationDbContext>() 
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection"); 

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Не найдена строка підключення");
            }

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionString); 

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
