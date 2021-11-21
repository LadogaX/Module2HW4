using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
   public class Hare : Hares
    {
        public override string Name { get; set; } = "Hare";
        public bool SeasonalColorChange { get; set; }
        public bool SuddenlyChangeDirectionOfRunning { get; set; }
    }
}
