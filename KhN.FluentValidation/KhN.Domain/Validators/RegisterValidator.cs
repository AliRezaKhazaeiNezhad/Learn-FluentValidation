using FluentValidation;
using KhN.Domain.Models;

namespace KhN.Domain.Validators
{
    public class RegisterValidator : AbstractValidator<Register>
    {
        public RegisterValidator()
        {
            //Session24
            RuleFor(current => current.UserName).MinimumLength(5);


            ////Session23
            //RuleFor(current => current.UserName).MaximumLength(15);


            ////Session22
            //RuleFor(current => current.UserName).Length(11);


            ////Session21
            //RuleFor(current => current.Password)
            //    .Equal(current => current.RePassword)
            //    .WithMessage("Password and Repasword not equal");

            ////Session20
            //RuleFor(current => current.UserName).NotEqual("admin");


            //Session19
            //RuleFor(current => current.UserName).NotEmpty();


            //Session18
            //RuleFor(current => current.UserName).NotNull();
        }
    }
}
