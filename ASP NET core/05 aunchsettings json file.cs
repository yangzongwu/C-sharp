//--------------------------------aunchsettings json file-----------------------------------------------
// this file only used local
{
  "iisSettings": {
    "windowsAuthentication": false, 
    "anonymousAuthentication": true, 
    "iisExpress": {
      "applicationUrl": "http://localhost:63788", // which shows online
      "sslPort": 0
    }
  },
  "profiles": {  //debug will do this by default, we can choose this one(IIS Express) or next(EmployeeManagement)
    "IIS Express": {   //by default
      "commandName": "IISExpress",
      "launchBrowser": true,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development" // can change to staging or production
        
        /*
        ------Startup.cs-----------------
        if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        */
        
        
      }
    },
    "EmployeeManagement": {  //used when we use the .net.core CLI
      "commandName": "Project",
      "launchBrowser": true,
      "applicationUrl": "http://localhost:5000",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}


/*
commandName ||  AspNetCoreHostingModel   ||  Internal Web Server            ||   External Web Server
Project     ||  Hosting Setting Ignored  ||  Only one web server-kestrel    ||   Only one web server-kestrel
IISExpress  ||  InProcess                ||  Only one web server-IISExpress ||   Only one web server-IISExpress
IISExpress  ||  OutOfProcess             ||  Kestrel                        ||   IISExpress
IIS         ||  InProcess                ||  Only one web server-IIS        ||   Only one web server-IIS
IIS         ||  OutOfProcess             ||  Kestrel                        ||   IIS 
*/
