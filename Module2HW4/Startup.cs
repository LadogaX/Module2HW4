using System;
using System.Collections;
using System.Collections.Generic;
using Module2HW4.Helpers;
using Module2HW4.Models;
using Module2HW4.Services;
using Module2HW4.Services.Abstractions;
using Module2HW4.Services.Comparer;

namespace Module2HW4
{
    public class Startup
    {
        private readonly IZooService _zooService;
        public Startup(IZooService zooService)
        {
            _zooService = zooService;
        }

        public void Run()
        {
            AddingAnimalsInZoo();
            _zooService.DisplayZoo();

            _zooService.Sort(new AnimalsNameComparer());
            _zooService.DisplayZoo();
            _zooService.Sort(new AnimalsMaxSpeedComparer());
            _zooService.DisplayZoo();

            var result = _zooService.GetZoo().FindAnimalForName("Caracal");
            Console.WriteLine(result.Message);

            var counntAnimalsInZoo = _zooService.GetCounntAnimalsInZoo();
            Console.WriteLine($"Counnt type animals in zoo: {counntAnimalsInZoo}");

            var counntTypeAnimalsInZoo = _zooService.GetCounntTypeAnimalsInZoo(new AnimalsNameComparer());
            Console.WriteLine($"Counnt type animals in zoo: {counntTypeAnimalsInZoo}");
        }

        public void AddingAnimalsInZoo()
        {
            IAnimals coyot = new Coyote();
            IAnimals fox = new Fox();
            IAnimals cheetah = new Cheetah();
            IAnimals caracal = new Caracal();
            IAnimals hare = new Hare();
            IAnimals wildRabbit = new WildRabbit();
            IAnimals mice = new Mice();
            IAnimals rat = new Rat();

            _zooService.Add(coyot);
            _zooService.Add(fox);
            _zooService.Add(cheetah);
            _zooService.Add(caracal);
            _zooService.Add(hare);
            _zooService.Add(wildRabbit);
            _zooService.Add(mice);
            _zooService.Add(rat);

            _zooService.Add(coyot);
            _zooService.Add(fox);
            _zooService.Add(cheetah);
            _zooService.Add(caracal);
            _zooService.Add(hare);
            _zooService.Add(wildRabbit);
            _zooService.Add(mice);
            _zooService.Add(rat);
        }
    }
}
