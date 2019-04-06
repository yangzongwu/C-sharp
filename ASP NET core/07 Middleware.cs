//--------------Startup.cs-----------------
// there have twoo Middleware used 
// UseDeveloperExceptionPage  &&  Run
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

            app.Run(async (context) =>
            {
                await context.Response .WriteAsync(_config["MyKey"]);
            });
        }
    }
}


/*
<===>Loggin<====>staticFiles<=====>MVC<============>
In ASP.NET Core, a Middleware component has access to both - the incoming request and the outgoing response. 
So a Middleware component may process an incoming request and pass that request to the next piece of middleware 
in the pipeline for further processing. For example, if you have a logging middleware, it might simply log the 
time the request is made and pass the request to the next piece of middleware for further processing.

A middleware component may handle the request and decide not to call the next middleware in the pipeline. 
This is called short-circuiting the request pipeline. Short-circuiting is often desirable because it avoids 
unnecessary work. For example, if the request is for a static file like an image or css file, the StaticFiles 
middleware can handle and serve that request and short-circuit the rest of the pipeline. This means in our case, 
the StaticFiles middleware will not call the MVC middleware if the request is for a static file.

A middleware component may handle an incoming HTTP request by generating an HTTP response. For example, 
mvcmiddleware in the pipeline handles a request to the URL /employees and returns a list of employees. As we 
progress through this course, in our upcoming videos we will be including the mvcmiddleware in the request 
processing pipeline of our application. 


Middleware in ASP.NET Core
>Has access to both Request and Response
>May simply pass the Request to next Middleware
>May process and then pass the Request to next Middleware
>May handle the Request and short-circuit the pipeline
>May process the outgoing Response
>Middlewares are executed in the order they are added
*/
