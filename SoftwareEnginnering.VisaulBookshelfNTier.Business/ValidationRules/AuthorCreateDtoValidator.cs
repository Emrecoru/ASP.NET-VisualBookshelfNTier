using FluentValidation;
using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.ValidationRules
{
    public class AuthorCreateDtoValidator : AbstractValidator<AuthorCreateDto>
    {
        public AuthorCreateDtoValidator()
        {
            //RuleFor(x => x.Name).NotEmpty();
            //RuleFor(x => x.BirthYear).NotEmpty();
            //RuleFor(x => x.DeathYear).NotEmpty();
        }
    }
}
