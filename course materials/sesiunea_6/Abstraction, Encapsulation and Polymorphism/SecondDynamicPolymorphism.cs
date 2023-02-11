namespace SecondDynamicPolymorphism
{
	public class User
	{
		public virtual void UserLogin(string username, string password, string role)
		{
			if (role == "user" && (username == "Ptutucea" && password == "ptutu123"))
			{
				Console.WriteLine("{0} is valid", username);
			}
			else
			{
				Console.WriteLine("Invalid user");
			}
		}
	}

	public class Admin : User 
	{
		public override void UserLogin(string username, string password, string role)
		{
			base.UserLogin(username, password, role);
			Console.WriteLine(" and is admin");
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			User user;
			user = new User();
			user.UserLogin("Ptutucea", "ptutu123", "user");
			Console.WriteLine();

			user = new Admin();
			user.UserLogin("Ptutucea", "ptutu123", "user");

			Console.ReadKey();
		}
	}
}