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

            // How many key/value pairs are there?
            Console.WriteLine("There are {0} key/value pairs\n", fileTypes.Count);

            // try adding an existing key
            try {
                fileTypes.Add(".htm", "Web page");
            }
            catch (ArgumentException e) {
                Console.WriteLine("Key already exists in Dictionary\n");
            }

            // try removing and then finding a key
            fileTypes.Remove(".css");
            Console.WriteLine("fileTypes contains CSS: {0}\n", fileTypes.ContainsKey(".css"));

            // Dump the contents of the Dictionary
            Console.WriteLine("Dumping Dictionary contents:");
            foreach (KeyValuePair<string, string> kvp in fileTypes) {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("\nHit Enter to continue...");
            Console.ReadLine();
        }
    }
}
