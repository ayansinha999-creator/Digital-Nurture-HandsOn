using EmployeeWebAPI_CustomModel.Filters;
using Microsoft.AspNetCore.Mvc;
using EmployeeWebAPI_CustomModel.Models;

namespace EmployeeWebAPI_CustomModel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department
                    {
                        Id = 1,
                        Name = "IT"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = ".NET" }
                    },
                    DateOfBirth = new DateTime(1998, 5, 20)
                },

                new Employee
                {
                    Id = 2,
                    Name = "David",
                    Salary = 60000,
                    Permanent = false,
                    Department = new Department
                    {
                        Id = 2,
                        Name = "HR"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, Name = "SQL" },
                        new Skill { Id = 4, Name = "Azure" }
                    },
                    DateOfBirth = new DateTime(1996, 10, 15)
                }
            };
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(GetStandardEmployeeList());
        }

        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            return Ok(employee);
        }

        [HttpPut]
        public ActionResult<Employee> Put([FromBody] Employee employee)
        {
            return Ok(employee);
        }
    }
}