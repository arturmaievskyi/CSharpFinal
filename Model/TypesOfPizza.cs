using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace WebApplication1.Model
{
    public class TypesOfPizzaController : Controller
    {
        public class Types
        {
            public int Id { get; set; }
            public string Type { get; set; } = "";
            public Types(int id, string type)
            {
                Id = id;
                Type = type;
                
            }
            public string PrintInfo() => $"{Id} {Type} ";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
