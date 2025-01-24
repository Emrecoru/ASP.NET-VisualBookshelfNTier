using AutoMapper;
using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using SoftwareEngineering.VisualBookshelfNTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.Mappings.AutoMapper
{
    public class BookAuthorProfile : Profile
    {
        public BookAuthorProfile()
        {
            CreateMap<BookAuthorCreateDto, BookAuthor>().ReverseMap();
            CreateMap<BookAuthorUpdateDto, BookAuthor>().ReverseMap();
            CreateMap<BookAuthorListDto, BookAuthor>().ReverseMap();
        }
    }
}
