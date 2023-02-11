using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Test
    {
        public Test()
        {
            Scores = new HashSet<Score>();
        }

        public string Testid { get; set; }

        public virtual ICollection<Score> Scores { get; set; }
    }
}
