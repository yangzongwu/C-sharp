/*
Use "this" keyword to create an indexer
Just like properties indexers have get and set accessors
*/

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
    }
}

//======================================WebForm1.aspx.cs===============================================================
using System;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();
            Response.Write("Name of Employee with Id=2:" + company[2]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with Id=5:" + company[5]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with Id=8:" + company[8]);
            Response.Write("<br/>");
            Response.Write("chagne namge of employee with id=2,5,8");
            Response.Write("<br/>");
            Response.Write("<br/>");

            company[2] = "2nd Employee Name changed";
            company[5] = "5nd Employee Name changed";
            company[8] = "8nd Employee Name changed";

            Response.Write("Name of Employee with Id=2:" + company[2]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with Id=5:" + company[5]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with Id=8:" + company[8]);
            Response.Write("<br/>");
        }
    }
}
