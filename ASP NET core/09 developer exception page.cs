//--------------Startup.cs-----------------
// http://localhost:63788/-->hello from default.html
// http://localhost:63788/ad.html-->detail of error include "some error happend"


/*
http://localhost:63788/
first go to middleware UseDeveloperExceptionPage
then go to middleware UseFileServer
server the page :detail.html
then return
*/

/*
http://localhost:63788/ad.html
first middleware:UseDeveloperExceptionPage
second middleware:UseFileServer, can not find ad.html
third middleware:Run  get an Exception return
last:UseDeveloperExceptionPage serve the output page with Exception
*/

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

            app.UseFileServer();

            app.Run(async (context) =>
            {
                throw new Exception("some error happend");
                await context.Response.WriteAsync("Hello word");
            });
        }
    }
}


/*
if we change UseDeveloperExceptionPage to last
we can get error but we can not get the error details
as no func to server the Exception
*/
namespace EmployeeManagement
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseFileServer();

            app.Run(async (context) =>
            {
                throw new Exception("some error happend");
                await context.Response.WriteAsync("Hello word");
            });
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        }
    }
}

//----------------------------------------------------------------------------------
//SourceCodeLineCount
// determines the number of lines of source code to display before and after the
// line that actually causes the exception
if (env.IsDevelopment())
{
  DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions()
  {
    SourceCodeLineCount = 1
  };
  app.UseDeveloperExceptionPage(developerExceptionPageOptions);
}


//==========================summarize===========================================================================
>To enable plug in UseDeveloperExceptionPage Middleware in the pipeline
>Must be plugged in the pipeline as early as possible
>Contains Stack Trace,Queue String,Cookies and HTTP headers
>For customizing use developerExceptionPageOptions object
