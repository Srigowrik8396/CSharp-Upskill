using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevision
{
    // Parent class / Base class/ Super class
    public class Company
    {
        public int CompanyId { get; set; } = 1;
        public string CompanyName { get; set; } = "Google";
        public string Location { get; set; } = "India";
        public Company() { }
        public Company(int companyId, string companyName, string location)
        {
            CompanyId = companyId;
            CompanyName = companyName;
            Location = location;
        }
        public void DisplayCompanyDetails()
        {
            Console.WriteLine($"The Company Id is: {CompanyId}, : {CompanyName}, and the location is: {Location}");
        }
        public void DisplayData()
        {
            Console.WriteLine($"Id: {CompanyId} and Name: {CompanyName}");
        }
    }
}
