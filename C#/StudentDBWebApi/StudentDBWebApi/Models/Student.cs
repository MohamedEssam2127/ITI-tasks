using StudentDBWebApi.Validators;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StudentDBWebApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        [RegularExpression(@"^[A-Za-z\s]{6,15}$",ErrorMessage = "Name must be 6–15 characters and contain only letters and spaces.")]
        public string Name { get; set; }

        [Range(14, 18, ErrorMessage = "Age must be between 14 and 18.")]

        public int Age { get; set; }
        public string Address { get; set; }
        public string Level { get; set; }

        [DateInPast]
        public DateTime DOB { get; set; }
        public   string? Img {  get; set; }

        [UniqueEmail]
        public  string Email { get; set; }


        public int? DepartmentId { get; set; }
        [JsonIgnore]
        public Department? Department { get; set; }
        
    }
}
