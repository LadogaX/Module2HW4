using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
    public class Cheetah : Catlike
    {
        public override int MaxSpeed { get; set; } = 120;
        public override string Name { get; set; } = "Cheetah";

        public bool SpottedSkin { get; set; } = true;
    }
}
