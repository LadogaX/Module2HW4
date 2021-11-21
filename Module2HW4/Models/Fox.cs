using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
    public class Fox : Cenine
    {
        public override string Name { get; set; } = "Fox";
        public bool Burrowing { get; set; } = true;
        public bool ShortLegs { get; set; } = true;
    }
}