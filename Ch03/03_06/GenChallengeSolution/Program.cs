using System;
using System.Collections.Generic;

namespace GenChallengeSolution
{
    public class ClassicCar
    {
        public string m_Make;
        public string m_Model;
        public int m_Year;
        public int m_Value;

        public ClassicCar(string make, string model, int year, int val) {
            m_Make = make;
            m_Model = model;
            m_Year = year;
            m_Value = val;
        }
    }

    class Program
    {
        static void Main(string[] args) {
            List<ClassicCar> carList = new List<ClassicCar>();
            populateData(carList);

            // How many cars are in the collection?
            Console.WriteLine("There are {0} cars in the entire collection.\n", carList.Count);

            // How many Fords are there?
            List<ClassicCar> fordList = carList.FindAll(FindFords);
            Console.WriteLine("There are {0} Fords in the entire collection.\n", fordList.Count);

            // What is the most valuable car?
            ClassicCar mostValCar = null;
            int highValue = 0;
            foreach (ClassicCar c in carList) {
                if (c.m_Value > highValue) {
                    mostValCar = c;
                    highValue = c.m_Value;
                }
            }
            Console.WriteLine("The most valuable car is a {0} {1} {2} at ${3}\n",
                mostValCar.m_Year, mostValCar.m_Make, mostValCar.m_Model, mostValCar.m_Value);


            // What is the entire collection worth?
            int totalValue = 0;
            foreach (ClassicCar c in carList) {
                totalValue += c.m_Value;
            }
            Console.WriteLine("The collection is worth ${0}\n", totalValue);

            // How many unique manufacturers are there?
            Dictionary<string, bool> makes = new Dictionary<string, bool>();
            foreach (ClassicCar c in carList) {
                try {
                    makes.Add(c.m_Make, true);
                }
                catch (Exception e) { }
            };
            Console.WriteLine("The collection contains {0} unique manufacturers.\n", makes.Keys.Count);


            Console.WriteLine("\nHit Enter key to continue...");
            Console.ReadLine();
        }

        static bool FindFords(ClassicCar car) {
            if (car.m_Make == "Ford")
                return true;
            return false;
        }

        static void populateData(List<ClassicCar> theList) {
            theList.Add(new ClassicCar("Alfa Romeo", "Spider Veloce", 1965, 15000));
            theList.Add(new ClassicCar("Alfa Romeo", "1750 Berlina", 1970, 20000));
            theList.Add(new ClassicCar("Alfa Romeo", "Giuletta", 1978, 45000));

            theList.Add(new ClassicCar("Ford", "Thunderbird", 1971, 35000));
            theList.Add(new ClassicCar("Ford", "Mustang", 1976, 29800));
            theList.Add(new ClassicCar("Ford", "Corsair", 1970, 17900));
            theList.Add(new ClassicCar("Ford", "LTD", 1969, 12000));

            theList.Add(new ClassicCar("Chevrolet", "Camaro", 1979, 7000));
            theList.Add(new ClassicCar("Chevrolet", "Corvette Stringray", 1966, 21000));
            theList.Add(new ClassicCar("Chevrolet", "Monte Carlo", 1984, 10000));

            theList.Add(new ClassicCar("Mercedes", "300SL Roadster", 1957, 19800));
            theList.Add(new ClassicCar("Mercedes", "SSKL", 1930, 14300));
            theList.Add(new ClassicCar("Mercedes", "130H", 1936, 18400));
            theList.Add(new ClassicCar("Mercedes", "250SL", 1968, 13200));
        }
    }
}
