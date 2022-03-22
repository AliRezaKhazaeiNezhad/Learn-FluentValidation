
using FluentValidation;
using KhN.Domain.Models;

namespace KhN.Domain.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.Name)
                .NotNull();

            RuleFor(customer => customer.Address)
                .SetValidator(new AddressValidator());
        }
    }
}
