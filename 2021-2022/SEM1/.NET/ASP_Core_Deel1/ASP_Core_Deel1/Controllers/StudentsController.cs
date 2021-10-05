using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ASP_Core_Deel1.Classes;

namespace ASP_Core_Deel1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private List<Person> people = new List<Person>();

        [HttpGet]
        public IActionResult GetStudents()
        {
            people.Add(new Person(0, "van der Avoirt", "Jef", new DateTime()));

            return Ok(people);
        }
    }
}
