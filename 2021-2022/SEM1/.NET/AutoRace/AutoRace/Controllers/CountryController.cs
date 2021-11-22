using AutoRace.DAL;
using AutoRace.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private AutoRaceContext _context;

        private const int ACCES_KEY = 123456789;

        public CountryController(AutoRaceContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _context.Countries;

            if (result.Any() == false)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetbByID(int id)
        {
            var result = _context.Countries.Where(ps => ps.ID == id).FirstOrDefault();

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
            return Created("Persons", country);
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] Country country)
        {
            _context.Update(country);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult Delete([FromHeader(Name = "X-AccesKey")] int acces_key, int id)
        {
            if (acces_key == ACCES_KEY)
            {
                Country country = new() { ID = id };
                _context.Remove(country);
                _context.SaveChanges();
                return NoContent();
            }
            else
                return Unauthorized();
        }
    }
}
