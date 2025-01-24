using AutoMapper;
using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using SoftwareEngineering.VisualBookshelfNTier.UI.Models;

namespace SoftwareEngineering.VisualBookshelfNTier.UI.Mappings.AutoMapper
{
    public class UserCreateModelProfile : Profile
    {
        public UserCreateModelProfile()
        {
            CreateMap<UserCreateModel, AppUserCreateDto>().ReverseMap();
            CreateMap<AppUserLoginDto, AppUserCreateDto>().ReverseMap();
        }
    }
}
