using System;
using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Treat
  {
    public Treat()  
    {
      this.Categories = new HashSet<CategoryTreat>();
    }
    public int TreatId { get; set; }
    public string  { get; set; }
    public string Ingredients { get; set; }
    public string  { get; set; }
    public virtual ApplicationUser User { get; set; }
    public ICollection<CategoryTreat> Flavors { get; }
  }
}