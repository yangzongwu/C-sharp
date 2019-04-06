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
Some of the Tasks that CreateDefaultBuilder() performs
>Setting up the web server
>Loading the host and application configuration from various configuration sources and
>Configuring logging

An ASP.NET core application can be hosted 
>InProcess 
>OutOfProcess
*/

//-------------------------InProcess--------------------------------------------------------------
To configure InProcess hosting 
<AspNetCoreHostingModel>InProcess</AspNetCoreHostingModel>

CreateDefaultBuilder() method calls UseIIS() method and host the app inside of the IIS 
worder process(w3wp.exe or iisexpress.exe)

InProcess hosting delivers significantly higher request throughput than OutOfProcess hosting

To get the process name executing the app
System.Diagnostics.Process.GetCurrentProcess().ProcessName

with InProcess hosting
>Application is hosted indide the IIS worker process
>There is only one web server
>From a performance standponit,InProcess hosting is better that OutOfProcess hosting

//-------------------------OutOfProcess--------------------------------------------------------------
To configure InProcess hosting 
1.<AspNetCoreHostingModel>OutOfProcess</AspNetCoreHostingModel>
2.or remove this line . default is OutOfProcess

with out of process hosting
>2 Web Servers-Intertnal and External Web Server
>The internal web server is Kestrel
>The external web server can be IIS,Nginx or Apache(depending on the operationg system) 

Kestrel
>Cross-Platform Web Server for ASP.NET Core
>Kestrel can be used, by itself as an edge server
>The process used to host the app is dotnet.exe

1.Kestrel can be used as the internet facing web server
internet <------HTTP------->Kestrel[dotnet.exe[Application]]

2.Kestrel can be uesd in combination with a reverse proxy
internet  <------HTTP------->Reverse Proxy Server(IIS,Nginx,Apache)<------HTTP------->Kestrel[dotnet.exe[Application]]


                           In Process      ||  Out of Process
Process name is w3wp.exe or iisexpress.exe ||  Process name is dotnet.exe
                      Only one web server  ||  Two web servers
                   Better for performance  ||  Penalty of proxying requests between  internal and external web server
