using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevision
{
    class Program
    {
        static void Main(string[] args)
        {
            //Company companyObj = new Company();
            //companyObj.DisplayCompanyDetails();
            //companyObj.DisplayData();

            //Employee employee = new Employee(101, "Johnsnow", "No 1 Flat",
            //    30000,4589, "Google", "London");
            //employee.DisplayCompanyDetails();
            //employee.EmployeeCompanyDetails();
            //employee.EmployeeDetails();
            //employee.SalaryDetails();

            //Boss facebookBoss = new Boss(101, "Barathean", "No 1 Flat",
            //    30000, 4589, "Facebook", "USA");
            //facebookBoss.DisplayCompanyDetails();
            //facebookBoss.EmployeeCompanyDetails();
            //facebookBoss.EmployeeDetails();
            //facebookBoss.SalaryDetails();

            ExternalEmployee externalEmployeeObj = new ExternalEmployee(101, "Barathean",
                30000, 4589, "Facebook", "USA");
            externalEmployeeObj.DisplayCompanyDetails();
            externalEmployeeObj.ExternalEmployeeDetails();

            /*
             * Company - Parent 
             * Employee - Child 
             * External Employee - Child
             */
            
        }
    }
}
