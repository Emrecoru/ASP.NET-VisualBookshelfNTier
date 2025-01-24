using AutoMapper;
using FluentValidation;
using SoftwareEngineering.VisaulBookshelfNTier.Business.Interfaces;
using SoftwareEngineering.VisualBookshelfNTier.Common;
using SoftwareEngineering.VisualBookshelfNTier.DataAccess.UnitOfWork;
using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using SoftwareEngineering.VisualBookshelfNTier.Entities;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.Services
{
    public class BookService : Service<BookCreateDto, BookUpdateDto, BookListDto, Book>, IBookService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;

        public BookService(IMapper mapper, IValidator<BookCreateDto> createDtoValidator, IValidator<BookUpdateDto> updateDtoValidator, IUow uow) :
            base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<IResponse<List<BookListDto>>> GetBooksAsync(int userId)
        {
            var bookshelves = await _uow.GetRepository<Bookshelf>().GetAllAsync(x => x.AppUserId == userId);
            var bookshelvesList = _mapper.Map<List<BookshelfListDto>>(bookshelves);

            var bookList = new List<BookListDto>();
            
            foreach (var item in bookshelves)
            {
                var bookDto = _mapper.Map<BookListDto>(item.Book);
                bookList.Add(bookDto);
            }

            return new Response<List<BookListDto>>(ResponseType.Success, bookList);
        }
    }
}
