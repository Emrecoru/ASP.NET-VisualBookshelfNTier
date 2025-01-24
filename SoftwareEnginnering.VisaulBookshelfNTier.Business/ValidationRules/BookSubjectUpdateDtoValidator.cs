using FluentValidation;
using SoftwareEngineering.VisualBookshelfNTier.Dtos;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.ValidationRules
{
    public class BookSubjectUpdateDtoValidator : AbstractValidator<BookSubjectUpdateDto>
    {
        public BookSubjectUpdateDtoValidator()
        {
        }
    }
}
