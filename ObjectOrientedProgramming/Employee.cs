using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Employee : Company
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeType { get; set; }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Employee(int employeeId, string employeeName, string employeeType, string name, string description) : base(name,description)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            EmployeeType = employeeType;
        }
        public void EmployeeSalaryDetails()
        {
            if (EmployeeType.ToUpper() == "BOSS")
            {
                Salary();
            }
            else
            {
                Console.WriteLine("You are not a boss");
            }
        }
        private void Salary()
        {
            Console.WriteLine("Salary: 10000");
        }

        public override void CompanyDetails()
        {
            Console.WriteLine($"Company Name: {Name} and Description is {Description}");
        }
    }
}
