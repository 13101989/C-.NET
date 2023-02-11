namespace ListExample
{
	public class Employee : IComparable<Employee>
	{ 
		public string Name { get; set; }
		public int Salary { get; set; }

		public int CompareTo(Employee emp)
		{
			return Name.CompareTo(emp.Name);

			if (this.Salary < emp.Salary)
			{
				return -1;
			}
			else
				if (this.Salary > emp.Salary)
				{
					return 1;
				}
				else
				{
					return 0;
				}
		}

		public override string ToString()
		{
			return $"{this.Name} {this.Salary}";
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			var employees = new List<Employee>();
			employees.Add(new Employee() { Name = "John", Salary = 7800});
			employees.Add(new Employee() { Name = "Dan", Salary = 8000 });
			employees.Add(new Employee() { Name = "Chris", Salary = 5600 });
			employees.Add(new Employee() { Name = "Anna", Salary = 4200 });
			employees.Add(new Employee() { Name = "Igor", Salary = 10000 });

			employees.Sort();

			employees.ForEach(employee => Console.WriteLine(employee));

			Console.ReadKey();
		}
	}
}