using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
    public class Wolf : Cenine
    {
        public override string Name { get; set; } = "Wolf";
        public bool EatingCarrion { get; set; } = true;
    }
}
