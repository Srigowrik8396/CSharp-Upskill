using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class SemiSchoolBus : SemiBus
    {
        public SemiSchoolBus(int wheel) : base(wheel) 
        { 
            
        }
        public sealed override void BusDetails()
        {
            BusDetails();
        }
    }
}
