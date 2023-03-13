using System;
namespace codeFirst
{
    public class Student
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedTimestamp  { get; set; }

        public Course Course { get; set; }

    }
}

