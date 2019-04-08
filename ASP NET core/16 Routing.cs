/*
Routing Techniques
Conventional Routing
Attribute Routing
*/

//===================================Conventional Routing=========================================================
http://localhost:63788/home/index
http://localhost:63788/home/details/1

//----------------------------------------HomeController.cs---------------------------------------------------------
public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepsitory)
        {
            _employeeRepository = employeeRepsitory;
        }

        public ViewResult Index()
        {
            var model= _employeeRepository.GetAllEmployee();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }
    }
    
    
//----------------------------------Startup.cs--------------------------------------------- 
/*
方法1：
app.UseMvcWithDefaultRoute();
方法2：
app.UseMvc(routes=>{routes.MapRoute("default", "{controller=home}/{action=index}/{id?}");});
*/

namespace EmployeeManagement
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
      
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddXmlDataContractSerializerFormatters();
            services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
        }

       
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes=>
            {
                routes.MapRoute("default", "{contoller=home}/{action=index}/{id?}");
            });
            
        }
    }
}


//=============================Attribute Routing=========================================================
/*
>With Attribute Routing,[Route] attribute is used to define the Routes
>Route attribute can be applied on the controller or the Controller Action Methods
>With attribute routing,routes are placed next to the action methods that will actually use them
>Attribute routes offer a bit more flexibility than conventional routes
*/
//----------------------------------Startup.cs--------------------------------------------- 
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            { app.UseDeveloperExceptionPage();}

            app.UseStaticFiles();
            app.UseMvc(); //注意这里没有指定默认的
        }

//----------------------------------------HomeController.cs---------------------------------------------------------
namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepsitory)
        {
            _employeeRepository = employeeRepsitory;
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }
        //下面也可以，方法名可以改变，但是注意
        //这里方法名对应于相对应的cshtml，如果不一样，需要增加路径，如下所示
        //http://localhost:63788/home/index 也会调用List()方法
        //public ViewResult List()
        //{
        //    var model = _employeeRepository.GetAllEmployee();
        //    return View("~/Views/Home/index.cshtml",model);
        //}

        [Route("Home/Details/{id?}")]
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id??1),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }
    }
}

//------------------------------------or-------------------------------------------------------------------
//由于每个地方都有home,可以把他提前到class如下
namespace EmployeeManagement.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepsitory)
        {}
      
        [Route("")]
        [Route("Index")]
        [Route("~/")] //not combile Home
        public ViewResult Index()
        {}
       
        [Route("Details/{id?}")]
        public ViewResult Details(int? id)
        {}
    }
}
//------------------------------------or-------------------------------------------------------------------
namespace EmployeeManagement.Controllers
{
    [Route("[controller]")]//默认controller名称   Home
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepsitory)
        {}

        [Route("")]
        [Route("[action]")]//默认如下方法Index
        [Route("~/")]
        public ViewResult Index()
        { }

        [Route("[action]/{id?}")]//默认如下方法Details
        public ViewResult Details(int? id)
        { }
    }
}
//------------------------------------or-------------------------------------------------------------------
namespace EmployeeManagement.Controllers
{
    [Route("[controller]/[action]")]//action也可以提前写
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepsitory)
        {}

        [Route("")]
        [Route("~/")]
        public ViewResult Index()
        { }
        
        [Route({id?}")]
        public ViewResult Details(int? id)
        { }
    }
}

