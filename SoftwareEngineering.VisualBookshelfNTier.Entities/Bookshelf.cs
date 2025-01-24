using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Entities
{
    public class Bookshelf : BaseEntity
    {
        public int AppUserId { get; set; }

        virtual public AppUser AppUser { get; set; }

        public int BookId { get; set; }

        virtual public Book Book { get; set; }
    }
}
