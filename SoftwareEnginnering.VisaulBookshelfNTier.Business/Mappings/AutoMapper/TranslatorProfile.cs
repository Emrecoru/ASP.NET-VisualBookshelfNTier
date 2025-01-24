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
    public class TranslatorProfile : Profile
    {
        public TranslatorProfile()
        {
            CreateMap<TranslatorCreateDto, Translator>().ReverseMap();
            CreateMap<TranslatorUpdateDto, Translator>().ReverseMap();
            CreateMap<TranslatorListDto, Translator>().ReverseMap();
        }
    }
}
