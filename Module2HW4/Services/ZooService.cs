using System;
using System.Collections.Generic;
using Module2HW4.Models;
using Module2HW4.Services.Abstractions;
using Module2HW4.Services.Comparer;

namespace Module2HW4.Services
{
    public class ZooService : IZooService
    {
        private readonly int _stepCapacity = 5;
        private int _capacity;
        private IZoo _zoo;
        private IAnimals[] _animals;

        public ZooService(IZoo zoo)
        {
            _zoo = zoo;
            _capacity = _stepCapacity;
            _animals = new Animals[_capacity];

            _zoo.Animals = _animals;
        }

        public int CountAnimalsOfZoo { get; set; }

        public void Add(IAnimals animal)
        {
            if (CountAnimalsOfZoo == _animals.Length)
            {
                _capacity += _stepCapacity;
                SetCapacity(_capacity);
            }

            for (var i = CountAnimalsOfZoo; i < _animals.Length; i++)
            {
                if (_animals[i] == null)
                {
                    _animals[i] = animal;

                    CountAnimalsOfZoo++;
                    break;
                }
            }
        }

        public void SetCapacity(int capacity)
        {
            if (_animals.Length >= CountAnimalsOfZoo)
            {
                Array.Resize(ref _animals, capacity);
                _zoo.Animals = _animals;
            }
        }

        public IZoo GetZoo()
        {
            return _zoo;
        }

        public void Sort(IComparer<IAnimals> comparer)
        {
            SetCapacity(CountAnimalsOfZoo);
            Array.Sort(_animals, comparer);
        }

        public void DisplayZoo()
        {
            Console.WriteLine("Contens ZOO:");
            for (var i = 0; i < _animals.Length; i++)
            {
                IAnimals animal = _animals[i];
                if (animal != null)
                {
                    Console.WriteLine(DisplayAnimal(animal));
                }
            }

            Console.WriteLine();
        }

        public string DisplayAnimal(IAnimals animal)
        {
            return $"Product: {animal.Name.PadRight(25)} MaxSpeed {animal.MaxSpeed}";
        }

        public int GetCounntAnimalsInZoo()
        {
            return CountAnimalsOfZoo;
        }

        public int GetCounntTypeAnimalsInZoo(IComparer<IAnimals> comparer)
        {
            Sort(comparer);
            int counntTypeAnimalsInZoo = 0;

            IAnimals currentAnimal = null;
            for (var i = 0; i < _animals.Length; i++)
            {
                IAnimals animal = _animals[i];
                if (animal != currentAnimal)
                {
                    counntTypeAnimalsInZoo++;
                    currentAnimal = animal;
                }
            }

            return counntTypeAnimalsInZoo;
        }
    }
}
