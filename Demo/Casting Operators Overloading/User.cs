using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Casting_Operators_Overloading
{
    // Model: is a Class that Represents a Data in a Table

    internal class User
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string?  Email { get; set; }
        public string?  Password  { get; set; }
        public Guid SecriryStmp { get; set; }
    }
}
