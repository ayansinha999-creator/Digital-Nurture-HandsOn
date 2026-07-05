using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Employee List");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Employee Id : {id}");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Employee Added");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Ok($"Employee {id} Updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Employee {id} Deleted");
        }
    }
}