using System;
using System.Runtime.ConstrainedExecution;

namespace CollectionsAssignment
{
    class Program
    {
        static void Main()
        {
            List<string> CarCompany = new List<string>() { "Fiat", "BMW", "Mercedes" };

            CarCompany.Add("Audi");
            CarCompany.Insert(0, "Skoda");
            CarCompany.Remove("BMW");

            Console.WriteLine("Current list:");
            foreach (string car in CarCompany)
            {
                Console.WriteLine(car);
            }

            CarCompany.Sort();
            Console.WriteLine("\nSorted list:");
            CarCompany.ForEach(car => Console.WriteLine(car));

            CarCompany.Reverse();
            Console.WriteLine("\nReverse of sorted list:");
            CarCompany.ForEach(car => Console.WriteLine(car));
        }
    }
}





