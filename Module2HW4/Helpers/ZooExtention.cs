using Module2HW4.Services.Abstractions;

namespace Module2HW4.Helpers
{
    public static class ZooExtention
    {
            public static Result FindAnimalForName(this IZoo zoo, string name)
            {
                IAnimals animal = null;

                for (var i = 0; i < zoo.Animals.Length; i++)
                {
                    if (zoo.Animals[i] != null && (string.Compare(zoo.Animals[i].Name, name.Trim(), true) == 0))
                    {
                        animal = zoo.Animals[i];
                        break;
                    }
                }

                return new Result
                {
                    Status = animal != null,
                    Message = animal != null ? $"Found {name}" : $"{name} Not found "
                };
            }
    }
}
