using Assignment.Part_1;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {

            #region overriede and new
            // Binding as Behavior
            // 1. Static  Binding
            // 2. Dynamic Binding

            // Reference from Parent = Object from Child
            BaseClass RefBase = new DerivedClass1(1, 2);

            RefBase.A = 11;
            //RefBase.B = 12; // Can't Access

            RefBase.DisplayMessage(); // Dynamic Binding
            /// Dynamic Binding [Late Binding]
            /// CRL Will Bind Function Call Based On Object not Reference
            /// at Runtime.

            RefBase = new DerivedClass2(1, 2);
            RefBase.DisplayMessage();
            // Here the parent can't see the child function
            // becouse 'new' key word that tell the compiler this function it's not related to parent fucntion
            // its just new function in child have the same name but not related to each athor

            DerivedClass2 derivedClass2 = new DerivedClass2();
            derivedClass2.DisplayMessage(); // Static Binding [Early Binding]
                                            // so to call it should call from the child
                                            // Compiler will Bind Function Call Based On Reference Not Object
                                            // at Compilation Time.

            #endregion
        }
    }
}
