using Microsoft.AspNetCore.Mvc;
using MyGameStore.BLL.Enums;
using MyGameStore.BLL.Interfaces;
using MyGameStore.DAL.Model;
using System;
using System.Linq;

namespace MyGameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private IStoreService _service;

        private const int ACCES_KEY = 123456789;

        public StoreController(IStoreService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetStores([FromHeader(Name = "X-City")] string city, [FromHeader(Name = "X-ZipCode)")] string zipCode, Sort sort, SortBy sortBy, int page = 1, int pageLength = 10)
        {
            var result = _service.GetAll(city, zipCode, sort, sortBy, page, pageLength);

            if (result.Any() == false)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetStoreById(int id)
        {
            try
            {
                var result = _service.GetById(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult CreatePerson([FromBody] Store store)
        {
            try
            {
                _service.Add(store);
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
        public IActionResult UpdatePerson([FromBody] Store store)
        {
            try
            {
                _service.Update(store);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
    }
}
