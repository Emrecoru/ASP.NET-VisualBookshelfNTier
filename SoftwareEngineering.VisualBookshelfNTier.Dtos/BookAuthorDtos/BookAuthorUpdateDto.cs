using SoftwareEngineering.VisualBookshelfNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Dtos
{
    public class BookAuthorUpdateDto : IUpdateDto
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public int AuthorId { get; set; }
    }
}
