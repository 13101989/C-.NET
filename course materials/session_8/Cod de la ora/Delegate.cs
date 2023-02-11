using System.Data;

namespace Delegate
{
	public class MatC 
	{
		public static long Aduna(int x, int y) 
		{
			return x + y;
		}

		public static long Produs(int x, int y)
		{
			return x * y;
		}
	}

	internal class Program
	{
		public delegate long Del(int x, int y); //defenire delegat

		static void Main(string[] args)
		{
			Del operatie;
			operatie = MatC.Aduna;
			Console.WriteLine("Suma = {0}", operatie(10, 20));

			operatie = MatC.Produs;
			Console.WriteLine("Produs = {0}", operatie(10, 20));

			Console.ReadKey();
		}
	}
}