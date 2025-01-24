using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Entities
{
    public class BookSubject : BaseEntity
    {
        public int BookId { get; set; }

        virtual public Book Book { get; set; }

        public int SubjectId { get; set; }

        virtual public Subject Subject { get; set; }
    }
}
