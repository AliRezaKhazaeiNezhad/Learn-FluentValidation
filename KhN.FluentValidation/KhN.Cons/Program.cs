
using KhN.Domain.Models;
using KhN.Domain.Validators;
using FluentValidation.Results;

namespace KhN.Cons 
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            UserValidator validator = new UserValidator();

            ValidationResult result = validator.Validate(user);

            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + 
                                      " failed validation. Error was: " + failure.ErrorMessage
                                      );
                }
            }
        }
    }
}