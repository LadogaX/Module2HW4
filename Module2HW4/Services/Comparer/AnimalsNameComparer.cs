using System.Collections.Generic;
using Module2HW4.Models;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services.Comparer
{
    public class AnimalsNameComparer : IComparer<IAnimals>
    {
        public int Compare(IAnimals animals1, IAnimals animals2)
        {
            return string.Compare(animals1.Name, animals2.Name);
        }
    }
}
