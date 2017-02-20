using Nancy;
 
namespace WebApplication
{
    public class AppModule : NancyModule
    {
        public AppModule()
        {
            Get("/", args => "Super Duper Happy Path");
        }
    }
}