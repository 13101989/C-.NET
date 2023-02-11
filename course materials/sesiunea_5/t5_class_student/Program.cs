using System.Text.RegularExpressions;

namespace t5_class_student
{
    class Program
    {
        static void Main()
        {
            int numberOfStudents = GetNumberOfStudents();
            Student[] arrayOfStudents = new Student[numberOfStudents];
            int i = 0;
            float TotalMarkCount = 0;
            float countMarks = 0;

            while (i < arrayOfStudents.Length)
            {
                string name = GetName();
                if (string.IsNullOrEmpty(name))
                {
                    break;
                }
                int age = GetAge();
                if (age == 0)
                {
                    break;
                }

                Student student = new Student(name, age);
                arrayOfStudents[i] = student;
                student.Mark = GetMark();
                i++;
            }

            if (i == numberOfStudents && numberOfStudents > 0)
            {
                for (i = 0; i < arrayOfStudents.Length; i++)
                {
                    Console.WriteLine($"{arrayOfStudents[i].Info}.");
                    if (!string.IsNullOrEmpty(arrayOfStudents[i].mark))
                    {
                        int.TryParse(arrayOfStudents[i].mark, out int markInt);
                        TotalMarkCount += markInt;
                        countMarks++;
                    }
                }
                float AverageOfMarks = TotalMarkCount / countMarks;
                if (AverageOfMarks > 0)
                {
                    Console.WriteLine($"Average of existing marks is {AverageOfMarks}.");
                }
                else
                {
                    Console.WriteLine($"There are no marks present.");
                }
            }
        }

        static int GetNumberOfStudents()
        {
            Console.WriteLine("Please insert the number of students you want to add:");
            var number = Console.ReadLine();

            if (int.TryParse(number, out int numberInt) == false || numberInt < 1)
            {
                Console.WriteLine("Invalid number inserted (must be a number bigger than 0).Exited.");
                return 0;
            }
            return numberInt;
        }

        static string GetName()
        {
            Console.WriteLine("Please insert name of the student:");
            string? name = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || Regex.IsMatch(name, "[^A-Za-z]"))
            {
                Console.WriteLine("Invalid name inserted.Exited.");
                return string.Empty;
            }
            return name;
        }

        static int GetAge()
        {
            Console.WriteLine("Please insert age of the student, please be aware that it must be betwwen 18 and 99:");
            var age = Console.ReadLine();

            if (int.TryParse(age, out int ageInt) == false || ageInt < 18 || ageInt > 99)
            {
                Console.WriteLine("Invalid age inserted (age must be a number between 18 and 99).Exited.");
                return 0;
            }
            return ageInt;
        }

        static string GetMark()
        {
            Console.WriteLine("Please insert a mark for the student (must be a number between 1 and 10) or press 'Enter' if you want to skip this step:");
            var mark = Console.ReadLine();

            if (int.TryParse(mark, out int markInt) == false || markInt > 10 || markInt < 1)
            {
                Console.WriteLine("Skipped (must be a number between 1 and 10)");
                return string.Empty;
            }
            return mark;
        }
    }
}
