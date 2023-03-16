using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<EngineerMachine> Machines { get; set; }

    public Engineer()
    {
      this.Machines = new HashSet<EngineerMachine>();
    }
  }
}