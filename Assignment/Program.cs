using Assignment.Part_1;
using Assignment.Part_2;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            #region overriede and new
            /// // Binding as Behavior
            /// // 1. Static  Binding
            /// // 2. Dynamic Binding
            /// 
            /// // Reference from Parent = Object from Child
            /// BaseClass RefBase = new DerivedClass1(1, 2);
            /// 
            /// RefBase.A = 11;
            /// //RefBase.B = 12; // Can't Access
            /// 
            /// RefBase.DisplayMessage(); // Dynamic Binding
            /// /// Dynamic Binding [Late Binding]
            /// /// CRL Will Bind Function Call Based On Object not Reference
            /// /// at Runtime.
            /// 
            /// RefBase = new DerivedClass2(1, 2);
            /// RefBase.DisplayMessage();
            /// // Here the parent can't see the child function
            /// // becouse 'new' key word that tell the compiler this function it's not related to parent fucntion
            /// // its just new function in child have the same name but not related to each athor
            /// 
            /// DerivedClass2 derivedClass2 = new DerivedClass2();
            /// derivedClass2.DisplayMessage(); // Static Binding [Early Binding]
            /// // so to call it should call from the child
            /// // Compiler will Bind Function Call Based On Reference Not Object
            /// // at Compilation Time.
            #endregion

            #region Part 2

            #region Q1
            /// Duration D1 = new Duration(3600);
            /// Console.WriteLine(D1.ToString());
            /// 
            /// Duration D2 = new Duration(7800);
            /// Console.WriteLine(D2.ToString());
            /// 
            /// Duration D3 = new Duration(666);
            /// Console.WriteLine(D3.ToString());
            #endregion

            #region Binary Operators
            /// D3 = D1 + D2;
            /// D3 = D1 - D2;
            /// D3 = D1 + 7800;
            /// D3 = 666 + D3;
            /// 
            /// Console.WriteLine(D3);
            #endregion

            #region Unary Operators
            /// D3 = ++D1;
            /// D3 = --D2;
            /// 
            /// Console.WriteLine(D3);
            #endregion

            #region Comparison Operators [Relational]
            /// if (D1 > D2)
            /// {
            ///     Console.Write(D1);
            ///     Console.Write(" > ");
            ///     Console.Write(D2);
            /// }
            /// else
            /// {
            ///     Console.Write(D1);
            ///     Console.Write(" < ");
            ///     Console.Write(D2);
            /// }
            /// Console.WriteLine("--------------------------------");
            /// if (D1 <= D2)
            /// {
            ///     Console.Write(D1);
            ///     Console.Write(" <= ");
            ///     Console.Write(D2);
            /// }
            /// else
            /// {
            ///     Console.Write(D1);
            ///     Console.Write(" >= ");
            ///     Console.Write(D2);
            /// } 
            #endregion

            #region Casting Operators Overloading
            //DateTime Obj = (DateTime)D1;
            //Console.WriteLine(Obj.ToString());
            #endregion

            #endregion
        }
    }
}
