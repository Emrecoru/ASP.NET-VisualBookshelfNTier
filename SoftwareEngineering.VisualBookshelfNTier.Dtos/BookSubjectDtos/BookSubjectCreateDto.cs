using SoftwareEngineering.VisualBookshelfNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Dtos
{
    public class BookSubjectCreateDto : IDto
    {
        public int BookId { get; set; }

        public BookCreateDto Book { get; set; }

        public int SubjectId { get; set; }

        public SubjectCreateDto Subject { get; set; }
    }
}
