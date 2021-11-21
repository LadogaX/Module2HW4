using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
    public abstract class Hares : Rodens
    {
        public bool LongEars { get; set; } = true;
        public bool ShortTail { get; set; } = true;
        public bool HaveLongFeet { get; set; } = true;
    }
}
