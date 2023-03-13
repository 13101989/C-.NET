using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using static System.Console;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = a++;
            Console.WriteLine($"a++ equals {b}");

            a = 1;
            b = ++a;
            Console.WriteLine($"++a equals {b}");

            //for (; ; );

            //    int max = 500;
            //    for (byte i = 0; i < max; i++)
            //    {
            //        WriteLine(i);
            //    }
            //}

            for (int i = 0; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    WriteLine($"fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    WriteLine($"fizz");
                }
                else if (i % 5 == 0)
                {
                    WriteLine($"buzz");
                }
                else
                {
                    WriteLine(i);
                }
            }
            int x = 3;
            int y = 2 + ++x;
            WriteLine($"Value of ++x is {x} value of 2 + ++x is {y}");

            //Binary shift operators:
            x = 3 << 2;
            y = 10 >> 1;
            WriteLine($"Value of 3 << 2 is {x} value of 10 >> 1 is {y}");

            //Bitwise operators:
            x = 10 & 8;
            y = 10 | 7;
            WriteLine($"Value of 10 & 8 is {x} value of 10 | 7 is {y}");


            double m;
            double n;
            WriteLine("Enter a number between o and 255:");
            string? firstNumber = ReadLine();
            try
            {
                if (double.TryParse(firstNumber, out double numberOne))
                {
                    m = numberOne;
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException fe)
            {
                WriteLine($"{fe.GetType()}:{fe.Message}");
                return;
            }


            WriteLine("Enter another number between o and 255:");
            string? secondNumber = ReadLine();

            try
            {
                if (double.TryParse(secondNumber, out double numberTwo))
                {
                    n = numberTwo;
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException fe)
            {
                WriteLine($"{fe.GetType()}:{fe.Message}");
                return;
            }

            double result = m / n;
            WriteLine($"{m} divided by {n} is {result}");
        }
    }
}