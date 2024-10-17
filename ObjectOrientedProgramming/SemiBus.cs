using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class SemiBus : Bus
    {
        public SemiBus(int wheel) : base(wheel)
        { 
        }
        public new void BusCapacity()
        {
            Console.WriteLine("Capacity:20");
        }
        public override void BusDetails()
        {
            Console.WriteLine($"This Semi-School-Bus have {Wheel} wheels");
        }
    }
}
