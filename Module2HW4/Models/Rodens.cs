using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
    public abstract class Rodens : Animals
    {
        public bool PairOfLargeIncisors { get; set; } = true;

        public bool EyesOnSide { get; set; } = true;
    }
}
