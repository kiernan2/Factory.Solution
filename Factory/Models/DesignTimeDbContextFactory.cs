using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Factory.Models
{
  public class FactoryContextFactory : IDesignTimeDbContextFactory<FactoryContext>
  {
    FactoryContext IDesignTimeDbContextFactory<FactoryContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();
      
      DbContextOptionsBuilder<FactoryContext> builder = new DbContextOptionsBuilder<FactoryContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new FactoryContext(builder.Options);
    }
  }
}