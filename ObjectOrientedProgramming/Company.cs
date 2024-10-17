using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public abstract class Company
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public Company(string namee, string description) 
        {
            Name = namee;
            Description = description;
        }
        public abstract void CompanyDetails();
    }
}
