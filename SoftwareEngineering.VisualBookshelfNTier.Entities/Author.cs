﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Entities
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }

        public int? BirthYear { get; set; }

        public int? DeathYear { get; set; }

        virtual public List<BookAuthor> BookAuthors{ get; set; }
    }
}
