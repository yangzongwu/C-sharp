//----------------------Program.cs------------------------------------------------------------------------
namespace EmployeeManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
    }
}


/*
>A Console application usually has a Main() method
>Why do we have a Main() method in ASP.NET Core Web application
>ASP.NET Core application initially starts as a Console application
>This Main() method configures ASP.NET Core and starts it and at that point
 it becomes an ASP.NET Core web application
*/
