using FluentValidation;
using KhN.Domain.Models;

namespace KhN.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(current => current.FirstName).NotNull().WithMessage("Please Enter The FirstName");
            RuleFor(current => current.LastName).NotNull().WithMessage("Please Enter The LastName");
        }
    }
}
