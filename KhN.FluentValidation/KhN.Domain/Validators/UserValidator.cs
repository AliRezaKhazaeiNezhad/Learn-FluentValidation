using FluentValidation;
using KhN.Domain.Models;
using KhN.Resource;

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



            //RuleFor(current => current.FirstName)
            //    .NotEmpty()
            //    .WithSeverity(Severity.Info);



            //RuleFor(current => current.FirstName)
            //    .NotEmpty()
            //    .WithState(fName => 1234)
            //    .WithErrorCode("ER-1256");



            //RuleFor(current => current.FirstName)
            //    .NotNull()
            //    .WithMessage(fName => MyLocalizedMessagesUS.FirstName);

            //RuleFor(current => current.FirstName)
            //  .NotNull()
            //  .WithMessage(fName => MyLocalizedMessagesFR.FirstName);
        }
    }
}
