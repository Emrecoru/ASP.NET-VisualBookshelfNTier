using SoftwareEngineering.VisualBookshelfNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Dtos
{
    public class BookTranslatorListDto : IDto
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public BookListDto Book { get; set; }

        public int TranslatorId { get; set; }

        public TranslatorListDto Translator { get; set; }
    }
}
