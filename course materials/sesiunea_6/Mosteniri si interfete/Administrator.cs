using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Administrator : User, IModerator
    {
        public Administrator(string name, int birthYear)
            : base(name, birthYear)
        { }

        public User SetUserName(User user, string newName)
        {
            base._name = newName;
            return user;
        }

        public Post UpdatePost(Post postInstance, string newText)
        {
            return new Post(postInstance.author, newText);
        }
    }
}
