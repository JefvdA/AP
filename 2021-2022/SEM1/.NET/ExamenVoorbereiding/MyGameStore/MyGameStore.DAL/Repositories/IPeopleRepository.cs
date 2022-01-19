using MyGameStore.DAL.Model;
using System.Collections.Generic;

namespace MyGameStore.DAL.Repositories
{
    public interface IPeopleRepository
    {
        public IEnumerable<Person> GetAll();

        public Person GetById(int id);

        public IEnumerable<Person> GetByLastName(string lastName);

        public void Add(Person person);

        public void Delete(int id);

        public void Update(Person person);
    }
}
