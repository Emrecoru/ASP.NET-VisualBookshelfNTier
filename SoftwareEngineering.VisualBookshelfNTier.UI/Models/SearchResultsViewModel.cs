namespace SoftwareEngineering.VisualBookshelfNTier.UI.Models
{
    public class SearchResultsViewModel
    {
        public string SearchTerm { get; set; }
        public BookModel[] BookListResult { get; set; }
    }
}