using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }

        public void MyFun01()
        {
            Console.WriteLine("I am Employee");
        }
        public void MyFun02()
        {
            Console.WriteLine($"Eemployee: Id: {Id}, Name: {Name},Age: {Age}");
        }
    }
 
}
