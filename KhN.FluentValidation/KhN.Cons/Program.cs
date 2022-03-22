
using FluentValidation;
using KhN.Domain.Models;
using KhN.Domain.Validators;
using FluentValidation.Results;

namespace KhN.Cons 
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Session6

            User user = new User();
            UserValidator validator = new UserValidator();

            ValidationResult result = validator.Validate(user);

            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName +
                                      " Error: " + failure.ErrorMessage +
                                      " Error Code: " + failure.ErrorCode
                                      );
                }
            }


            #endregion

            #region Session5

            //Customer customer = new Customer() { 
            //    Address =  new Address() { 
            //        County = "Iran"
            //    }
            //};
            //CustomerValidator validator = new CustomerValidator();

            //ValidationResult result = validator.Validate(customer);

            //if (!result.IsValid)
            //{
            //    foreach (var failure in result.Errors)
            //    {
            //        Console.WriteLine("Property " + failure.PropertyName +
            //                          " Error: " + failure.ErrorMessage +
            //                          " Error Code: " + failure.ErrorCode
            //                          );
            //    }
            //}

            #endregion

            #region Session4

            //User user = new User();
            //UserValidator validator = new UserValidator();

            ////ValidationResult result = validator.Validate(user);
            //validator.ValidateAndThrow(user);

            #endregion

            #region Session3

            //User user = new User() { FirstName = "123456" };
            //UserValidator validator = new UserValidator();

            //ValidationResult result = validator.Validate(user);

            //if (!result.IsValid)
            //{
            //    foreach (var failure in result.Errors)
            //    {
            //        Console.WriteLine("Property " + failure.PropertyName +
            //                          " Error: " + failure.ErrorMessage +
            //                          " Error Code: " + failure.ErrorCode
            //                          );
            //    }
            //}

            #endregion

            #region Session1,2

            //User user = new User();
            //UserValidator validator = new UserValidator();

            //ValidationResult result = validator.Validate(user);

            //if (!result.IsValid)
            //{
            //    foreach (var failure in result.Errors)
            //    {
            //        Console.WriteLine("Property " + failure.PropertyName +
            //                          " Error: " + failure.ErrorMessage +
            //                          " Error Code: " + failure.ErrorCode
            //                          );
            //    }
            //}

            #endregion
        }
    }
}