﻿using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Score
    {
        public string Testid { get; set; }
        public string Studentid { get; set; }
        public byte Score1 { get; set; }

        public virtual Test Test { get; set; }
    }
}
