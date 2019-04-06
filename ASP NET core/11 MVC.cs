/*
What is MVC?
Model View Controller

Application Layers contains:
>User Interface Layer---MVC
>Business Logic Layer
>Data Access Layer
*/


/*
for example we want to get employee id==1 details:

web(chrome)                             --Request-->
http://xxx.com/employee/details/1<===========================>Controller
                                       <--Response--           |       |
                                                               |       |
                                                               V       V
                                                             View --->Model<======>Data Source


we want a HTML table like
|----------|------ |
|Employee  |Details|
|----------|------ |
|ID        |1      |
|Name      |John   |
|Deportment|IT     |
|----------|------ |

in order to presents we use View
In MVC a view is only responsible for presenting the model data
If the view logic is too complicated consider using:
>a view model
>or a view component(new in MVC)

*/
/*
MVC Controller
http://xxx.com/employee/details/1
Routing Rules map URLs to Controller Action Methods
*/
public class EmployeeController:EmployeeController
    {
        private IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IActionResult Detals(int id)
        {
            Employee model = employeeRepository.GetEmployee(id);
            return View(model);
        }
    }
    
 //===============Summary=================================================================
 /*
 MVC is an architectural design pattern for implementing User Interface Layer of an applicaiton
 Model : Set of classes that represent data + the logic to manage that data
 View  : Contains the display logic to present the Model data provided to it by the Controller
 Controller : Handles the http request,work with the model, and selects a view to render that model
 */
 
 




//===============set up MVC=================================================================
//Step 1: Add the MVC Services to the Dependency Injection Container
public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();  //?AddMvc vs AddMvcCore
        }
//step 2: Add MVC middleware to the Request Pipeline
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            { app.UseDeveloperExceptionPage(); }
  
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
 

//===============set up MVC=================================================================
//Add folder under project named Controllers
//under Controllers add HomeController.cs
//------------HomeController.cs-----------------
namespace EmployeeManagement.Controllers{
    public class HomeController{
        public string Index()
        { return "Hello from MVC"; }
    }
}
//--------------Startup.cs-----------------
namespace EmployeeManagement
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        { _config = config; }

        public void ConfigureServices(IServiceCollection services)
        { services.AddMvc(); }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            { app.UseDeveloperExceptionPage();  }

            app.UseStaticFiles();
          
          // will process HomeController.cs and return ,will not process the Run() Func
          // so the web will shows: Hello from MVC
            app.UseMvcWithDefaultRoute(); 

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Helloword");
            //});
        }
    }
}



//================AddMvc vs AddMvcCore======================================================================
public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(); 
        }

public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore();  
        }
/*
AddMvcCore() method only adds the core MVC services
AddMvc() method adds all the required MVC services
AddMvc() method calls AddMvcCore() method internally

*/
