using Microsoft.AspNetCore.Builder;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => Results.Redirect("/index"));
            app.MapGet("/index", () => Results.File("Views/Home/index.cshtml"));

            app.MapGet("/about", () => Results.File("views/Home/about.cshtml"));
            app.MapGet("/about_me", () => Results.Redirect("/about"));

            app.MapGet("/support_me", () => Results.Redirect("/support"));
            app.MapGet("/support", () => Results.File("Views/Home/support.cshtml"));
            
            app.MapGet("/pizzas", () => Results.File("Views/Home/pizzas.cshtml"));
            app.Run();
        }
    }
}
