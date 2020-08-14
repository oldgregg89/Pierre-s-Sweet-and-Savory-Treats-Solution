using System;
using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Treat
  {
    public Treat()  
    {
      this.Flavors = new HashSet<FlavorTreat>();
    }
    public int TreatId { get; set; }
    public string Type { get; set; }
    public string Ingredients { get; set; }
    public virtual ApplicationUser User { get; set; }
    public ICollection<FlavorTreat> Flavors { get; }
  }
}