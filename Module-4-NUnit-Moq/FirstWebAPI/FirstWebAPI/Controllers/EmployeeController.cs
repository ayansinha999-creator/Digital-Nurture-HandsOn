using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to First Web API");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Employee Added");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Employee Updated");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("Employee Deleted");
        }
    }
}