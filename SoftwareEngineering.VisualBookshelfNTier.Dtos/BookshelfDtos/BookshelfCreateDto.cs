using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using SoftwareEngineering.VisualBookshelfNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Dtos
{
    public class BookshelfCreateDto : IDto
    {
        public int AppUserId { get; set; }

        public AppUserCreateDto AppUserCreateDto { get; set; }

        public int BookId { get; set; }

        public BookCreateDto Book { get; set; }
    }
}
