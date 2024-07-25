using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Model
{
    public class WorkersController : Controller
    {
        public class Worker
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";

            public string Image { get; set; } = "";
            public int Gets { get; set; }

            public string Descrition { get; set; } = "";

            public string Restaurant { get; set; } = "";

            public Worker(int id, string name, int gets, string img, string description)
            {
                Id = id;
                Name = name;
                Gets = gets;
                Image = img;
                Descrition = description;
            }
            public string PrintInfo() => $"{Id} {Name} {Gets} {Image} {Descrition} ";

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
