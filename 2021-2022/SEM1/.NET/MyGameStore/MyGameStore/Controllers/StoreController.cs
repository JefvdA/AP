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
    public class StoreController : ControllerBase
    {
        private MyGameStoreContext _context;

        private const int ACCES_KEY = 123456789;

        public StoreController(MyGameStoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetStores()
        {
            var result = _context.Stores;

            if (result.Any() == false)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetStoreByID(int id)
        {
            var result = _context.Stores.Where(st => st.ID == id).FirstOrDefault();

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateStore([FromBody] Store store)
        {
            _context.Stores.Add(store);
            _context.SaveChanges();
            return Created("Stores", store);
        }

        [HttpPut("Update")]
        public IActionResult UpdateStore([FromBody] Store store)
        {
            _context.Update(store);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteStore([FromHeader(Name = "X-AccesKey")] int acces_key, int id)
        {
            if (acces_key == ACCES_KEY)
            {
                Store store = new() { ID = id };
                _context.Remove(store);
                _context.SaveChanges();
                return NoContent();
            }
            else
                return Unauthorized();
        }
    }
}
