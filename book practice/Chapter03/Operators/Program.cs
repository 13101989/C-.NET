using System.Diagnostics;
using static System.Console;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 6;
            p += 3; // equivalent to p = p + 3;
            p -= 3; // equivalent to p = p - 3;
            p *= 3; // equivalent to p = p * 3;
            p /= 3; // equivalent to p = p / 3;

            bool a = true;
            bool b = false;
            WriteLine($"AND  | a     | b    ");
            WriteLine($"a    | {a & a,-5} | {a & b,-5} ");
            WriteLine($"b    | {b & a,-5} | {b & b,-5} ");
            WriteLine();
            WriteLine($"OR   | a     | b    ");
            WriteLine($"a    | {a | a,-5} | {a | b,-5} ");
            WriteLine($"b    | {b | a,-5} | {b | b,-5} ");
            WriteLine();
            WriteLine($"XOR  | a     | b    ");
            WriteLine($"a    | {a ^ a,-5} | {a ^ b,-5} ");
            WriteLine($"b    | {b ^ a,-5} | {b ^ b,-5} ");
        }
    }
}