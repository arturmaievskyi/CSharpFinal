namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.MapGet("/",()=> Results.File("WebAplication/html/index.html") ) ;
            app.MapGet("/hello",()=>"Це сторінка HELLO");
            app.MapGet("/help",()=>"А це сторінка HELP");
            app.Run();

        }
    }
}
