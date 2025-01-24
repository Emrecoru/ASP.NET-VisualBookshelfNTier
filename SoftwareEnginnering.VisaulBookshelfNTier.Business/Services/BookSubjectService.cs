using AutoMapper;
using FluentValidation;
using SoftwareEngineering.VisaulBookshelfNTier.Business.Interfaces;
using SoftwareEngineering.VisualBookshelfNTier.DataAccess.UnitOfWork;
using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using SoftwareEngineering.VisualBookshelfNTier.Entities;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.Services
{
    public class BookSubjectService : Service<BookSubjectCreateDto, BookSubjectUpdateDto, BookSubjectListDto, BookSubject>, IBookSubjectService
    {
        public BookSubjectService(IMapper mapper, IValidator<BookSubjectCreateDto> createDtoValidator, IValidator<BookSubjectUpdateDto> updateDtoValidator, IUow uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
        }
    }
}
