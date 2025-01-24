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
    public class BookTranslatorProfile : Profile
    {
        public BookTranslatorProfile()
        {
            CreateMap<BookTranslatorCreateDto, BookTranslator>().ReverseMap();
            CreateMap<BookTranslatorUpdateDto, BookTranslator>().ReverseMap();
            CreateMap<BookTranslatorListDto, BookTranslator>().ReverseMap();
        }
    }
}
