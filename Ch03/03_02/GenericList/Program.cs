using System;
using System.Collections.Generic;

namespace GenericList
{
    class Employee
    {
        public string mName;
        public int mSalary;

        public Employee(string name, int salary) {
            mName = name;
            mSalary = salary;
        }
    }

    class Program
    {
        static void Main(string[] args) {
            // TODO: Create a new empty List for Employee objects 

            // TODO: Add some records to the list

            // TODO: Inspect some List properties

            // TODO: Use Exists() and Find()

            // TODO: Use ForEach to iterate over each item

            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }

        // Iterator function for the ForEach method
        //static int total = 0;
        //static void TotalSalaries(Employee e) {
        //    total += e.mSalary;
        //}

        // delegate function to use for the Exists method
        //static Boolean HighPay(Employee emp) {
        //    return emp.mSalary >= 65000;
        //}
    }
}
