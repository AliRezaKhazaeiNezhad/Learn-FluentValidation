using FluentValidation;
using KhN.Domain.Models;

namespace KhN.Domain.Validators
{
    public class UserAgeValidator : AbstractValidator<User>
    {
        public UserAgeValidator()
        {
            RuleFor(current => current.Age)
                .Must(IsOver18)
                .WithMessage("Age must be older than 18.");
        }

        private bool IsOver18(int age)
        {
            if (age > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
