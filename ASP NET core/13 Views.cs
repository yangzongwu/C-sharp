//======================================Customize view discovery================================================
/*
View() or View(object model):Looks for a view file with the same name as the action method

View(string viewName)
>Looks for a view file with your own custom name
>You can specify a view name or a view file path
>View file path can be absolute or relative
>With absolute path .cshtml extension must be specified
>with relative path do not sepecify the file extension .cshtml

View(string viewName,object model)
*/


//----------------Project/Controllers/HomeController.cs--------------------------------------------------
/*
 在指定的文件夹下面views不需要后缀，在其他文件夹下面的cshtml需要文件名后缀
 默认地址为 Project/Views/Home/Details.cshtml
 ..表示地址后退一级
*/
namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepsitory)
        {  _employeeRepository = employeeRepsitory; }

        public string Index()
        { return _employeeRepository.GetEmployee(1).Name; }
        
        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            return View(model); //http://localhost:63788/home/details-->Project/Views/Home/Details.cshtml
            return View("Test"); //http://localhost:63788/home/details-->Project/Views/Home/Test.cshtml
            return View("MyViews/Test.cshtml"); //http://localhost:63788/home/details-->Project/MyView/Test.cshtml
            return View("/MyViews/Test.cshtml"); //http://localhost:63788/home/details-->Project/MyView/Test.cshtml
            return View("~/MyViews/Test.cshtml"); //http://localhost:63788/home/details-->Project/MyView/Test.cshtml
            return View("../Test/Update"); //http://localhost:63788/home/details-->Project/Views/Test/Update.cshtml
            return View("../../MyViews/Test");//http://localhost:63788/home/details-->Project/MyView/Test.cshtml
        }
    }
}


//========================================Passing data to view============================================
/*
Different ways of passing data to a View from a Controller
>ViewData
>ViewBag
>Strongly Typed View
*/


//-------------------------------------------------ViewData---------------------------------------------------
/*
>Dictionary of weakly typed objects
>Use string keys to store and retrieve data
>Dynamically resolved at runtime
>No compile-time type checking and Intellisens
*/

//----------------Project/Controllers/HomeController.cs-------------------------
public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            ViewData["Employee"] = model;
            ViewData["PageTitle"] = "Employee Details";
            return View();
        }
//----------------Project/Views/Home/Details.cshtml-------------------------
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <h3>@ViewData["PageTitle"]</h3>
    @{ 
        var employee = ViewData["Employee"] as EmployeeManagement.Models.Employee;
    }
    <div>
        Name: @employee.Name
    </div>
    <div>
        Email: @employee.Email
    </div>
    <div>
        Department: @employee.Department
    </div>
</body>
</html>
//----------------output------------------------------------------------------
//http://localhost:63788/home/details
/*
Employee Details
Name: Mary
Email: dfds@gmail.com
Department: HR
*/


//-------------------------------------------------ViewBag---------------------------------------------------
/*
ViewBag VS ViewData
>ViewBag is a wrapper around ViewData
>Both of them create a loosely typed view
>ViewData use string keys to store and retrieve data
>ViewBag use dynamic properties to store and retrieve data
>Both are resolved dynamically at runtime. 
>Both do not provide compile-time type checking and intellisense.
>Preferred approach to pass data from a controller to a view is by using a strongly typed. 
*/

//----------------Project/Controllers/HomeController.cs-------------------------
public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            ViewBag.Employee=model;
            ViewBag.PageTitle="Employee Details";
            return View();
        }
//----------------Project/Views/Home/Details.cshtml-------------------------
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <h3>@ViewBag.PageTitle</h3>

    <div>
        Name: @ViewBag.Employee.Name
    </div>
    <div>
        Email: @ViewBag.Employee.Email
    </div>
    <div>
        Department: @ViewBag.Employee.Department
    </div>
</body>
</html>
//----------------output------------------------------------------------------
//http://localhost:63788/home/details
/*
Employee Details
Name: Mary
Email: dfds@gmail.com
Department: HR
*/


//----------------------------------------Strongly Typed View----------------------------------------------
/*
To Create a Strong Typed View
>specify model typed in the view using @model directive
>To access the model object properties we use @Model
>Strongly Typed View provides compile-time type checking and intellisense
*/
//----------------Project/Controllers/HomeController.cs-------------------------
public ViewResult Details()
{
    Employee model = _employeeRepository.GetEmployee(1);
    ViewBag.PageTitle="Employee Details";
    return View(model);
}
//----------------Project/Views/Home/Details.cshtml-------------------------
@model EmployeeManagement.Models.Employee

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <h3>@ViewBag.PageTitle</h3>

    <div>
        Name: @Model.Name
    </div>
    <div>
        Email: @Model.Email
    </div>
    <div>
        Department: @Model.Department
    </div>
</body>
</html>
//----------------output------------------------------------------------------
//http://localhost:63788/home/details
/*
Employee Details
Name: Mary
Email: dfds@gmail.com
Department: HR
*/

