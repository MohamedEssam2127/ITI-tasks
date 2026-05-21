using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentDBWebApi.Context;
using StudentDBWebApi.DTOs;
using StudentDBWebApi.Models;
using StudentDBWebApi.Repository;

namespace StudentDBWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "admin")]
    public class DepartmentController : ControllerBase
    {
        IGenericRepository<Department> _repo;
        //UniversityContext _context;

        public DepartmentController(IGenericRepository<Department> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var departments = _repo.GetAll()
                .Include(d => d.Students)
                .Select(d => new DeptDTO
                {
                    Name = d.Name,
                    Location = d.Location,
                    StudentNames = d.Students.Select(s => s.Name).ToList(),
                    Count = d.Students.Count,
                    Message = d.Students.Count > 1 ? "overloaded" : "normal"
                })
                .ToList();

            return Ok(new { message = "All Departments", data = departments });
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var department = _repo.GetById(id);
              

            if (department == null)
                return NotFound(new { message = "Department not found" });

            return Ok(new { message = "Department", data = department });
        }

        [HttpPost]
        public IActionResult Add(Department department)
        {
            _repo.Add(department);
            _repo.Save();

            return CreatedAtAction(nameof(GetById), new { id = department.Id }, new
            {
                message = "Department added successfully",
                data = department
            });
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, Department department)
        {
            var existing = _repo.GetById(id);
            if (existing == null)
                return NotFound(new { message = "Department not found" });

            department.Id = id;
            _repo.Update(department);
            _repo.Save();

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var department = _repo.GetById(id);
            if (department == null)
                return NotFound(new { message = "Department not found" });

            _repo.Remove(department);
            _repo.Save();

            return Ok(new { message = "Department deleted successfully", data = department });
        }
    }
}
