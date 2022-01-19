using Microsoft.AspNetCore.Mvc;
using MyGameStore.BLL.Interfaces;
using MyGameStore.DAL.Model;
using System;
using System.Linq;

namespace MyGameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private IPeopleService _service;

        private const int ACCES_KEY = 123456789;

        public PeopleController(IPeopleService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetPeople()
        {
            var result = _service.GetAll();

            if (result.Any() == false)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetPersonById(int id)
        {
            try
            {
                var result = _service.GetById(id);
                return Ok(result);
            }
            catch(Exception e)
            {
                return NotFound();
            }
        }

        [HttpGet("/search/{lastName}")]
        public IActionResult GetPeopleByLastName(string lastName)
        {
            try
            {
                var result = _service.GetByLastName(lastName);
                return Ok(result);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult CreatePerson([FromBody] Person person)
        {
            try
            {
                _service.Add(person);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [HttpDelete]
        public IActionResult DeletePerson([FromHeader(Name = "X-AccesKey")] int acces_key, int id)
        {
            if (!acces_key.Equals(ACCES_KEY))
                return Unauthorized();

            try
            {
                _service.Delete(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [HttpPut]
        public IActionResult UpdatePerson([FromBody] Person person)
        {
            try
            {
                _service.Update(person);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
    }
}
