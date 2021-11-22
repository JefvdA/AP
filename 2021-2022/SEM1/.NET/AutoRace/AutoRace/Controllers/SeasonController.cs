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
    public class SeasonController : ControllerBase
    {
        private AutoRaceContext _context;

        private const int ACCES_KEY = 123456789;

        public SeasonController(AutoRaceContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _context.Seasons;

            if (result.Any() == false)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var result = _context.Seasons.Where(ps => ps.ID == id).FirstOrDefault();

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Season season)
        {
            _context.Seasons.Add(season);
            _context.SaveChanges();
            return Created("Persons", season);
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] Season season)
        {
            _context.Update(season);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult Delete([FromHeader(Name = "X-AccesKey")] int acces_key, int id)
        {
            if (acces_key == ACCES_KEY)
            {
                Season season = new() { ID = id };
                _context.Remove(season);
                _context.SaveChanges();
                return NoContent();
            }
            else
                return Unauthorized();
        }
    }
}
