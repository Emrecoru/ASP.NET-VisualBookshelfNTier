using AutoMapper;
using FluentValidation;
using SoftwareEngineering.VisaulBookshelfNTier.Business.Interfaces;
using SoftwareEngineering.VisualBookshelfNTier.DataAccess.UnitOfWork;
using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using SoftwareEngineering.VisualBookshelfNTier.Dtos.AuthorDtos;
using SoftwareEngineering.VisualBookshelfNTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.Services
{
    public class AuthorService : Service<AuthorCreateDto, AuthorUpdateDto, AuthorListDto, Author>, IAuthorService
    {
        public AuthorService(IMapper mapper, IValidator<AuthorCreateDto> createDtoValidator, IValidator<AuthorUpdateDto> updateDtoValidator, IUow uow) :
            base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
        }
    }
}
