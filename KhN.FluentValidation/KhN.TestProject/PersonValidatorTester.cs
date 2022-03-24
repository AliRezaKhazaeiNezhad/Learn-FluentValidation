using NUnit.Framework;
using KhN.Domain.Models;
using KhN.Domain.Validators;
using FluentValidation.TestHelper;

namespace KhN.TestProject
{
    [TestFixture]
    public class PersonValidatorTester
    {
        private PersonValidator validator;


        [SetUp]
        public void Setup()
        {
            validator = new PersonValidator();
        }


        [Test]
        public void Should_have_error_when_Name_is_null()
        {
            var model = new Person { UserName = null };
            var result = validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(person => person.UserName);
        }

        [Test]
        public void Should_not_have_error_when_name_is_specified()
        {
            var model = new Person { UserName = "legolearn" };
            var result = validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(person => person.UserName);
        }
    }
}
