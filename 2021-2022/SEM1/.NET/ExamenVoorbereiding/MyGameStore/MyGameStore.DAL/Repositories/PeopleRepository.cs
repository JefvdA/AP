using MyGameStore.DAL.Contexts;
using MyGameStore.DAL.Model;
using System.Collections.Generic;
using System.Linq;

namespace MyGameStore.DAL.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        private GameStoreContext _context;

        public PeopleRepository(GameStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetAll()
        {
            return _context.People;
        }

        public Person GetById(int id)
        {
            return _context.People.Where(p => p.Id.Equals(id)).FirstOrDefault();
        }

        public IEnumerable<Person> GetByLastName(string lastName)
        {
            return _context.People.Where(p => p.LastName.Equals(lastName));
        }

        public void Add(Person person)
        {
            _context.People.Add(person);
        }

        public void Delete(int id)
        {
            Person person = new() { Id = id };
            _context.People.Remove(person);
        }

        public void Update(Person person)
        {
            _context.People.Update(person);
        }
    }
}
