using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Entities
{
    public class BookAuthor : BaseEntity
    {
        public int BookId { get; set; }

        virtual public Book Book { get; set; }

        public int AuthorId { get; set; }

        virtual public Author Author { get; set; }
    }
}
