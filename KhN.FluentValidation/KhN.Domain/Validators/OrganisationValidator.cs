using FluentValidation;
using KhN.Domain.Models;

namespace KhN.Domain.Validators
{
    public class OrganisationValidator : AbstractValidator<Organization>
    {
        public OrganisationValidator()
        {
            RuleFor(x => x.Name)
                .NotNull();

            RuleFor(x => x.Email)
                .NotNull();

            RuleFor(x => x.Address)
                .SetValidator(new AddressValidator());
        }
    }
}
