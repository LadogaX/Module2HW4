using Module2HW4.Services.Abstractions;

namespace Module2HW4.Models
{
   public abstract class Animals : IAnimals
    {
        public abstract string Name { get; set; }
    }
}
