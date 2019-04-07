//===============================Model==========================================
//Model=Set of classes that represent(Data+manage Data)
//Model : contains Employee+EmployeeRepository
//----------------Models/Employee.cs------------------------------------------
public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }
    
//----------------Models/IEmployeeRepository.cs--------------------------------
public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
    }
    
//----------------Models/MockEmployeeRepository.cs------------------------------------------
//If not use interface, we can not use dependency injection as a result our application
//will be extremely difficult to change and maintain unit testing also become very difficult
public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id=1,Name="Mary",Department="HR",Email="dfds@gmail.com"},
                new Employee(){Id=2,Name="John",Department="IT",Email="SD@gmail.com"},
                new Employee(){Id=3,Name="Mike",Department="IT",Email="SDFS@gmail.com"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
    
    
    
//===================================dependency injection=========================================
/*
To Register with Dependency Injection Container
>AddSingleton()
>AddTransient()
>AddScoped()

Benefits of dependency injection
>Loose Coupling
>Easy to Unit Test
*/
//----------------------------------Startup.cs---------------------------------------------
public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
        }
//----------------------------------HomeController.cs---------------------------------------------
namespace EmployeeManagement.Controllers
{
    public class HomeController: Controller
    {
        //Constructor injection
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepsitory)
        {
            _employeeRepository = employeeRepsitory;
        }

        //No use the following as it is hard to maintain no dependency injection
        //public HomeController( )
        //{
        //    _employeeRepository = new MockEmployeeRepository();
        //}

        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }
    }
}


//===============================Controller==========================================
/*
http://localhost:63788/home/details
return {"id":1,"name":"Mary","email":"dfds@gmail.com","department":"HR"}
http://localhost:63788
return Mary
*/
/*
web(chrome)                             --Request-->
http://xxx.com/employee/details/1<===========================>Controller
                                       <--Response--           |       |
                                                               |       |
                                                               V       V
                                                             View --->Model<======>Data Source
Controller:
Handles the incoming http request
Build the model and
Return the Model data to the caller if we are building an API or
Select a View and pass the model data to the view
The View then generates the required HTML to present the data
*/

//----------------------------------HomeController.cs---------------------------------------------
namespace EmployeeManagement.Controllers
{
    public class HomeController: Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepsitory)
        {
            _employeeRepository = employeeRepsitory;
        }

        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }

        public JsonResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            return Json(model);
        }
        
        
        //public ViewResult Details()
        //{
        //    Employee model = _employeeRepository.GetEmployee(1);
        //    return View(model);
        //}
    }
}


//===============================Views===========================================
/*
InvalidOperationException: The view 'Details' was not found. The following locations were searched:
/Views/Home/Details.cshtml
/Views/Shared/Details.cshtml
/Pages/Shared/Details.cshtml
*/
/*
Views:
A view file has .cshtml extension
A view is an HTML template with embedded Razor markup
Contains logic to display Model data

EmployeesController.cs
//have three method
>Details
>Edit
>List
HomeController.cs
//have three mothed
>Details
>Edit
>Index

then our View folder will be 
Views/Employees/Details.cshtml
Views/Employees/Edit.cshtml
Views/Employees/List.cshtml
Views/Home/Details.cshtml
Views/Home/Edit.cshtml
Views/Home/Index.cshtml
*/


//Add Folder Views under project
//Add Folder Home under Views
//Add Details.cshtml under Home
//run:http://localhost:63788/home/details
//get:Detail from details.cshtml
//----------------------------------HomeController.cs---------------------------------------------
namespace EmployeeManagement.Controllers
{
    public class HomeController: Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepsitory)
        {
            _employeeRepository = employeeRepsitory;
        }

        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            return View(model);
        }
    }
}
//----------------------------------Views/Home/Details.cshtml---------------------------------------------
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <h1>Detail from details.cshtml</h1>
</body>
</html>
