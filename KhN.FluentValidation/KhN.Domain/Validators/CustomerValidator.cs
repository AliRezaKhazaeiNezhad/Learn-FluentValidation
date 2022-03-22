
using FluentValidation;
using KhN.Domain.Models;

namespace KhN.Domain.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(current => current.Name)
                .NotNull();

            RuleFor(current => current.Address)
                .SetValidator(new AddressValidator());
        }
    }
}
