using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args) {
            // Create a Dictionary that maps strings to strings
            Dictionary<string, string> fileTypes = new Dictionary<string, string>();
            // Add some file type extensions and their descriptions
            fileTypes.Add(".txt", "Text File");
            fileTypes.Add(".htm", "HTML Web Page");
            fileTypes.Add(".html", "HTML Web Page");
            fileTypes.Add(".css", "Cascading Style Sheet");
            fileTypes.Add(".xml", "XML Data");

            // TODO: How many key/value pairs are there?

            // TODO: try adding an existing key

            // TODO: try removing and then finding a key

            // TODO: Dump the contents of the Dictionary

            Console.WriteLine("\nHit Enter to continue...");
            Console.ReadLine();
        }
    }
}
