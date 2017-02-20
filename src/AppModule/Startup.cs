using Microsoft.AspNetCore.Builder;
using Nancy.Owin;
 
namespace WebApplication
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(x => x.UseNancy());
        }
    }
}