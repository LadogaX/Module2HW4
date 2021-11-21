using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
    public class WildRabbit : Hares
    {
        public override string Name { get; set; } = "WildRabbit";
        public bool LiveInGroup { get; set; }
        public bool Burrowing { get; set; }
    }
}
