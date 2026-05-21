using StudentDBWebApi.Context;
using StudentDBWebApi.Models;
using System.ComponentModel.DataAnnotations;

namespace StudentDBWebApi.Validators
{
    public class UniqueEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // Resolve UniversityContext from the DI container via ValidationContext
            var context = (UniversityContext)validationContext.GetService(typeof(UniversityContext))!;
            var student = (Student)validationContext.ObjectInstance;
            string? email = value as string;

            if (string.IsNullOrWhiteSpace(email))
            {
                return ValidationResult.Success;
            }

            if (context.Students.Any(s => s.Email == email && s.Id != student.Id))
            {
                return new ValidationResult("Email address is already in use.");
            }

            return ValidationResult.Success;
        }
    }
}
