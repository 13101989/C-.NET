using static System.Console;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal

            string hyphen = new('-', 111);

            Console.WriteLine($"{hyphen}");
            Console.WriteLine($"{"Type", -20} {"Bytes(s) of memory", -10} {"Min", 30} {"Max", 40}");
            Console.WriteLine($"{hyphen}");
            Console.WriteLine($"{"sbyte", -20} {sizeof(sbyte), -10} {sbyte.MinValue, 38} {sbyte.MaxValue, 40}");
            Console.WriteLine($"{"byte",-20} {sizeof(byte),-10} {byte.MinValue,38} {byte.MaxValue,40}");
            Console.WriteLine($"{"short",-20} {sizeof(short),-10} {short.MinValue,38} {short.MaxValue,40}");
            Console.WriteLine($"{"ushort",-20} {sizeof(ushort),-10} {ushort.MinValue,38} {ushort.MaxValue,40}");
            Console.WriteLine($"{"int",-20} {sizeof(int),-10} {int.MinValue,38} {int.MaxValue,40}");
            Console.WriteLine($"{"uint",-20} {sizeof(uint),-10} {uint.MinValue,38} {uint.MaxValue,40}");
            Console.WriteLine($"{"long",-20} {sizeof(long),-10} {long.MinValue,38} {long.MaxValue,40}");
            Console.WriteLine($"{"ulong",-20} {sizeof(ulong),-10} {ulong.MinValue,38} {ulong.MaxValue,40}");
            Console.WriteLine($"{"float",-20} {sizeof(float),-10} {float.MinValue,38} {float.MaxValue,40}");
            Console.WriteLine($"{"double",-20} {sizeof(double),-10} {double.MinValue,38} {double.MaxValue,40}");
            Console.WriteLine($"{"decimal",-20} {sizeof(decimal),-10} {decimal.MinValue,38} {decimal.MaxValue,40}");
        }
    }
}