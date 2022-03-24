using FluentValidation;
using KhN.Domain.Models;

namespace KhN.Domain.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(current => current.UserName).NotNull();
        }
    }
}
