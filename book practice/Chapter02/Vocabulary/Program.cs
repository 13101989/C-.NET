using System.Diagnostics;
using System.Reflection;

namespace Vocabulary
{
    internal class Program
    {
        System.Data.DataSet ds;
        HttpClient client;
        static void Main(string[] args)
        {
            // let the heightInMetres variable become equal to the value 1.88
            double heightInMetres = 1.88;
            Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");
            string horizontalLine = new('-', count: 74);
            char letter = 'A';
            string filePath = """C:\televisions\sony\bravia.txt""";
            Console.WriteLine($"{horizontalLine}");
            Console.WriteLine($"{letter}");
            Console.WriteLine($"{filePath}");
        }
    }
}