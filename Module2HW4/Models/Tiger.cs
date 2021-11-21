using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
    public class Tiger : Catlike
    {
        public override string Name { get; set; } = "AmurTiger";

        public bool StripesOnSkin { get; set; } = true;
    }
}
