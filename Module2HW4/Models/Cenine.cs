using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
    public abstract class Cenine : Predators
    {
        public bool ColorBlind { get; set; } = true;
        public bool ElongatedMuzzle { get; set; } = true;
    }
}
