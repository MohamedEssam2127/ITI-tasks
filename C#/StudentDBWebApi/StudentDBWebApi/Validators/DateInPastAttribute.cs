using StudentDBWebApi.Models;
using System.ComponentModel.DataAnnotations;

namespace StudentDBWebApi.Validators
{
    public class DateInPastAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DateTime? dateT = value as DateTime?;

            if (dateT == null)
                return ValidationResult.Success; 

            var student = (Student)validationContext.ObjectInstance;
            int years = DateTime.Now.Year - dateT.Value.Year;

            if (dateT > DateTime.Now)
                return new ValidationResult(ErrorMessage ?? "Date must be in the past.");
            if (years != student.Age)
                return new ValidationResult(ErrorMessage ?? "date must match age ");
            
            return ValidationResult.Success;
        }
    }
}
