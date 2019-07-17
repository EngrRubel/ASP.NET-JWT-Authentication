/* Author : Rubel talukder */
/* mobile : 01748892601 */
/* email  : rubel.jkkniu@gmail.com */
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace JWTApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
