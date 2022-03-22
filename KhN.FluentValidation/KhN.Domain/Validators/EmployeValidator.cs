using FluentValidation;
using KhN.Domain.Models;

namespace KhN.Domain.Validators
{
    public class EmployeValidator : AbstractValidator<Employe>
    {
        public EmployeValidator()
        {
            RuleFor(x => x.Name)
                .NotNull();

            RuleFor(x => x.Email)
                .NotNull();

            RuleFor(x => x.BirthDate)
                .GreaterThan(DateTime.MinValue);
        }
    }
}
