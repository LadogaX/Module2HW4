using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
    public abstract class Predators : Animals
    {
        public bool EatMeat { get; set; } = true;
    }
}
