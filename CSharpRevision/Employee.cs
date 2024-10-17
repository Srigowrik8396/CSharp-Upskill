using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevision
{
    // Child class/ Derived Class / Sub Class
   public class Employee : Company, IEmployeeSalary
    {
        public int EmployeeId { get; set; }
        public string EmployeeNamee { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public Employee(int employeeId, string employeeName, string address,double salary, int companyId, string companyName, string location) : base (companyId, companyName, location)
        {
            EmployeeId = employeeId;
            EmployeeNamee = employeeName;
            Address = address;
            Salary = salary;
        }
        public void EmployeeDetails()
        {
            Console.WriteLine($"Employee Name: {EmployeeNamee} and Address: {Address}");
        }

        public void EmployeeCompanyDetails()
        {
            Console.WriteLine($"Employee Name: {EmployeeNamee} - Company Name: {CompanyName} and Location: {Location}");
        }
        public void SalaryDetailss()
        {
            Console.WriteLine($"Salary: {Salary}");
        }

    }
}
