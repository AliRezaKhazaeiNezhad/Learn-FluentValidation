using FluentValidation;
using KhN.Domain.Models;

namespace KhN.Domain.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(address => address.PostCode)
                .NotNull()
                .WithMessage("PostCode is null !!!");
        }
    }
}
