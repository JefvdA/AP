using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyGameStore.DAL;
using MyGameStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private MyGameStoreContext _context;

        private const int ACCES_KEY = 123456789;

        public PeopleController(MyGameStoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPeople()
        {
            var result = _context.Persons;

            if (result.Any() == false)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetPersonByID(int id)
        {
            var result = _context.Persons.Where(ps => ps.ID == id).FirstOrDefault();

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("/search/{lastName}")]
        public IActionResult GetPeopleByLastName(string lastName)
        {
            var result = _context.Persons.Where(ps => ps.LastName == lastName);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreatePerson([FromBody] Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
            return Created("Persons" , person);
        }

        [HttpPut("Update")]
        public IActionResult UpdatePerson([FromBody] Person person)
        {
            _context.Update(person);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult DeletePerson([FromHeader (Name = "X-AccesKey")] int acces_key, int id)
        {
            if (acces_key == ACCES_KEY)
            {
                Person person = new() { ID = id };
                _context.Remove(person);
                _context.SaveChanges();
                return NoContent();
            }
            else
                return Unauthorized();
        }
    }
}
