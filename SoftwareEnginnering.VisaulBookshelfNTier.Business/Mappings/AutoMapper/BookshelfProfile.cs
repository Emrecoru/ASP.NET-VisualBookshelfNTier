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
    public class BookshelfProfile : Profile
    {
        public BookshelfProfile()
        {
            CreateMap<BookshelfCreateDto, Bookshelf>().ReverseMap();
            CreateMap<BookshelfUpdateDto, Bookshelf>().ReverseMap();
            CreateMap<BookshelfListDto, Bookshelf>().ReverseMap();
        }
    }
}
