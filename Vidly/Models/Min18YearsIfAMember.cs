using AutoMapper;
using System.ComponentModel.DataAnnotations;
using Vidly.Dtos;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Customer, CustomerDto>();
            });
            Mapper _mapper = new(configuration);
            var customer = ((Customer)validationContext.ObjectInstance);
            if (customer.MembershipTypeId == MembershipType.Unkown ||
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18) ? ValidationResult.Success :
                new ValidationResult("Customer Should be atleast 18years old to go on a membership");



        }
    }
}
