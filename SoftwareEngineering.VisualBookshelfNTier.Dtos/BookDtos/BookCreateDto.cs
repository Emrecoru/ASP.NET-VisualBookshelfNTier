using SoftwareEngineering.VisualBookshelfNTier.Dtos.Interfaces;

namespace SoftwareEngineering.VisualBookshelfNTier.Dtos
{
    public class BookCreateDto : IDto
    {
        public int BookApiId { get; set; }

        public string Title { get; set; }

        public bool isCopyright { get; set; }

        public string MediaType { get; set; }

        public int DownloadCount { get; set; }

        public string txtUrl { get; set; }

        public string imgUrl { get; set; }

        public List<BookAuthorCreateDto> BookAuthors { get; set; }

        public List<BookSubjectCreateDto> BookSubjects { get; set; }

        public List<BookTranslatorCreateDto> BookTranslators { get; set; }

        public List<BookLanguageCreateDto> BookLanguages { get; set; }
    }
}
