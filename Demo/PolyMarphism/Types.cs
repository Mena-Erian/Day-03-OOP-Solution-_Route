using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.PolyMarphism
{
     class TypeA
    {

        public int A { get; set; }

        public TypeA(int a)
        {
            A = a;
        }
        public void MyFun01()
        {
            Console.WriteLine("MyFun01 => Iam Base [Parent]");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"MyFun02 => Type A :{A}");
        }
    }
    internal class TypeB : TypeA
    {

        public int B { get; set; }

        public TypeB(int a,int b) : base(a)
        {
            B = a;
        }
        public new void MyFun01() /* Static Binded Mehtod */
        {
            Console.WriteLine("MyFun01 => Iam Base [Parent]");
        }
        public override void MyFun02() /* Dynamic Binded Mehtod */
        {
           base.MyFun02();
            Console.WriteLine("here is my fun02 type b");

        }
    }
}
