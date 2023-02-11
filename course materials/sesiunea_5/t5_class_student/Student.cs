using System;
namespace t5_class_student
{
    internal class Student
    {
        public string name;
        public int age;
        private const int MIN_AGE = 18;
        private const int MAX_AGE = 99;
        public string? mark;


        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int Age
        {
            set
            {
                if (value >= MIN_AGE && value <= MAX_AGE)
                {
                    this.age = value;
                }
            }
            get { return this.age; }
        }

        public string Info
        {
            get { return this.name + " has " + this.age + " years"; }
        }

        public string? Mark
        {
            set { this.mark = value;}
            get { return this.mark; }
        }

    }
} 

