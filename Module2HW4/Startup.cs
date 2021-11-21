using Module2HW4.Models;
using Module2HW4.Services;
using Module2HW4.Services.Abstractions;

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
            _zooService.Add(new Wolf());
            _zooService.Add(new Fox());
            _zooService.Add(new Mice());
        }
    }
}
