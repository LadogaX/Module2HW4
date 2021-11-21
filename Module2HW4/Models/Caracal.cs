using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
   public class Caracal : Catlike
    {
        public override int MaxSpeed { get; set; } = 80;
        public override string Name { get; set; } = "Caracal";
        public bool EarsWithTassels { get; set; } = true;
    }
}
