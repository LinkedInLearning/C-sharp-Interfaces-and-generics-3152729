using System;
using System.Collections.Generic;

namespace BasicInterfaces
{
    // Define an IStorable interface that provides the ability to load and
    // save the information for an object
    interface IStorable
    {
        void Save();
        void Load();
        bool NeedsSave { get; set; }
    }

    // Implement IStorable on the Document class
    class Document : IStorable
    {
        private string name;

        public Document(string s) {
            name = s;
            Console.WriteLine("Created a document with name '{0}'", s);
        }

        // Implement the IStorable interface methods and properties
        public void Save() {
            Console.WriteLine("Saving the document");
        }

        public void Load() {
            Console.WriteLine("Loading the document");
        }

        public bool NeedsSave {
            get; set;
        }
    }

    class Program
    {
        static void Main(string[] args) {
            Document d = new Document("Test Document");

            // Exercise the IStorable interface
            d.Load();
            d.Save();
            d.NeedsSave = false;

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
