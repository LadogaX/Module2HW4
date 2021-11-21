using Module2HW4.Models;

namespace Module2HW4.Services.Abstractions
{
    public interface IZooService
    {
        void Add(IAnimals animal);
        IZoo GetZoo();
    }
}
