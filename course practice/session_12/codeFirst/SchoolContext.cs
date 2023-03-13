using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace codeFirst
{
    public class SchoolContext : DbContext
    {

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=School;User Id=sa;Password=Eralper@6");
        }

        public void AddStudent(string name)
        {
            var student = new Student() { Name = name, CreatedTimestamp = DateTime.Now };
            Students.Add(student);
            SaveChanges();
        }

        public void AddCourse(string course)
        {
            var curs = new Course() { CourseName = course };

            Courses.Add(curs);
            SaveChanges();
        }

        public void DisplayStudents()
        {
            foreach(var student in Students)
            {
                Console.WriteLine("{0} - {1}", student.Id, student.Name);
            }

            Console.WriteLine();
        }

        public void DisplayCourses()
        {
            foreach (var curs in Courses)
            {
                Console.WriteLine("{0} - {1}", curs.Id, curs.CourseName);
            }

            Console.WriteLine();
        }

        public void UpdateStudent(int id, string name)
        {
            var student = Students.Where(s => s.Id.Equals(id)).FirstOrDefault();
            student.Name = name;
            Students.Update(student);
            SaveChanges();
        }

        public void UpdateCourse(string oldCourse, string newCourse)
        {
            var course = Courses.Where(s => s.CourseName.Equals(oldCourse)).FirstOrDefault();
            course.CourseName = newCourse;
            Courses.Update(course);
            SaveChanges();
        }

        public void DeleteStudent(string name)
        {
            var student = Students.Where(s => s.Name.Equals(name)).FirstOrDefault();
            Students.Remove(student);
            SaveChanges();
        }

        public void DeleteCourse(string course)
        {
            var curs = Courses.Where(s => s.CourseName.Equals(course)).FirstOrDefault();
            Courses.Remove(curs);
            SaveChanges();
        }
    }
}

