namespace NewExtensionMethods
{
	public static class FloatExtension
	{
		public static float CalculateValueAfterTax(this float currentValue, float taxPercentax)
		{
			if (taxPercentax < 0 || taxPercentax >100)
				return currentValue;
			else
				return currentValue * (1 + taxPercentax / 100);
		}
	}

	public static class IntExtension
	{
		public static bool IsGreatherThan(this int nr, int valueToCompare)
		{
			if(nr>valueToCompare)
				return true;

			return false;
			
			//return nr > valueToCompare;
		}
	}

	public class MyClass
	{
		public string Display()
		{
			return "Display method";
		}

		public string Print()
		{
			return "Print method";
		}
	}

	public static class MyClassExtension
	{
		public static void NewMethod(this MyClass extesion)
		{
			Console.WriteLine("Just a test");
		}


	}


	internal class Program
	{
		static void Main(string[] args)
		{
			float value = 100F;
			float percent = 24F;
			Console.WriteLine(value.CalculateValueAfterTax(percent));

			int nr = 100;
			if (nr.IsGreatherThan(150))
				Console.WriteLine("Yes");
			else
				Console.WriteLine("No");

			MyClass ob = new MyClass();
			ob.NewMethod();

			Console.ReadKey();
		}
	}
}