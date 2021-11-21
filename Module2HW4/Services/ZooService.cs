using System;
using Module2HW4.Models;
using Module2HW4.Services.Abstractions;

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
            _animals = new IAnimals[_capacity];

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
            Array.Resize(ref _animals, capacity);
        }

        public IZoo GetZoo()
        {
            return _zoo;
        }
    }
}
