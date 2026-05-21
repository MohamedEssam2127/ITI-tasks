using StudentDBWebApi.Context;
using StudentDBWebApi.Models;
using System.ComponentModel.DataAnnotations;

namespace StudentDBWebApi.Validators
{
    public class UniqueDeptNameAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // Resolve UniversityContext from the DI container via ValidationContext
            var context = (UniversityContext)validationContext.GetService(typeof(UniversityContext))!;
            var department = (Department)validationContext.ObjectInstance;
            string? name = value as string;

            if (string.IsNullOrWhiteSpace(name))
            {
                return ValidationResult.Success;
            }

            if (context.Departments.Any(d => d.Name == name && d.Id != department.Id))
            {
                return new ValidationResult("Department name is already in use.");
            }

            return ValidationResult.Success;
        }
    }
}
