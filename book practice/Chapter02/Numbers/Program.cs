using System.Diagnostics;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // unsigned integer means positive whole number or 0
            uint naturalNumber = 23;
            // integer means negative or positive whole number or 0
            int integerNumber = -23;
            // float means single-precision floating point
            // F suffix makes it a float literal
            float realNumber = 2.3F;
            // double means double-precision floating point
            // double is the default type for a number value with a decimal point .
            double anotherRealNumber = 2.3; // double literal
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");
        }
    }
}