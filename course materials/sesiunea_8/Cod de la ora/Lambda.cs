namespace Lambda
{
	internal class Program
	{
		public static bool IsOdd(int n)
		{
			if (n % 2 == 1)
			{
				return true;
			}
			return false;
		}

		public static long square(int x)
		{
			return x * x;
		}

		static void Main(string[] args)
		{
			int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 4, 0 };

			//Var1
			int result = 0;
			for (int i = 0; i < numbers.Length; i++)
				if (IsOdd(numbers[i]))
				{
					result++;
				}
			Console.WriteLine(result);

			//Var2
			int oddNumbers = numbers.Count(n => n % 2 == 1);
			Console.WriteLine(oddNumbers);

			//Lambda with arrays
			var position = Array.FindIndex(numbers, x => x == 4);
			Console.WriteLine("First Index = {0}", position);

			position = Array.FindLastIndex(numbers, x => x == 4);
			Console.WriteLine("Last Index = {0}", position);

			//Lambda with LINQ
			var newResult = numbers.Select(x => x * x);
			Console.WriteLine(String.Join(", ", newResult));

			var filtered = numbers.Where(x => x > 5);
			Console.WriteLine(String.Join(", ", filtered));

			Console.ReadKey();
		}
	}
}