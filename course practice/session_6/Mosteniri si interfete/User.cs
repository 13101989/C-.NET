using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class User
    {
        protected string _name;
        public string Name
        {
            get { return _name; }
        }

        private int birthYear;

        public User(string name, int birthYear)
        {
            this._name = name;
            this.birthYear = birthYear;
        }

        public int Age
        {
            get
            {
                return DateTime.UtcNow.Year - birthYear;
            }
        }

        public Post CreatePost(string text)
        {
            return new Post(this, text);
        }
    }
}
