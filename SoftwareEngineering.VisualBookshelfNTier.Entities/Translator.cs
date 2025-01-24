using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Entities
{
    public class Translator : BaseEntity
    {
        public string Name { get; set; }

        public int? BirthYear { get; set; }

        public int? DeathYear { get; set; }

        virtual public List<BookTranslator> BookTranslators { get; set; }
    }
}
