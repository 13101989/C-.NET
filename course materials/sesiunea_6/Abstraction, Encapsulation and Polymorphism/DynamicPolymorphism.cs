namespace DynamicPolymorphism
{
	public class Employee
	{
		public virtual void PrintName(string fname, string lname) 
		{
			Console.WriteLine("Full name: {0} and last name: {1}", fname, lname);
		}
	}

	public class Junior : Employee 
	{
		public override void PrintName(string fname, string lname)
		{
			Console.WriteLine("Full name is {0} and last name is {1}", fname, lname);
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Employee emp;
			emp = new Junior();
			emp.PrintName("Popescu", "Ilie");

			emp = new Employee();
			emp.PrintName("Ptutucea", "Vasile");

			Console.ReadKey();
		}
	}
}