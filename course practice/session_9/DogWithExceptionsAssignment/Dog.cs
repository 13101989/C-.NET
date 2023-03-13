using System;
namespace DogWithExceptionsAssignment
{
    public class Dog
    {
        private string name;
        private int age;

        public int Age
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age value is lower than 0");
                }
                else if (value > 100)
                {
                    throw new ApplicationException("Age value is greater than 100.");
                }
                else
                {
                    this.age = value;
                }
            }

            get { return age; }
        }

        public string Name
        {
            set
            {
                if (value.Length < 2)
                {
                    throw new ApplicationException("Name length is lower than 2");
                }
                else
                {
                    this.name = value;
                }
            }

            get { return name; }
        }
    }
}

