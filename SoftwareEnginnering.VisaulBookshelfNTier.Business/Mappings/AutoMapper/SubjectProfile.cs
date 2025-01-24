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
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<SubjectCreateDto, Subject>().ReverseMap();
            CreateMap<SubjectUpdateDto, Subject>().ReverseMap();
            CreateMap<SubjectListDto, Subject>().ReverseMap();
        }
    }
}
