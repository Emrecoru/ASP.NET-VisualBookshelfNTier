using AutoMapper;
using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using SoftwareEngineering.VisualBookshelfNTier.Entities;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.Mappings.AutoMapper
{
    public class BookSubjectProfile : Profile
    {
        public BookSubjectProfile()
        {
            CreateMap<BookSubjectCreateDto, BookSubject>().ReverseMap();
            CreateMap<BookSubjectUpdateDto, BookSubject>().ReverseMap();
            CreateMap<BookSubjectListDto, BookSubject>().ReverseMap();
        }
    }
}
