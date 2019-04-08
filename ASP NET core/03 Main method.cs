/*
>A Console application usually has a Main() method
>Why do we have a Main() method in ASP.NET Core Web application
>ASP.NET Core application initially starts as a Console application
>This Main() method configures ASP.NET Core and starts it and at that point
 it becomes an ASP.NET Core web application
*/
/*
ASP.NET Core 应用程序最初作为控制台应用程序启动，而Program.cs文件中的Main（)方法就是入口。
当运行时执行我们的应用程序时，它会查找此Main（）方法以及执行配置开始的地方
CreateWebHostBuilder（）方法返回一个实现IWebHostBuilder的对象。
在此对象上，调用Build（）方法，会将我们的ASP.NET Core 应用程序生成并且托管到服务器上。
在服务器上的程序调用Run（） 方法，该方法运行后Web应用程序并开始侦听传入的HTTP请求。
CreateWebHostBuilder（）方法调用静态类WebHost中的静态方法CreateDefaultBuilder（）。
CreateDefaultBuilder（）方法会在服务器上创建一个已经预设置好的默认值。
CreateDefaultBuilder()方法执行多项操作来创建服务器.


而现在你只需要了解CreateDefaultBuilder（）方法是用于在服务器上创建程序配置的默认值而存在。
它作为设置服务器的一部分，还使用了IWebHostBuilder接口中的UseStartup（）的扩展方法来配置Startup类。
Startup类虽然只有两个方法，但是这两个方法做了非常重要的事情：
ConfigureServices（）方法配置应用程序所需的服务
Configure（）方法配置应用程序的请求处理管道

*/
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


