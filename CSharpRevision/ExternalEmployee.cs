using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevision
{
    public class ExternalEmployee : Company
    {
        public int ExternalEmployeeId { get; set; }
        public string ExternalEmployeeNamee { get; set; }
        public double ExternalEmployeeSalary { get; set; }
        public ExternalEmployee(int externalEmployeeId, string externalEmployeeName, double externalEmployeeSalary,int companyId, string companyName, string location) : base(companyId, companyName, location)
        {
            ExternalEmployeeId = externalEmployeeId;
            ExternalEmployeeNamee = externalEmployeeName;
            ExternalEmployeeSalary = externalEmployeeSalary;
        }
        public void ExternalEmployeeDetails()
        {
            Console.WriteLine($"Employee Name: {ExternalEmployeeNamee} and Salary: {ExternalEmployeeSalary}");
        }
    }
}
