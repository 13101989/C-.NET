using System.Diagnostics;
using static System.Console;

namespace IterationStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            //string? password;
            //int attempts = 0;
            //do
            //{
            //    Write($"Attempt: {attempts}");
            //    Write("Enter your password: ");
            //    password = ReadLine();

            //    if (password == "Pa$$w0rd")
            //    {
            //        Write("Correct");
            //    }

            //    attempts++;
            //    if (attempts == 2)
            //    {
            //        Write("You have reached the maximum allowed attempts! You will be disconnected");
            //        break;
            //    }
            //}
            //while (password != "Pa$$w0rd");

            for (int y = 1; y <= 10; y++)
            {
                WriteLine($"Iteration number: {y}");
            }

            string[] names = { "Adam", "Barry", "Charlie" };
            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}