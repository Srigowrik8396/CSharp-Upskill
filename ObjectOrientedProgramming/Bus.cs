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
        public Bus(int wheell) 
        {
            Wheel = wheell;
        }
        public void BusCapacity()
        {
            Console.WriteLine("Capacity:40");
        }
        public virtual void BusDetail()
        {
            Console.WriteLine($"This bus have {Wheel} wheels");
        }
    }
}
