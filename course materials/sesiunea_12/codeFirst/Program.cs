using System;

namespace codeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            SchoolContext context = new SchoolContext();

            //context.AddStudent("Ionescu");
            //context.AddStudent("Dragos");
            //context.AddCourse("mate");
            //context.AddCourse("romana");

            context.DisplayStudents();
            context.DisplayCourses();
            context.AddStudent("Ionela");

            //context.UpdateStudent(1, "virgil update");
            //context.DisplayStudents();

            //context.UpdateCourse("matematica", "fizica");
            //context.DisplayCourses();

            //context.DeleteStudent("virgil update");
            //context.DisplayStudents();

            //context.DeleteCourse("romana");
            //context.DisplayCourses();
        }
    }
}

