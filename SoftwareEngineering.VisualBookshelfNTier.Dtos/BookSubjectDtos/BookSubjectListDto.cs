using SoftwareEngineering.VisualBookshelfNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Dtos
{
    public class BookSubjectListDto : IDto
    {
        public int BookId { get; set; }

        public BookListDto Book { get; set; }

        public int SubjectId { get; set; }

        public SubjectListDto Subject { get; set; }
    }
}
