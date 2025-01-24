using AutoMapper;
using FluentValidation;
using SoftwareEngineering.VisaulBookshelfNTier.Business.Extensions;
using SoftwareEngineering.VisaulBookshelfNTier.Business.Interfaces;
using SoftwareEngineering.VisualBookshelfNTier.Common;
using SoftwareEngineering.VisualBookshelfNTier.DataAccess.UnitOfWork;
using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using SoftwareEngineering.VisualBookshelfNTier.Entities;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.Services
{
    public class BookshelfService : Service<BookshelfCreateDto, BookshelfUpdateDto, BookshelfListDto, Bookshelf>, IBookshelfService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        private readonly IValidator<BookshelfCreateDto> _createDtoValidator;

        public BookshelfService(IMapper mapper, IValidator<BookshelfCreateDto> createDtoValidator, IValidator<BookshelfUpdateDto> updateDtoValidator,
            IUow uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
            _uow = uow;
            _mapper = mapper;
            _createDtoValidator = createDtoValidator;
        }

        public async Task<IResponse<BookshelfCreateDto>> CreateAsyncWithBookSpecs(BookshelfCreateDto dto)
        {
            var result = _createDtoValidator.Validate(dto);

            if (result.IsValid)
            {

                var createdEntity = _mapper.Map<Bookshelf>(dto);

                var authorDto = new AuthorCreateDto
                {
                    Name = dto.Book.BookAuthors[0].Author.Name,
                    BirthYear = dto.Book.BookAuthors[0].Author.BirthYear,
                    DeathYear = dto.Book.BookAuthors[0].Author.DeathYear,
                };

                var bookAuthorDto = new BookAuthorCreateDto
                {
                    Book = dto.Book,
                    Author = authorDto
                };

                var bookAuthorsList = new List<BookAuthorCreateDto> { bookAuthorDto };


                var bookSubjectsList = new List<BookSubjectCreateDto>();

                foreach (var item in dto.Book.BookSubjects)
                {
                    var subjectDto = new SubjectCreateDto { Definition = item.Subject.Definition };
                    var bookSubjectDto = new BookSubjectCreateDto
                    {
                        Book = dto.Book,
                        Subject = subjectDto
                    };
                    bookSubjectsList.Add(bookSubjectDto);
                }

                var translatorDto = new TranslatorCreateDto();
                var bookTranslatorList = new List<BookTranslatorCreateDto>();

                if (dto.Book.BookTranslators != null && dto.Book.BookTranslators.Count > 0)
                {
                    translatorDto.Name = dto.Book.BookTranslators[0]?.Translator?.Name;
                    translatorDto.BirthYear = dto.Book.BookTranslators[0]?.Translator?.BirthYear;
                    translatorDto.DeathYear = dto.Book.BookTranslators[0]?.Translator?.DeathYear;
                    var bookTranslatorDto = new BookTranslatorCreateDto
                    {
                        Book = dto.Book,
                        Translator = translatorDto
                    };
                    bookTranslatorList.Add(bookTranslatorDto);
                }

                var bookLanguageList = new List<BookLanguageCreateDto>();

                foreach (var item in dto.Book.BookLanguages)
                {
                    var languageDto = new LanguageCreateDto { LanguageDefinition = item.Language.LanguageDefinition };
                    var bookLanguageDto = new BookLanguageCreateDto
                    {
                        Book = dto.Book,
                        Language = languageDto
                    };
                    bookLanguageList.Add(bookLanguageDto);
                }

                var bookEntity = new BookCreateDto
                {

                    BookAuthors = bookAuthorsList,
                    BookApiId = createdEntity.Book.BookApiId,
                    MediaType = dto.Book.MediaType,
                    DownloadCount = dto.Book.DownloadCount,
                    isCopyright = dto.Book.isCopyright,
                    Title = dto.Book.Title,
                    BookSubjects = bookSubjectsList,
                    BookTranslators = bookTranslatorList,
                    BookLanguages = bookLanguageList,
                    imgUrl = dto.Book.imgUrl,
                    txtUrl = dto.Book.txtUrl,  
                };

                var bookshelfDto = new BookshelfCreateDto
                {
                    AppUserId = dto.AppUserId,
                    Book = bookEntity,
                };

                var bookshelfEntity = _mapper.Map<Bookshelf>(bookshelfDto);
                await _uow.GetRepository<Bookshelf>().CreateAsync(bookshelfEntity);
                await _uow.SaveChangesAsync();
                return new Response<BookshelfCreateDto>(ResponseType.Success, dto);
            }
            return new Response<BookshelfCreateDto>(dto, errors: result.ConvertToCustomValidationError());
        }
    }
}
