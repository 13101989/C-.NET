using System.Globalization;

namespace CustomExceptios
{
	public class OddNumberException : Exception
	{
		public override string Message
		{
			get
			{
				return "divisor cannot be odd number";
			}
		}
	}

	public class CustomException : Exception
	{
		public CustomException(string message) : base(message)
		{
			this.HelpLink = "www.CustomException.com";
			this.Source = "This is the source!!!";
		}
	}

	public class MyClass
	{
		public static void Show()
		{
			throw new CustomException("This is a Custom Exception in C#");
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			int x, y, z;
			Console.WriteLine("Enter two integer numbers");
			x = int.Parse(Console.ReadLine());
			y = int.Parse(Console.ReadLine());
			try
			{
				if (y % 2 > 0)
				{
					throw new OddNumberException();
				}
				z = x / y;
				Console.WriteLine(z);
			}
			catch (OddNumberException odd)
			{
				Console.WriteLine(odd.Message);
			}

			try
			{
				MyClass.Show();
			}
			catch (CustomException ex)
			{
				Console.WriteLine("Error message:" + ex.Message);
				Console.WriteLine("Help Link:" + ex.HelpLink);
				Console.WriteLine("Source:" + ex.Source);
			}

			Console.ReadKey();
		}
	}
}