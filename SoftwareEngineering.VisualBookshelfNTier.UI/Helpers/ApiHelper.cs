using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using SoftwareEngineering.VisualBookshelfNTier.UI.Models;
using SoftwareEngineering.VisaulBookshelfNTier.Business.Interfaces;
using System.Net;

namespace SoftwareEngineering.VisualBookshelfNTier.UI.Helpers
{
    public static class ApiHelper
    {
        public static async Task CreateBookAsync(IBookshelfService _bookshelfService, int bookId, int userId)
        {
            string apiUrl = "https://gutendex.com/books";

            using (HttpClient client = new HttpClient())
            {
                // API endpoint belirt
                client.BaseAddress = new Uri(apiUrl);

                // GET isteği yap
                HttpResponseMessage response = await client.GetAsync(apiUrl + $"/{bookId}");

                // Başarılı bir yanıt alındıysa
                if (response.IsSuccessStatusCode)
                {
                    // Yanıt içeriğini oku
                    string content = await response.Content.ReadAsStringAsync();


                    BookModel bookModel = Newtonsoft.Json.JsonConvert.DeserializeObject<BookModel>(content);


                    var BookAuthorsList = new List<BookAuthorCreateDto>();
                    foreach (var item in bookModel.Authors)
                    {
                        var authorCreateDto = new AuthorCreateDto { BirthYear = item.Birth_Year, DeathYear = item.Death_Year, Name = item.Name };
                        BookAuthorsList.Add(new BookAuthorCreateDto { Author = authorCreateDto, BookId = bookModel.Id });
                    }

                    var BookTranslatorsList = new List<BookTranslatorCreateDto>();
                    foreach (var item in bookModel.Translators)
                    {
                        var translatorCreateDto = new TranslatorCreateDto { BirthYear = item.Birth_Year, DeathYear = item.Death_Year, Name = item.Name };
                        BookTranslatorsList.Add(new BookTranslatorCreateDto { Translator = translatorCreateDto, BookId = bookModel.Id });
                    }

                    var BookSubjectsList = new List<BookSubjectCreateDto>();
                    foreach (var item in bookModel.Subjects)
                    {
                        var subjectCreateDto = new SubjectCreateDto { Definition = item };
                        BookSubjectsList.Add(new BookSubjectCreateDto { Subject = subjectCreateDto, BookId = bookModel.Id });
                    }

                    var BookLanguageList = new List<BookLanguageCreateDto>();
                    foreach (var item in bookModel.Languages)
                    {
                        var languageCreateDto = new LanguageCreateDto { LanguageDefinition = item };
                        BookLanguageList.Add(new BookLanguageCreateDto { Language = languageCreateDto, BookId = bookModel.Id });
                    }
                    string imgUrl;
                    if (bookModel.Formats.TryGetValue("image/jpeg", out imgUrl))
                    {

                    }
                    else
                    {
                        imgUrl = "https://t3.ftcdn.net/jpg/04/62/93/66/360_F_462936689_BpEEcxfgMuYPfTaIAOC1tCDurmsno7Sp.jpg";
                    }

                    string txtUrl;
                    if(bookModel.Formats.TryGetValue("text/html", out txtUrl))
                    {

                    }


                    BookCreateDto bookCreateDto = new BookCreateDto
                    {
                        Title = bookModel.Title,
                        BookAuthors = BookAuthorsList,
                        BookApiId = bookModel.Id,
                        MediaType = bookModel.Media_Type,
                        DownloadCount = bookModel.Download_Count,
                        isCopyright = bookModel.Copyright,
                        BookTranslators = BookTranslatorsList,
                        BookSubjects = BookSubjectsList,
                        BookLanguages = BookLanguageList,
                        imgUrl = imgUrl,
                        txtUrl = txtUrl
                    };

                    BookshelfCreateDto dto = new BookshelfCreateDto { Book = bookCreateDto, AppUserId = userId };
                    await _bookshelfService.CreateAsyncWithBookSpecs(dto);


                    // Her bir kitap bilgisini ekrana yazdır
                    // TODO: JSON içeriğini işleyerek kitapları kullanabilirsin
                    Console.WriteLine(content);
                }
                else
                {
                    // Hata durumunda uygun bir işlem yap
                    Console.WriteLine($"Hata kodu: {response.StatusCode}, Hata mesajı: {response.ReasonPhrase}");

                }
            }
        }

        public static async Task<BookListResult> SearchBooksAsync(string searchTerm)
        {
            string apiUrl = "https://gutendex.com/books";

            using (HttpClient client = new HttpClient())
            {
                // API endpoint belirt
                client.BaseAddress = new Uri(apiUrl);

                // GET isteği yap
                HttpResponseMessage response = await client.GetAsync($"?search={searchTerm}");

                // Başarılı bir yanıt alındıysa
                if (response.IsSuccessStatusCode)
                {
                    // Yanıt içeriğini oku
                    string content = await response.Content.ReadAsStringAsync();

                    BookListResult bookListResult = Newtonsoft.Json.JsonConvert.DeserializeObject<BookListResult>(content);

                    return bookListResult;
                }
                return new BookListResult();
            }
        }

        public static async Task<string> ReadBookAsync(string txtUrl)
        {
            try
            {

                //var url = new Uri(txtUrl); // Textboxa yazılan username'i alarak url oluşturdum
                var client = new WebClient();
                var html = client.DownloadString("https://www.gutenberg.org/cache/epub/174/pg174.txt");

                if (html != null)
                {
                    return html.ToString();
                }
                else
                {
                    return "Not Found";
                }
            }
            catch
            {

            }
            return "Not Found";
        }


    }
}
