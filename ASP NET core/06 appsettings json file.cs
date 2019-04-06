//--------------------------------appsettings.json-----------------------------------------------
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*"
}


/*
Configuration Sources in ASP.NET Core
>Files(appsettings.json,appsettings.{Environment}.json)
>User secrets
>Environment variables
>Command-line argumnets

To access configuration information
>IConfiguration Service

If we have an environment specific app settings file the settings in that file 
will overwrite the settings in the general app settings.json file
And later source will overwrite the earlier source
Command-line argumnets overwrite Environment variables
Environment variables overwrite User secrets
User secrets overwrite appsettings.{Environment}.json)
appsettings.{Environment}.json) overwrite appsettings.json
*/

//-----------------------------access configuration information--------------------------
//----------appsettings.json------------
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "MyKey": "value of MyKey from appsettings.json"
}
//-----------Startup.cs----------------------
//then the output :-->value of MyKey from appsettings.json
namespace EmployeeManagement
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        { _config = config; }
        
        public void ConfigureServices(IServiceCollection services){}

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.Run(async (context) =>{await context.Response.WriteAsync(_config["MyKey"]);});
        }
    }
}
//----------appsettings.Development.json--------
//if we change this file,add this line -->"MyKey": "value of MyKey from appsettings.Developmet.json"
//then the output will change :-->value of MyKey from appsettings.Developmet.json
{
  "Logging": {
    "LogLevel": {
      "Default": "Debug",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "MyKey": "value of MyKey from appsettings.Developmet.json"
}

//----------launchSettings.json--------
//if we change this file,add this line -->"MyKey": "value of MyKey from environmentVariables"
//overwrite again :-->value of MyKey from environmentVariables
  "profiles": {
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development",
        "MyKey": "value of MyKey from environmentVariables"
      }
    },
