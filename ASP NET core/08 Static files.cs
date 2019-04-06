/*
1.all the static files must in wwwroot folder which directly under project
2. add use static files middleware to our applications request processing pipeline
*/


//--------------------------------------Startup.cs----------------------------------------------
//output http://localhost:63788/--> Hello word
//output http://localhost:63788/DSC_0458.JPG -->can get DSC_0458.JPG which in wwwroot folder
//if we add images folder under wwwroot and move pic under images
//should change to :http://localhost:63788/images/DSC_0458.JPG
//app.UseStaticFiles(); only serve static files that present in this wwwroot folder
namespace EmployeeManagement
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello word");
            });
        }
    }
}


//--------------------------------------Startup.cs----------------------------------------------
// now each time we get "Hello word", but we want to get a default html
// default html must be : default.htm,default.html,index.htm,index.html
// add default.html under wwwroot folder
// add app.UseDefaultFiles(); must be before app.UseStaticFiles();
// output-->default.html
// what if we do not want the default.html?
namespace EmployeeManagement
{
    public class Startup
    {  
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello word");
            });
        }
    }
}


//--------------------------------------Startup.cs----------------------------------------------
// what if we do not want the default.html?
// add foo.html under wwwroot folder
namespace EmployeeManagement
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            defaultFilesOptions.DefaultFileNames.Clear();
            defaultFilesOptions.DefaultFileNames.Add("foo.html");
            app.UseDefaultFiles(defaultFilesOptions);
            app.UseStaticFiles();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello word");
            });
        }
    }
}


//----------------------or------------------------------
namespace EmployeeManagement
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            defaultFilesOptions.DefaultFileNames.Clear();
            defaultFilesOptions.DefaultFileNames.Add("foo.html");
            app.UseFileServer();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello word");
            });
        }
    }
}


//----------------------or------------------------------
// change the default html
namespace EmployeeManagement
{
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            FileServerOptions fileServer = new FileServerOptions();
            fileServer.DefaultFilesOptions.DefaultFileNames.Clear();
            fileServer.DefaultFilesOptions.DefaultFileNames.Add("foo.html");
            app.UseFileServer(fileServer);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello word");
            });
        }
    }
}

/*
Static Files in ASP.NET Core
>By default an ASP.NET Core application will not serve static files
>The default directory for static files is wwwroot
>To serve static files UserStaticFiles() middleware is required
>To serve a default file UserDefaultFiles() middleware is required

>The following are the default files
  >index.htm
  >index.html
  >default.htm
  >default.html
  
>UseDefaultFiles() must be registered before UserStaticFiles()
>UserFileServer combines the functionality of UseStaticFiles, UseDefaultFiles and UseDirectoryBrowser middleware


*/
