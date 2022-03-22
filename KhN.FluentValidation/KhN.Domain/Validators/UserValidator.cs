using FluentValidation;
using KhN.Domain.Models;

namespace KhN.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            //RuleFor(current => current.FirstName)
            //    .NotNull()
            //    .NotEmpty()
            //    .NotEqual("123456")
            //    .WithErrorCode("100")
            //    .WithMessage("Please Enter The FirstName");

            //RuleFor(current => current.LastName)
            //    .NotNull()
            //    .WithMessage("Please Enter The LastName");

            //RuleFor(current => current.Addresses)
            //   .NotNull()
            //   .WithMessage("Please Enter The Addresses");







            //RuleSet("NameAndFamily", () =>
            //{
            //    RuleFor(current => current.FirstName)
            //    .NotNull()
            //    .NotEqual("123456")
            //    .WithErrorCode("100")
            //    .WithMessage("Please Enter The FirstName");

            //    RuleFor(current => current.LastName)
            //        .NotNull()
            //        .WithMessage("Please Enter The LastName");
            //});


            //RuleSet("AgeAndAddress", () =>
            //{

            //    RuleFor(current => current.Age)
            //        .NotNull()
            //        .GreaterThan(1);


            //    RuleFor(current => current.Addresses)
            //       .NotNull()
            //       .WithMessage("Please Enter The Addresses");

            //});



            //Include(new UserFirstNameValidator());
            //Include(new UserAgeValidator());



            RuleFor(current => current.FirstName)
                .NotNull()
                .NotEmpty()
                .NotEqual("123456")
                .WithErrorCode("100")
                .WithMessage("Please Enter The FirstName")
                .WithSeverity(Severity.Error);
        }
    }
}
