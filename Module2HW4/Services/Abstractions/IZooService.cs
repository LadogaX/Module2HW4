using System.Collections;
using System.Collections.Generic;
using Module2HW4.Models;

namespace Module2HW4.Services.Abstractions
{
    public interface IZooService
    {
        void Add(IAnimals animal);
        IZoo GetZoo();

        void SetCapacity(int capacity);
        void Sort(IComparer<IAnimals> comparer);

        void DisplayZoo();
        string DisplayAnimal(IAnimals animal);

        int GetCounntAnimalsInZoo();
        int GetCounntTypeAnimalsInZoo(IComparer<IAnimals> comparer);
    }
}
