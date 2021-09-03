using System;
using System.Collections.Generic;

namespace ExplicitInterfaces
{
    interface Intf1
    {
        void SomeMethod();
    }
    interface Intf2
    {
        void SomeMethod();
    }

    // TODO: Implement two interfaces with conflicting methods
    class InterfaceTest
    {
        // TODO: Implement Intf1 and Intf2 SomeMethod

        public void SomeMethod() {
            Console.WriteLine("This is the class SomeMethod");
        }
    }

    class Program
    {
        static void Main(string[] args) {
            InterfaceTest testclass = new InterfaceTest();
            testclass.SomeMethod();

            // TODO: Call SomeMethod in the two interfaces

            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}
