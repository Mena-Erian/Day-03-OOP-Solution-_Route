using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part_1
{
    internal class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is Working");
        }
    }
    internal class Manger : Employee
    {
        public new void Work()
        {
            Console.WriteLine("Manager is Managing");
        }

    }
}
