using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentDBWebApi.Models;
using StudentDBWebApi.Repository;
using System.Security.Claims;

namespace StudentDBWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentController : ControllerBase
    {
        IGenericRepository<Student> _repo;
       UserManager<ApplicationUser> _userManager;

        public StudentController(IGenericRepository<Student> repo, UserManager<ApplicationUser> userManager)
        {
            _repo = repo;
            _userManager = userManager;
        }

     
        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult GetAll()
        {
            var students = _repo.GetAll();
            return Ok(new { message = "All Students", data = students });
        }

        [HttpGet("{id:int}")]
        [Authorize(Roles = "admin,std")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = _repo.GetById(id);
            if (student == null)
            {
                return NotFound(new { message = "Student not found" });
            }

            if (User.IsInRole("std") && !User.IsInRole("admin"))
            {
                var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);
                if (currentUser == null || currentUser.Email != student.Email)
                {
                    return Forbid();
                }
            }

            return Ok(new { message = "Student", data = student });
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Add([FromForm] Student s, IFormFile image)
        {
            if (image != null)
            {
                string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

                string fileName = Guid.NewGuid() + Path.GetExtension(image.FileName);

                string filePath = Path.Combine(folderPath, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }

                s.Img = "/images/" + fileName;
            }

            _repo.Add(s);
            _repo.Save();

            return CreatedAtAction(nameof(GetById), new { id = s.Id }, new
            {
                message = "Student added successfully",
                data = s
            });
        }

        [HttpPut("{id:int}")]
        [Authorize(Roles = "std")]
        public async Task<IActionResult> Update(int id, Student student)
        {
            var existing = _repo.GetById(id);
            if (existing == null)
            {
                return NotFound(new { message = "Student not found" });
            }

            var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (currentUser == null || currentUser.Email != existing.Email)
            {
                return Forbid();
            }

            student.Id = id;
            _repo.Update(student);
            _repo.Save();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            var student = _repo.GetById(id);
            if (student == null)
            {
                return NotFound(new { message = "Student not found" });
            }
            _repo.Remove(student);
            _repo.Save();
            return Ok(new { message = "Student deleted successfully", data = student });
        }
    }
}
