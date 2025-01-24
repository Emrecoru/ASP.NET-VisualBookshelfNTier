using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Entities
{
    public class Subject : BaseEntity
    {
        public string Definition { get; set; }

        virtual public List<BookSubject> BookSubjects { get; set; }
    }
}
