using Microsoft.AspNetCore.Mvc;
using MyGameStore.DAL;
using MyGameStore.Model;
using System.Linq;

namespace MyGameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private GameStoreContext _context;

        private const int ACCES_KEY = 123456789;

        public PeopleController(GameStoreContext context)
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
        public IActionResult GetPersonById(int id)
        {
            var result = _context.Persons.Where(p => p.Id.Equals(id)).FirstOrDefault();

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("/search/{lastName}")]
        public IActionResult GetPeopleByLastName(string lastName)
        {
            var result = _context.Persons.Where(p => p.LastName.Equals(lastName));

            if (result.Any() == false)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreatePerson([FromBody] Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeletePerson([FromHeader(Name = "X-AccesKey")] int acces_key, int id)
        {
            if (!acces_key.Equals(ACCES_KEY))
                return Unauthorized();

            Person person = new Person() { Id = id };
            _context.Remove(person);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdatePerson([FromBody] Person person)
        {
            _context.Update(person);
            _context.SaveChanges();

            return Ok();
        }
    }
}
