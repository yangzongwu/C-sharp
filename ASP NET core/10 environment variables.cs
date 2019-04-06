/*
In most organization we have there three common development environments:
>development
>staging
>production

------------summarize------------------------------------------------------
>ASPNETCORE_ENVIRONMENT varible sets the Runtime Environmnet
>On development machine we set it in aunchSettings.json file
>On staging or Production server we set in the operating system
>Use IHostingEnvironment service to access the runtime environment
>Runtime environment defaults to Production if not set explicitly
>In addition to standard environments(evelopment,staging,production),
>custom enviroments(UAT,QA etc)are also supported
*/


//--------------Startup.cs-----------------
//output Host Environment Development
//output Environment from launchSettings.json---profiles
namespace EmployeeManagement
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {app.UseDeveloperExceptionPage();}
            
            app.UseFileServer();
            
            app.Run(async (context) =>{await context.Response.WriteAsync("Host Environment "+env.EnvironmentName);});
        }
    }
}


/*
if we change launchSettings.json
"profiles": {
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "environmentVariables": {
        //"ASPNETCORE_ENVIRONMENT": "staging",
        "MyKey": "value of MyKey from environmentVariables"
      }
    },
and set local environments
ASPNETCORE_ENVIRONMENT:Development
Then the output :
Host Environment : Development
*/

/*
if we change launchSettings.json
"profiles": {
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "staging",
        "MyKey": "value of MyKey from environmentVariables"
      }
    },
and set local environments
ASPNETCORE_ENVIRONMENT:Development
Then the output :
Host Environment : staging
*/
