using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using SoftwareEngineering.VisualBookshelfNTier.Dtos.Interfaces;

namespace SoftwareEngineering.VisualBookshelfNTier.Dtos
{
    public class BookListDto : IDto
    {
        public int Id { get; set; }

        public int BookApiId { get; set; }

        public string Title { get; set; }

        public bool isCopyright { get; set; }

        public string MediaType { get; set; }

        public int DownloadCount { get; set; }

        public string txtUrl { get; set; }

        public string imgUrl { get; set; }

        public List<BookAuthorListDto> BookAuthors { get; set; }

        public List<BookSubjectListDto> BookSubjects { get; set; }

        public List<BookTranslatorListDto> BookTranslators { get; set; }

        public List<BookLanguageListDto> BookLanguages { get; set; }
    }
}
