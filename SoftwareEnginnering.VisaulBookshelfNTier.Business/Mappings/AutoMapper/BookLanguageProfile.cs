﻿using AutoMapper;
using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using SoftwareEngineering.VisualBookshelfNTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.Mappings.AutoMapper
{
    public class BookLanguageProfile : Profile
    {
        public BookLanguageProfile()
        {
            CreateMap<BookLanguageCreateDto, BookLanguage>().ReverseMap();
            CreateMap<BookLanguageListDto, BookLanguage>().ReverseMap();
            CreateMap<BookLanguageUpdateDto, BookLanguage>().ReverseMap();
        }
    }
}
