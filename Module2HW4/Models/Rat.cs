using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
   public class Rat : Mices
    {
        public override string Name { get; set; } = "Rat";
        public bool CanSwim { get; set; } = true;
        public bool MembranesOnFingers { get; set; } = true;
    }
}
