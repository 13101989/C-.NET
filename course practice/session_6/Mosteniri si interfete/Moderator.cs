using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Moderator : User, IModerator
    {
        public Moderator(string name, int birthYear) 
            : base(name, birthYear)
        { }

        public Post UpdatePost (Post post, string newText)
        {
            post.text = newText;
            return post;
        }
    }
}
