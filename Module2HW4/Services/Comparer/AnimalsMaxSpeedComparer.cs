using System.Collections.Generic;
using Module2HW4.Models;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services.Comparer
{
   public class AnimalsMaxSpeedComparer : IComparer<IAnimals>
    {
        public int Compare(IAnimals animals1, IAnimals animals2)
        {
            if (animals1.MaxSpeed > animals2.MaxSpeed)
            {
                return 1;
            }
            else if (animals1.MaxSpeed < animals2.MaxSpeed)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
