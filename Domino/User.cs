﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
