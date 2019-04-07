//----------------------------------Project/Models/IEmployeeRepository.cs--------------------------
namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();//new add
    }
}


//----------------------------------Project/Models/MockEmployeeRepository.cs--------------------------
namespace EmployeeManagement.Models
{
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

        public IEnumerable<Employee> GetAllEmployee()   // add this function as interface IEmployeeRepository add a function
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}

//----------------------------------Project/Controllers/HomeController.cs--------------------------
namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepsitory)
        {
            _employeeRepository = employeeRepsitory;
        }

        public ViewResult Index()  //change this function to pass all the info to html
        {
            var model= _employeeRepository.GetAllEmployee();
            return View(model);
        }

        public ViewResult Details()
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(1),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }
    }
}

//----------------------------------Project/Views/Home/Index.cshtml--------------------------
@model IEnumerable<EmployeeManagement.Models.Employee>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <table>
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Department</th>
            </tr>
        </thead>
        <tbody>
            @foreach(var employee in Model)
            {
            <tr>
                <td>@employee.Id</td>
                <td>@employee.Name</td>
                <td>@employee.Department</td>
            </tr>
            }
        </tbody>
    </table>
</body>
</html>


//-----------------------Output-------------------------------------------------------------

ID	Name	Department
1	Mary	HR
2	John	IT
3	Mike	IT
