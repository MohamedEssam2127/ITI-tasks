using StudentDBWebApi.Validators;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StudentDBWebApi.Models
{
    public class Department
    {
        public int Id { get; set; }

        [UniqueDeptName]
        public string Name { get; set; }

        public string Location { get; set; }

        public string PhoneNumber { get; set; }

        public string Manager { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
