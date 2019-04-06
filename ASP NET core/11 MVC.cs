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
 MVC is an architectural design pattern for implementing User Interface Layer of an applicaiton
 Model : Set of classes that represent data + the logic to manage that data
 View  : Contains the display logic to present the Model data provided to it by the Controller
 Controller : Handles the http request,work with the model, and selects a view to render that model
