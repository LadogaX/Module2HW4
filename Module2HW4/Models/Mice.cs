using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
  public class Mice : Mices
    {
        public override int MaxSpeed { get; set; } = 12;
        public override string Name { get; set; } = "Mice";
        public bool EatingVegetation { get; set; }
        public bool MakeSupplies { get; set; }
    }
}
