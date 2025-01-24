using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Entities
{
    public class Book : BaseEntity
    {
        public int BookApiId { get; set; }

        public string Title { get; set; }

        public bool isCopyright { get; set; }

        public string MediaType { get; set; }

        public int DownloadCount { get; set; }

        public string txtUrl { get; set; }

        public string imgUrl { get; set; }

        virtual public List<BookAuthor> BookAuthors { get; set; }

        virtual public List<BookSubject> BookSubjects { get; set; }

        virtual public List<BookTranslator> BookTranslators { get; set; }

        virtual public List<BookLanguage> BookLanguages { get; set; }

        virtual public List<Bookshelf> Bookshelves { get; set; }
    }
}
