using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
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

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
