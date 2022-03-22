using FluentValidation;
using KhN.Domain.Models;

namespace KhN.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(current => current.FirstName)
                .NotNull()
                .NotEmpty()
                .NotEqual("123456")
                .WithErrorCode("100")
                .WithMessage("Please Enter The FirstName");

            RuleFor(current => current.LastName)
                .NotNull()
                .WithMessage("Please Enter The LastName");

            RuleFor(current => current.Addresses)
               .NotNull()
               .WithMessage("Please Enter The Addresses");
        }
    }
}
