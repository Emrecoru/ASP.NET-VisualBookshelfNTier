using SoftwareEngineering.VisualBookshelfNTier.Dtos.AuthorDtos;
using SoftwareEngineering.VisualBookshelfNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Dtos
{
    public class BookAuthorListDto : IDto
    {
        public int BookId { get; set; }

        public BookListDto Book { get; set; }

        public int AuthorId { get; set; }

        public AuthorListDto Author { get; set; }
    }
}
