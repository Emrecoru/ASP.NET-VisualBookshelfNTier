using AutoMapper;
using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using SoftwareEngineering.VisualBookshelfNTier.Entities;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.Mappings.AutoMapper
{
    public class AppUserProfile : Profile
    {
        public AppUserProfile()
        {
            CreateMap<AppUserCreateDto, AppUser>().ReverseMap();
            CreateMap<AppUserUpdateDto, AppUser>().ReverseMap();
            CreateMap<AppUserListDto, AppUser>().ReverseMap();

        }
    }
}
