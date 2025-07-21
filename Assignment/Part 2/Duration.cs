using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part_2
{
    internal class Duration
    {
        #region Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Constructors
        private Duration()
        {

        }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }
        #endregion

        #region Operators Overloading

        #region Binary Operators
        static public Duration operator +(Duration left, Duration right)
        {
            return new Duration()
            {
                Hours = (left?.Hours ?? 0) + (right?.Hours ?? 0),
                Minutes = (left?.Minutes ?? 0) + (right?.Minutes ?? 0),
                Seconds = (left?.Seconds ?? 0) + (right?.Seconds ?? 0)
            };
        }
        static public Duration operator -(Duration left, Duration right)
        {
            return new Duration()
            {
                Hours = (left?.Hours ?? 0) - (right?.Hours ?? 0),
                Minutes = (left?.Minutes ?? 0) - (right?.Minutes ?? 0),
                Seconds = (left?.Seconds ?? 0) - (right?.Seconds ?? 0)
            };
        }
        static public Duration operator +(Duration left, int seconds)
        {
            Duration right = new Duration(seconds);
            return new Duration()
            {
                Hours = (left?.Hours ?? 0) + (right?.Hours ?? 0),
                Minutes = (left?.Minutes ?? 0) + (right?.Minutes ?? 0),
                Seconds = (left?.Seconds ?? 0) + (right?.Seconds ?? 0)
            };
        }
        static public Duration operator +(int seconds, Duration right)
        {
            return right + seconds;
        }
        #endregion

        #region Unary Operators
        public static Duration operator ++(Duration C)
        {
            return new Duration()
            {
                Hours = (C?.Hours ?? 0),
                Minutes = (C?.Minutes ?? 0) + 1,
                Seconds = (C?.Seconds ?? 0)
            };
        }
        public static Duration operator --(Duration C)
        {
            return new Duration()
            {
                Hours = (C?.Hours ?? 0),
                Minutes = (C?.Minutes ?? 0) - 1,
                Seconds = (C?.Seconds ?? 0)
            };
        }
        #endregion

        #region Comparison Operators [Relational]
        public static bool operator >(Duration left, Duration right)
        {
            if (left?.Hours == right?.Hours)
            {
                if (left?.Minutes == right?.Minutes)
                {
                    if (left?.Seconds == right?.Seconds)
                        return false;
                    else
                        return left?.Seconds > right?.Seconds;
                }
                else
                    return left?.Minutes > right?.Minutes;
            }
            return left?.Hours > right?.Hours;


        }
        public static bool operator <(Duration left, Duration right)
        {
            if (left?.Hours == right?.Hours)
            {
                if (left?.Minutes == right?.Minutes)
                {
                    if (left?.Seconds == right?.Seconds)
                        return false;
                    else
                        return left?.Seconds < right?.Seconds;
                }
                else
                    return left?.Minutes < right?.Minutes;
            }
            return left?.Hours < right?.Hours;
        }

        public static bool operator >=(Duration left, Duration right)
        {
            if (left?.Hours == right?.Hours)
            {
                if (left?.Minutes == right?.Minutes)
                {
                    if (left?.Seconds == right?.Seconds)
                        return left?.Seconds >= right?.Seconds;
                    else
                        return left?.Seconds >= right?.Seconds;
                }
                else
                    return left?.Minutes >= right?.Minutes;
            }
            return left?.Hours >= right?.Hours;
        }
        public static bool operator <=(Duration left, Duration right)
        {
            if (left?.Hours == right?.Hours)
            {
                if (left?.Minutes == right?.Minutes)
                {
                    if (left?.Seconds == right?.Seconds)
                        return left?.Seconds <= right?.Seconds;
                    else
                        return left?.Seconds <= right?.Seconds;
                }
                else
                    return left?.Minutes <= right?.Minutes;
            }
            return left?.Hours <= right?.Hours;
        }
        #endregion

        #region Casting Operators Overloading
        public static explicit operator DateTime(Duration C)
        {
            return new DateTime(1, 1, 1, C?.Hours ?? 0 , C?.Minutes ?? 0, C?.Seconds ?? 0);
        }
        #endregion

        #endregion

        #region Methods
        public override string ToString()
        {
            string hours = Hours == 0 ? string.Empty : "Hours: " + Hours.ToString() + ", ";

            return $"{hours}Minutes: {Minutes} ,Seconds: {Seconds}";
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}

//{
//    // seconds
//    // time = second /100/100
//    // time > 1
//    //          true:
//    //              if have fractions (((time * 100) % 25) == 0)
//    //                  true: SET HOURS and return.
//    //                  false:
//    //                      Set HOURS = Math.Floor(seconds)
//    //                      minTemp   = (seconds - Math.Floor(seconds)) * 60 ;
//    //                       if have fractions (((minTemp * 100) % 25) == 0)
//    //                             true: SET MINUTS and return.
//    //                             false:
//    //                                  Set MINUTS = Math.Floor(minTemp)
//    //                                  secTemp    =  (minTemp - Math.Floor(minTemp)) * 60 ;
//    //                                  SET Seconds
//    //                      

//    decimal hourTemp = (seconds / 60m) / 60m;
//    decimal minTemp = 0;
//    decimal secTemp = 0;
//    if (hourTemp >= 1)
//    {
//        if (((hourTemp * 100) % 25) == 0)
//        {
//            Hours = (int)hourTemp;
//            return;
//        }
//        else
//        {
//            Hours = (int)Math.Floor(hourTemp);
//            minTemp = (hourTemp - Math.Floor(hourTemp)) * 100;
//            if (((minTemp * 100) % 25) == 0)
//            {
//                Minutes = (int)minTemp;
//                return;
//            }
//            else
//            {
//                Minutes = (int)Math.Floor(minTemp);
//                secTemp = (minTemp - Math.Floor(minTemp));
//                Seconds = (int)secTemp;
//            }

//        }
//    }



//else
//{
//    minTemp = (hourTemp - Math.Floor(hourTemp)) * 60;
//    Console.WriteLine(minTemp);
//}
//}