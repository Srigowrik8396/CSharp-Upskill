using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Bus
    {
        public int Wheel { get; set; }
        public Bus(int wheel) 
        {
            Wheel = wheel;
        }
        public void BusCapacity()
        {
            Console.WriteLine("Capacity:40");
        }
        public virtual void BusDetails()
        {
            Console.WriteLine($"This bus have {Wheel} wheels");
        }
    }
}
