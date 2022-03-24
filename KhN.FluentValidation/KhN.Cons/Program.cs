
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
            #region Session18,19,20,21,22,23,24,25,26,27,28,29,30

            //Session30
            Register register = new Register()
            {
                Age = 18
                //Age = 26
            };


            ////Session29
            //Register register = new Register()
            //{
            //    //CreditCard = "12x553",
            //    //CreditCard = "6219861056871766",
            //    CreditCard = "6219-8610-5687-1766"
            //};


            ////Session27,28
            //Register register = new Register()
            //{
            //    //Email = "legolearn.ir"
            //    Email = "info@legolearn.ir"
            //};


            ////Session26
            //Register register = new Register()
            //{
            //    Credit = 500000
            //};


            ////Session25
            //Register register = new Register()
            //{
            //    Credit = 10000000
            //};



            ////Session24
            //Register register = new Register()
            //{
            //    UserName = "aaa"
            //};


            ////Session23
            //Register register = new Register()
            //{
            //    UserName = "legolearnuserformywebsite"
            //};



            ////Session22
            //Register register = new Register()
            //{
            //    UserName = "09155575098x"
            //};


            ////Session21
            //Register register = new Register()
            //{
            //    Password = "123",
            //    RePassword = "123456"
            //};


            ////Session20
            //Register register = new Register()
            //{
            //    UserName = "admin"
            //};

            ////Session18,19
            //Register register = new Register();
            RegisterValidator validator = new RegisterValidator();

            ValidationResult result = validator.Validate(register);

            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    Console.WriteLine(failure.ErrorMessage);
                }
            }

            #endregion

            #region Session17

            //User user = new User();
            //UserValidator validator = new UserValidator();

            //ValidationResult result = validator.Validate(user);

            //if (!result.IsValid)
            //{
            //    foreach (var failure in result.Errors)
            //    {
            //        Console.WriteLine("Property " + failure.PropertyName +
            //                          " Error: " + failure.ErrorMessage
            //                          );
            //    }
            //}

            #endregion

            #region Session16

            //User user = new User();
            //UserValidator validator = new UserValidator();

            //ValidationResult result = validator.Validate(user);

            //if (!result.IsValid)
            //{
            //    foreach (var failure in result.Errors)
            //    {
            //        Console.WriteLine("Property " + failure.PropertyName +
            //                          " State: " + failure.CustomState
            //                          );
            //    }
            //}

            #endregion

            #region Session15

            //User user = new User();
            //UserValidator validator = new UserValidator();

            //ValidationResult result = validator.Validate(user);

            //if (!result.IsValid)
            //{
            //    foreach (var failure in result.Errors)
            //    {
            //        Console.WriteLine("Property " + failure.PropertyName +
            //                          " Error Code: " + failure.ErrorCode
            //                          );
            //    }
            //}

            #endregion

            #region Session14

            //User user = new User();
            //UserValidator validator = new UserValidator();

            //ValidationResult result = validator.Validate(user);

            //if (!result.IsValid)
            //{
            //    foreach (var failure in result.Errors)
            //    {
            //        Console.WriteLine("Property " + failure.PropertyName +
            //                          " Severity: " + failure.Severity
            //                          );
            //    }
            //}

            #endregion

            #region Session13

            //Product product = new Product()
            //{
            //    Title = "test"
            //};
            //ProductValidator validator = new ProductValidator();
            //ValidationResult result = validator.Validate(product);

            //if (!result.IsValid)
            //{
            //    foreach (var failure in result.Errors)
            //    {
            //        Console.WriteLine("Property " + failure.PropertyName +
            //                          " Error: " + failure.ErrorMessage
            //                          );
            //    }
            //}

            #endregion

            #region Session12

            //User user = new User();
            //UserFirstNameValidator validator = new UserFirstNameValidator();
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

            #region Session11

            #endregion

            #region Session10

            #endregion

            #region Session9

            //User user = new User();
            //UserAgeValidator validator = new UserAgeValidator();

            ////user.Age = 17;

            //user.Age = 20;

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

            #region Session8

            //User user = new User();
            //UserValidator validator = new UserValidator();

            //ValidationResult result = validator.Validate(user, options => options.IncludeRuleSets("NameAndFamily"));

            //ValidationResult result = validator.Validate(user, options => options.IncludeRuleSets("AgeAndAddress"));

            //ValidationResult result = validator.Validate(user, options => options.IncludeRuleSets("NameAndFamily", "AgeAndAddress"));

            //ValidationResult result = validator.Validate(user, options => options.IncludeAllRuleSets());


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

            #region Session7

            #endregion

            #region Session6

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