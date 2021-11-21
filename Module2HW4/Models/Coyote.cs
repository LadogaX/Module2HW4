using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
    public class Coyote : Cenine
    {
        public override int MaxSpeed { get; set; } = 69;
        public override string Name { get; set; } = "Coyote";
        public bool EatingCarrion { get; set; } = true;
    }
}
