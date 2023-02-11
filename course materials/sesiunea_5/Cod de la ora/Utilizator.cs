using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Utilizator
    {
        private string name;
        private string department;
        public int age;
        private Utilizator buddy;

        public Utilizator(string name, int age) : this(name, "", age)
        { }

        public Utilizator(string name, string department, int age)
        {
            this.name = name;
            this.department = department;
            this.age = age;
        }

        public Utilizator Buddy
        {
            set { this.buddy = value;  }
            get { return this.buddy; }
        }

        public string Department
        {
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.department = value;
                }
            }
            get { return this.department; }
        }
        //public void SetDepartment(string newDepartment)
        //{
        //    this.department = newDepartment;
        //}

        //public string GetDepartment()
        //{
        //    return this.department;
        //}

        public string GetName()
        {
            return this.name;
        }


        public string SayHello()
        {
            return $"Hello. My name is {this.name}";
        }
    }
}
