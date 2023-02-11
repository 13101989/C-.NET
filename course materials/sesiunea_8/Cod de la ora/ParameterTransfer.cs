namespace ParameterTransfer
{
	internal class Program
	{
		static void func(out int[] arr)
		{
			arr = new int[] {3, 5, 15, 2, 60};
		}

		static int[] EmptyFunc()
		{
			return new int[] { 3, 5, 15, 2, 60 };
		}

		static void PrintArray(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write("{0} ", arr[i]);
			}
			Console.WriteLine();
		}

		static void UpdateArray(int[] arr)
		{
			arr[1] = 100;
			arr[3] = 200;
		}

		static void Main(string[] args)
		{
			int[] v;
			func(out v);
			PrintArray(v);

			int[] x = EmptyFunc();
			PrintArray(x);

			UpdateArray(x);
			PrintArray(x);

			Console.ReadKey();
		}
	}
}