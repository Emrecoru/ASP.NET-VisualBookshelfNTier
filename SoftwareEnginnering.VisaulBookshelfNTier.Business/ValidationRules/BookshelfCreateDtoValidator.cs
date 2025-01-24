using FluentValidation;
using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.ValidationRules
{
    public class BookshelfCreateDtoValidator : AbstractValidator<BookshelfCreateDto>
    {
        public BookshelfCreateDtoValidator()
        {
            //RuleFor(x => x.AppUserCreateDto).NotEmpty();
            //RuleFor(x => x.Book.DownloadCount).NotEmpty();
        }
    }
}
