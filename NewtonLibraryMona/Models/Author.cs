﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonLibraryMona.Models
{
    internal class Author
    {

        public int AuthorID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();

    }
}
