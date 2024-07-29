using Microsoft.AspNetCore.Mvc;
using static WebApplication1.Model.PizzaController;
using static WebApplication1.Model.WorkersController;
using static WebApplication1.Model.TypesOfPizzaController;
using WebApplication1.Model;

namespace WebApplication1.controller
{
    public class HomeController : Controller
    {
        List<Types> type = new List<Types>
        {
            new Types(1, "Mixed"),
            new Types(2, "Fruit"),
            new Types(3, "Vagetables"),
            new Types(4, "Meat"),

        };
        List<Pizza> pizzas = new List<Pizza>
        {
            new Pizza(1,"Hawol",50, "img/hawol.jpg", "its just for pirats", "Mixed"),
            new Pizza(2,"Pachese",50, "img/pachese.jpg", "its for the capitan", "Fruit"),
            new Pizza(3,"Anafish",50, "img/anafish.jpg", "its just a ananas and fish pizza", "meat")
        };
        List<Worker> newWorker = new List<Worker>
        {
            new Worker(1, "Dorian", 120, "img/dorian.jpg", "he is very good"),
            new Worker(2, "El-Primo", 120, "img/el-primo.jpg", "he comes from Mexico, he can kill you if you are an idiot"),
            new Worker(3, "Dorian", 120, "img/dorian.jpg", "he is very good"),
            new Worker(4, "Dorian", 120, "img/dorian.jpg", "he is very good"),
            new Worker(5, "Dorian", 120, "img/dorian.jpg", "he is very good")
        };
        public IActionResult Index()
        {
            return View();
        }
    }
}
