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
    public class LanguageProfile : Profile
    {
        public LanguageProfile()
        {
            CreateMap<LanguageCreateDto, Language>().ReverseMap();
            CreateMap<LanguageUpdateDto, Language>().ReverseMap();
            CreateMap<LanguageListDto, Language>().ReverseMap();
        }
    }
}
