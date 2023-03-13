using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshopOOP2
{

    public class Counter
    {
        private int count;
        private static int totalCount;// across all instances

        public static int TotalCount
        {
            get { return totalCount; }
        }

        public int GetNextValue()
        {
            count = count + 1;
            totalCount = totalCount + 1;
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter();
            //Counter c2 = new Counter();
            Counter c2 = c1;
            Counter c3 = new Counter();

            //Console.WriteLine($"c1: {c1.GetNextValue()}");
            //Console.WriteLine($"c1: {c1.GetNextValue()}");
            //Console.WriteLine($"c1: {c1.GetNextValue()}");
            //Console.WriteLine($"c2: {c2.GetNextValue()}");
            //Console.WriteLine($"c1: {c1.GetNextValue()}");

            //Console.WriteLine(Counter.TotalCount); 

            Console.WriteLine($"c1: {c1.GetNextValue()}");
            Console.WriteLine($"c2: {c2.GetNextValue()}");
            Console.WriteLine($"c3: {c3.GetNextValue()}");
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1 == c3);
            Console.WriteLine(c2 == c3);

            int ct1 = 0;
            ct1 = ct1 + 1;
            int ct2 = ct1;
            int ct3 = new int();
            ct3++;


            Console.WriteLine($"ct1: {ct1}");
            Console.WriteLine($"ct2: {ct2}");
            Console.WriteLine($"ct3: {ct3}");
            Console.WriteLine(ct1 == ct2);
            Console.WriteLine(ct1 == ct3);
            Console.WriteLine(ct2 == ct3);

            Console.ReadKey();
        }
    }
}
