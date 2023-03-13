using System.ComponentModel;
using System.Net.Http.Headers;
using System.Reflection;

namespace StaticPolymorphism
{
	public class User 
	{
		public void UserLogin(string userName, string password)
		{
			if (userName == "Popescu" && password == "pass1234")
			{
				Console.WriteLine("{0} is valid and loged sucessefully", userName);
			}
			else
			{
				Console.WriteLine("Invalid username or password");
			}
		}

		public void UserLogin(string userName, string password, string role)
		{
			if (role == "Admin" && (userName == "admin" && password == "admin@1234"))
			{
				Console.WriteLine("{0} is valid and loged sucessefully", userName);
			}
			else
			{
				Console.WriteLine("Invalid role or invalid username or password");
			}
		}
	}


	internal class Program
	{
		public int Add(int x, int y)
		{
			return x + y;	
		}

		public double Add(double x, int y)
		{
			return x + y;
		}

		public int Add(int x, int y, int z)
		{
			return x + y + z;
		}

		static void Main(string[] args)
		{
			Program prg = new Program();
			Console.WriteLine("Suma este:{0}",prg.Add(5,7));
			Console.WriteLine("Suma este:{0}", prg.Add(5.0, 7));

			User user = new User();
			user.UserLogin("Popescu", "pass1234");
			user.UserLogin("admin", "admin@1234", "Admin");

			Console.ReadKey();
		}
	}
}