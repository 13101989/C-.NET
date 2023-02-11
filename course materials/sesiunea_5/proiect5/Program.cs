namespace proiect5
{
    class Program
    {
        static void Main()
        {
            var a = new Point(10, 20, 30);
            var b = new Point(3, 2, 3);
            var c = new Point(10, 5, 9);

            var triangle1 = new Triangle(a, b, c);
            Console.WriteLine($"rezultat:{triangle1}");
            Console.WriteLine($"rezultat:{triangle1.Peaks[0]}");
        }
    }
}


