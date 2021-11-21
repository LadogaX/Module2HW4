using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
   public class Lynx : Catlike
    {
        public override string Name { get; set; } = "Lynx";
        public bool EarsWithTassels { get; set; }
    }
}
