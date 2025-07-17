using Demo.Casting_Operators_Overloading;
using Demo.Operators_Overloading;
using Demo.PolyMarphism;

namespace Demo
{
    internal class Program
    {

        static void Main()
        {
            #region Operators Overloading

            /// Complex C1 = new Complex() { Real = 2, Imag = 4 };
            /// Complex C2 = new Complex() { Real = 3, Imag = 5 };

            #region Binary Operators
            /// Complex C3 = default;
            /// 
            /// C3 = C1 + C2;
            /// //C2 += C1;
            /// //Complex C4 = C1 + C2 + C3;
            /// 
            /// Console.WriteLine(C3);
            #endregion

            #region Unary Operators
            /// Complex C3 = ++C1;
            /// C3 = C1++;
            /// 
            /// Console.WriteLine(C3);

            #endregion

            #region Comparison Operators [Relational]
            /// if(C1 > C2)
            /// {
            ///     Console.WriteLine("C1 is Greater Than C2");
            /// }
            /// else if (C1 < C2) 
            /// {
            ///     Console.WriteLine("C1 is !Greater Than C2");
            /// }
            /// else
            /// {
            ///     Console.WriteLine("C1 Equal C2");
            /// }
            #endregion

            #region Casting Operators Overloading

            #region Example 01
            /// //object O1 = 5; // Boxing
            /// //O1 = (int)5;   // UnBoxing
            /// 
            /// C1 = new Complex() { Real = 4, Imag = 3 };
            /// 
            /// int Y = (int)C1;
            /// 
            /// Console.WriteLine(Y); 
            #endregion

            #region Example 02
            /// string Y = (string)C1;
            /// 
            /// Console.WriteLine(Y); 
            #endregion

            #region Business Example 
            /// User user = new User()
            /// {
            ///     Id = 1,
            ///     FullName = "Mena Erian",
            ///     Email = "codewithmena@gmail.com",
            ///     Password = "p@ssword",
            ///     SecriryStmp = Guid.NewGuid(),
            /// };
            /// UserViewModel userViewModel = (UserViewModel)user;
            /// 
            /// Console.WriteLine(userViewModel.Id);
            /// Console.WriteLine(userViewModel.FName);
            /// Console.WriteLine(userViewModel.LName);
            /// Console.WriteLine(userViewModel.Email);
            /// Console.WriteLine(userViewModel.Password); 
            #endregion

            #endregion

            #endregion

            #region Overriding
            /// TypeA typeA = new TypeB(2,4);
            /// typeA.MyFun02(); // Dynamic Binding (Happen in Run Time)
            #endregion

            #region What is Binding
            /// // Binding as Behavior
            /// // 1. Static  Binding
            /// // 2. Dynamic Binding
            ///
            /// // Reference from Parent = Object from Child
            /// TypeA RefBase = new TypeB(1, 2);
            ///
            /// RefBase.A = 11;
            /// //RefBase.B = 12; // Can't Access
            /// RefBase.MyFun01(); // `Iam Base [Parent]` Static  Binding
            /// /// Static Binding [Early Binding]
            /// /// Compiler will Bind Function Call Based On Reference Not Object
            /// /// at Compilation Time.
            ///
            /// RefBase.MyFun02(); // Dynamic Binding
            /// /// Dynamic Binding [Late Binding]
            /// /// CRL Will Bind Function Call Based On Object not Reference
            /// /// at Runtime.
            #endregion

            #region Not Binding is (Casting)
            //TypeA typeA;
            //typeA = new TypeA(1);
            //typeA = new TypeB(1,2);

            //TypeB typeB = (TypeB) typeA; 
            #endregion

            #region 

            #endregion

        }
    }
}
