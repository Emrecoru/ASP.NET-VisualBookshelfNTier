using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using SoftwareEngineering.VisualBookshelfNTier.Dtos.AuthorDtos;
using SoftwareEngineering.VisualBookshelfNTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.Interfaces
{
    public interface IAuthorService : IService<AuthorCreateDto, AuthorUpdateDto, AuthorListDto, Author>
    {
    }
}
