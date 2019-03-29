
//=====================Company.cs=========================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public class Company
    {
        private List<Employee> listEmployees;
        public Company()
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee() { EmployeeId = 1, Name = "mike", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 2, Name = "mikse", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 3, Name = "miske", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 4, Name = "midke", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 5, Name = "miake", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 6, Name = "migfke", Gender = "Female" });
        }

        public string this[int employeeId]
        {
            get {
                return listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;

            }
            set
            {
                listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
            }
        }
        public string this[string Gender]
        {
            get
            {
                return listEmployees.Count(emp => emp.Gender == Gender).ToString();

            }
            set
            {
                foreach(Employee employee in listEmployees)
                {
                    if (employee.Gender == Gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }
    }
}


//======================================WebForm1.aspx.cs============================
using System;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();
            company[2] = "mark";
            Response.Write("Total Male Employees=" + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Female Employees=" + company["Female"]);
            Response.Write("<br/>");
            company["Male"] = "Female";
            Response.Write("Total Female Employees=" + company["Female"]);
            //Total Male Employees=3
            //Total Female Employees = 3
            //Total Female Employees = 6
        }
    }
}
