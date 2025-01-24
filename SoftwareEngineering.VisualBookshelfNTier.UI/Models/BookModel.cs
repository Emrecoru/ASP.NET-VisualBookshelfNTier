
namespace SoftwareEngineering.VisualBookshelfNTier.UI.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorModel[] Authors { get; set; }

        public string[] Subjects { get; set; }

        public TranslatorModel[]? Translators { get; set; }

        public string[] BookShelves { get; set; }

        public string[] Languages { get; set; }

        public bool Copyright { get; set; }

        public string Media_Type { get; set; }

        public int Download_Count { get; set; }

        public Dictionary<string, string> Formats { get; set; }
    }

    public class BookListResult
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public BookModel[] Results { get; set; }
    }
}
