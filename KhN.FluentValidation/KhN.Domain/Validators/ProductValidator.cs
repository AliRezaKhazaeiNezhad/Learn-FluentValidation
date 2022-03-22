using FluentValidation;
using KhN.Domain.Models;

namespace KhN.Domain.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //RuleFor(current => current.Title)
            //    .NotEqual("test")
            //    .Length(0, 3);


            //RuleFor(current => current.Title)
            //   .Cascade(CascadeMode.Stop)
            //   .NotEqual("test")
            //   .Length(0, 3);


            //RuleFor(current => current.Title)
            //   .Cascade(CascadeMode.StopOnFirstFailure)
            //   .NotEqual("test")
            //   .Length(0, 3);


            RuleFor(current => current.Title)
               .Cascade(CascadeMode.Continue)
               .NotEqual("test")
               .Length(0, 3);
        }
    }
}
