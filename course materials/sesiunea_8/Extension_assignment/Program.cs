using System;

namespace Extension_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint age = 32;
            if (age.CompareAge(31))
                Console.WriteLine("Is older");
            else
                Console.WriteLine("Is younger");

            uint checkAge = 18;
            if (checkAge.IsAdult())
                Console.WriteLine("has reached minimum age of adulthood");
            else
                Console.WriteLine("is not an adult ");

            uint number = 7;
            if (number.CheckIfPrime())
                Console.WriteLine("number is prime");
            else
                Console.WriteLine("number is not prime");
        }
    }
}

