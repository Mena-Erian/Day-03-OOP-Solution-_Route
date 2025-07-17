using Demo.Operators_Overloading;

namespace Demo
{
    internal class Program
    {

        static void Main()
        {
            #region Operators Overloading

            Complex C1 = new Complex() { Real = 2, Imag = 4 };
            Complex C2 = new Complex() { Real = 3, Imag = 5 };

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

            #endregion

            #endregion
        }
    }
}
