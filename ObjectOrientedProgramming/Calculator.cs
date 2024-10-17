using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Calculator
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition of two number is: {x+y}");
        }
        public void Add(int x, int y,int b)
        {
            Console.WriteLine($"Addition of three number is: {x+y+b}");
        }
    }
}
