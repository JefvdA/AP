using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyGameStore.Models;
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
        private static List<Person> peopleList = new List<Person>();
        private const int ACCES_KEY = 123456789;

        public PeopleController()
        {
            if (peopleList.Count > 0)
                return;

            peopleList.Add(new Person(0, "van der Avoirt", "Jef", Gender.MALE));
            peopleList.Add(new Person(1, "Baeten", "Jens", Gender.MALE));
        }

        [HttpGet]
        public IActionResult GetPeople()
        {
            return Ok(peopleList);
        }

        [HttpGet("{id}")]
        public IActionResult GetPersonByID(int id)
        {
            Person requestedPerson = FindPersonByID(id);

            if (requestedPerson != null)
                return Ok(requestedPerson);
            else
                return NotFound();
        }

        [HttpGet("search/{lastName}")]
        public IActionResult GetPersonByLastName(string lastName)
        {
            List<Person> requestedPersonList = FindPeopleByLastName(lastName);

            if (requestedPersonList.Count != 0)
                return Ok(requestedPersonList);
            else
                return NotFound();
        }

        [HttpPost]
        public IActionResult CreatePerson(string firstName, string lastName, int gender)
        {
            Person person = new Person(peopleList.Count, lastName, firstName, (Gender)gender);
            peopleList.Add(person);
            return Created("People", person);
        }

        [HttpPut("update")]
        public IActionResult Update(int id, string firstName, string lastName, int gender)
        {
            Person requestedPerson = FindPersonByID(id);

            if (requestedPerson != null)
            {
                requestedPerson.FirstName = firstName;
                requestedPerson.LastName = lastName;
                requestedPerson.Gender = (Gender)gender;
                return Ok(requestedPerson);
            } else
                return NotFound();    
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromHeader (Name = "X-AccesKey")] int accesKey, int id)
        {
            Person requestedPerson = FindPersonByID(id);

            if (requestedPerson != null)
            {
                if (accesKey == ACCES_KEY)
                {
                    peopleList.Remove(requestedPerson);
                    return NoContent();
                }
                else
                    return Unauthorized();
            } else
            {
                return NotFound();
            }
        }

        private Person FindPersonByID(int id)
        {
            Person requestedPerson = null;
            foreach (Person person in peopleList)
            {
                if (person.ID == id)
                    requestedPerson = person;
            }
            return requestedPerson;
        }
    
        private List<Person> FindPeopleByLastName(string lastName)
        {
            List<Person> requestedPersonList = new List<Person>();
            foreach(Person person in peopleList)
            {
                if (person.LastName == lastName)
                    requestedPersonList.Add(person);
            }
            return requestedPersonList;
        }
    }
}
