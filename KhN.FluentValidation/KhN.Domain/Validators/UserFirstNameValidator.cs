using FluentValidation;
using KhN.Domain.Models;

namespace KhN.Domain.Validators
{
    public class UserFirstNameValidator : AbstractValidator<User>
    {
        public UserFirstNameValidator()
        {
            //RuleFor(current => current.FirstName)
            //    .Length(10, 255)
            //    .WithName("The First Name")
            //    .WithMessage("Length must be 10-255");


            //RuleFor(current => current.FirstName)
            //   .NotNull()
            //   .WithName("The First Name");
        }
    }
}
