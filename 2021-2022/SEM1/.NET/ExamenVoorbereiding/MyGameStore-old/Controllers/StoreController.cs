using Microsoft.AspNetCore.Mvc;
using MyGameStore.DAL;
using MyGameStore.Model;
using System.Linq;

namespace MyGameStore.Controllers
{
    public enum Sort { Ascending=1, Descending }
    public enum SortBy { Name=1, Zip }

    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private GameStoreContext _context;

        private const int ACCES_KEY = 123456789;

        public StoreController(GameStoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetStores([FromHeader(Name = "X-City")] string city, [FromHeader(Name = "X-ZipCode)")] string zipCode, Sort sort, SortBy sortBy, int page = 1, int pageLength = 10)
        {
            IQueryable<Store> result = _context.Stores;

            if (!string.IsNullOrEmpty(city) || !string.IsNullOrEmpty(zipCode))
                result = result.Where(s => s.City == city && s.Zipcode == zipCode);

            if(sort != 0 && sortBy != 0)
            {
                if (sort.Equals(Sort.Descending))
                {
                    if (sortBy.Equals(SortBy.Name))
                        result = result.OrderByDescending(n => n.Name);
                    else if (sortBy.Equals(SortBy.Zip))
                        result = result.OrderByDescending(n => n.Zipcode);
                }
                else
                {
                    if (sortBy.Equals(SortBy.Name))
                        result = result.OrderBy(n => n.Name);
                    else if (sortBy.Equals(SortBy.Zip))
                        result = result.OrderBy(n => n.Zipcode);
                }
            }

            if (page > 0 && pageLength > 0)
                result = result.Skip((page-1) * pageLength).Take(pageLength);

            if (result.Any() == false)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetStoreById(int id)
        {
            var result = _context.Stores.Where(s => s.Id.Equals(id)).FirstOrDefault();

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateStore([FromBody] Store store)
        {
            _context.Stores.Add(store);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStore([FromHeader(Name = "X-AccesKey")] int acces_key, int id)
        {
            if (!acces_key.Equals(ACCES_KEY))
                return Unauthorized();

            Store store = new Store() { Id = id };
            _context.Remove(store);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStore([FromBody] Store store)
        {
            _context.Update(store);
            _context.SaveChanges();

            return Ok();
        }
    }
}
