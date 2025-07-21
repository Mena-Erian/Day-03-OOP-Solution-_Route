using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part_1
{
    // Look at Main Funcion (overriede and new Regon)
    internal class BaseClass
    {
        public int A { get; set; }
        public BaseClass()
        {

        }
        public BaseClass(int a)
        {
            A = a;
        }

        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }
    }
    internal class DerivedClass1 : BaseClass
    {
        public int B { get; set; }
        public DerivedClass1()
        {

        }
        public DerivedClass1(int a, int b) : base(a)
        {
            B = b;
        }
        public override void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass1");
        }

    }
    internal class DerivedClass2 : BaseClass
    {
        public int B { get; set; }
        public DerivedClass2()
        {

        }
        public DerivedClass2(int a, int b) : base(a)
        {
            B = b;
        }
        public new void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass2");
        }
    }
}
