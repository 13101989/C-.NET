using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Post
    {
        public string text;
        public readonly User author;

        public Post(User user, string text)
        {
            this.author = user;
            this.text = text;
        }

    }
}
