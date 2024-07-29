using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.Model
{
    public class PizzaController : Controller
    {
        public class Pizza
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";

            public string Image { get; set; } = "";
            public int Price { get; set; }

            public string Descrition { get; set; } = "";

            public string Type { get; set; } = "";
            public Pizza(int id, string name, int price, string img, string description, string type)
            {
                Id = id;
                Name = name;
                Price = price;
                Image = img;
                Descrition = description;
                Type = type;
            }
            public string PrintInfo() => $"{Id} {Name} {Price} {Image} {Descrition} ";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
