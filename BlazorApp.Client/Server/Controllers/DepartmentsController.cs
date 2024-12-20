using BlazorApp.Client.Server.Models;
using BlazorApp.Client.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Client.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository departmentRepository;

        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetDepartments()
        {
            try
            {
                // Fetching the departments
                var departments = await departmentRepository.GetDepartments();

                // Return a 404 response if no departments are found
                return departments?.Any() == true
                    ? Ok(departments)
                    : NotFound("No departments found.");
            }
            catch (Exception ex)
            {
                // Log the exception details (use a logger)
                // e.g., _logger.LogError(ex, "Error occurred in GetDepartments");

                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"Error retrieving data from the database: {ex.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Department>> GetDepartment(int id)
        {
            try
            {
                var result = await departmentRepository.GetDepartment(id);

                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}