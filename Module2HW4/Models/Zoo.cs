using Module2HW4.Services.Abstractions;

namespace Module2HW4.Models
{
    public class Zoo : IZoo
    {
        public IAnimals[] Animals { get; set; }
    }
}
