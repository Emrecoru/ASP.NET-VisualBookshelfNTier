using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Entities
{
    public class BookTranslator : BaseEntity
    {
        public int BookId { get; set; }

        virtual public Book Book { get; set; }

        public int TranslatorId { get; set; }

        virtual public Translator Translator { get; set; }
    }
}
