using SoftwareEngineering.VisualBookshelfNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Dtos
{
    public class PersonCreateDto : IDto
    {
        public string Name { get; set; }

        public DateTime? BirthYear { get; set; }

        public DateTime? DeathYear { get; set; }
    }
}
