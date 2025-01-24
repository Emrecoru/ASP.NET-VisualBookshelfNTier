using AutoMapper;
using FluentValidation;
using SoftwareEngineering.VisaulBookshelfNTier.Business.Interfaces;
using SoftwareEngineering.VisualBookshelfNTier.DataAccess.UnitOfWork;
using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using SoftwareEngineering.VisualBookshelfNTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.Services
{
    public class SubjectService : Service<SubjectCreateDto, SubjectUpdateDto, SubjectListDto, Subject>, ISubjectService
    {
        public SubjectService(IMapper mapper, IValidator<SubjectCreateDto> createDtoValidator, IValidator<SubjectUpdateDto> updateDtoValidator,
            IUow uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
        }
    }
}
