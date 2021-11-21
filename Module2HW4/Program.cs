using Module2HW4.Models;
using Module2HW4.Services;
using Microsoft.Extensions.DependencyInjection;
using Module2HW4.Services.Abstractions;

namespace Module2HW4
{
    public class Program
    {
        public static void Main()
        {
            var zooService = new ServiceCollection()
                .AddTransient<IZoo, Zoo>()
                .AddTransient<IZooService, ZooService>()
                .AddTransient<Startup>()
                .BuildServiceProvider();

            var startup = zooService.GetService<Startup>();
            startup.Run();
        }
    }
}
