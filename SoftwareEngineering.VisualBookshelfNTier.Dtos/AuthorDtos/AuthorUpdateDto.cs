using SoftwareEngineering.VisualBookshelfNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Dtos
{
    public class AuthorUpdateDto : IUpdateDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? BirthYear { get; set; }

        public int? DeathYear { get; set; }
    }
}
