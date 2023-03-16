using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public virtual DbSet<Machine> Machines { get; set; }
    public virtual DbSet<Engineer> Engineers { get; set; }
    public virtual DbSet<EngineerMachine> EngineerMachines { get; set; }
    public FactoryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
      optionBuilder.UseLazyLoadingProxies();
    }
  }
}