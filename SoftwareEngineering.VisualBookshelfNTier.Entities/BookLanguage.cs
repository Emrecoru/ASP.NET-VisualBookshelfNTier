﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Entities
{
    public class BookLanguage : BaseEntity
    {
        public int BookId { get; set; }

        virtual public Book Book { get; set; }

        public int LanguageId { get; set; }

        virtual public Language Language { get; set; }
    }
}
