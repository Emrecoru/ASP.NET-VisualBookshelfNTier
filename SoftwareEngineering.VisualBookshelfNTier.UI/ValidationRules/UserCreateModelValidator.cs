using FluentValidation;
using SoftwareEngineering.VisualBookshelfNTier.UI.Models;

namespace SoftwareEngineering.VisualBookshelfNTier.UI.ValidationRules
{
    public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
    {
        public UserCreateModelValidator()
        {
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Email).EmailAddress().NotEmpty();
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Password not match");
            RuleFor(X => X.Username).MinimumLength(3);
            RuleFor(X => X.Firstname).NotEmpty();
            RuleFor(x => x.Surname).NotEmpty();
        }
    }
}
