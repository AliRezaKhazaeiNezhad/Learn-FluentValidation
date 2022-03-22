﻿
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