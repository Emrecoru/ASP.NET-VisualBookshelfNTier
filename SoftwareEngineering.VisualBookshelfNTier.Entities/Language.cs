using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Entities
{
    public class Language : BaseEntity
    {
        public string LanguageDefinition { get; set; }

        virtual public List<BookLanguage> BookLanguages{ get; set; }
    }
}
