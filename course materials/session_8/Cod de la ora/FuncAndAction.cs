using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace FuncAndAction
{
	public class Person
	{
		public string Name { get; set; }
		public string Ocupation { get; set; }

		public Person(string name, string ocupation)
		{
			Name = name;
			Ocupation = ocupation;
		}
	}

	internal class Program
	{
		public static int Sum(int x, int y)
		{
			return x + y;
		}

		public static void ShowOcupation(List<Person> list, Func<Person, bool> condition)
		{
			var results = list.Where(condition);
			foreach (var person in results)
			{
				Console.WriteLine("{0} - {1}", person.Name, person.Ocupation);
			}
		}

		static void Main(string[] args)
		{
			//int result = (x,y) => x+y;
			Func<int, int, int> add = Sum;
			Console.WriteLine(add(10,20));

			Func<int, int, int> newAdd = (x, y) => x + y;
			Console.WriteLine(newAdd(10, 20));

			string[] words = { "blue", "red", "yelow", "green", "black", "white" };

			Func<string, bool> HasFive = str => str.Length == 5;
			var fiveLetterWords = words.Where(HasFive);

			foreach (var word in fiveLetterWords)
			{
				Console.WriteLine(word);
			}

			var data = new List<Person>
			{
				new Person("John", "programmer"),
				new Person("Mary", "teacher"),
				new Person("Alin", "gardener"),
				new Person("Peter", "teacher"),
			};

			ShowOcupation(data, x => x.Ocupation == "programmer");

			Console.ReadKey();
		}
	}
}