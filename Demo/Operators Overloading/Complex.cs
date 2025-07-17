using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operators_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }


        #region Operators Overloading

        // Overloading Operator: Must be Non-Private Class Member Funciton

        #region Binary Operators
        static public Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) + (right?.Imag ?? 0)
            };
        }
        static public Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0)
            };
        }
        #endregion

        #region Unary Operators
        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Imag = (C?.Imag ?? 0)
            };
        }
        public static Complex operator --(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Imag = (C?.Imag ?? 0)
            };
        }
        #endregion

        #region Comparison Operators [Relational]
        public static bool operator >(Complex left, Complex right)
        {
            if (left?.Real == right.Real)
                return left?.Imag > right?.Imag;
            else
                return left?.Real > right?.Real;
        }
        public static bool operator <(Complex left, Complex right)
        {
            if (left?.Real == right.Real)
                return left?.Imag < right?.Imag;
            else
                return left?.Real < right?.Real;
        }

        public static bool operator >=(Complex left, Complex right)
        {
            if (left?.Real == right.Real)
                return left?.Imag >= right?.Imag;
            else
                return left?.Real >= right?.Real;
        }
        public static bool operator <=(Complex left, Complex right)
        {
            if (left?.Real == right.Real)
                return left?.Imag <= right?.Imag;
            else
                return left?.Real <= right?.Real;
        }
        #endregion

        #region Casting Operators Overloading
        public static explicit operator int(Complex C)
        {
            return C?.Real ?? 0;
        }
        public static explicit /*implicit*/ operator string(Complex C)
        {
            return C?.ToString() ?? string.Empty;
        }

        #endregion


        #endregion

        public override string ToString()
        {
            return $"{Real} + {Imag} i";
        }
    }
}
