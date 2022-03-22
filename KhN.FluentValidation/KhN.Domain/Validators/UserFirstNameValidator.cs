using FluentValidation;
using KhN.Domain.Models;

namespace KhN.Domain.Validators
{
    public class UserFirstNameValidator : AbstractValidator<User>
    {
        public UserFirstNameValidator()
        {
            RuleFor(current => current.FirstName)
                .Length(10, 255)
                .WithMessage("Length must be 10-255");
        }
    }
}
