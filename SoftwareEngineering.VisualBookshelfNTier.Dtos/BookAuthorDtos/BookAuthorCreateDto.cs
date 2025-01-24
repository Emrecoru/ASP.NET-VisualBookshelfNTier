using SoftwareEngineering.VisualBookshelfNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Dtos
{
    public class BookAuthorCreateDto : IDto
    {
        public int BookId { get; set; }

        public BookCreateDto Book { get; set; }

        public int AuthorId { get; set; }

        public AuthorCreateDto Author { get; set; }

    }
}
