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

            public int Type{ get; set; }
            public Pizza(int id, string name, int price, string img, string description, int type)
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
        List<Pizza> pizzas = new List<Pizza>{
            new Pizza(1,"Hawol",37, "img/hawol.jpg", "its just for pirats", 1),
            new Pizza(2,"Pachese",41, "img/pachese.jpg", "its for the capitan", 1),
            new Pizza(3,"Anafish",28, "img/anafish.jpg", "its just a ananas and fish pizza", 1)
        };

        public IActionResult Index()
        {
            return View(pizzas);
        }
    }
}
