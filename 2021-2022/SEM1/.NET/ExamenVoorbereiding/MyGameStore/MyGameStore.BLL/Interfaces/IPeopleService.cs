using MyGameStore.DAL.Model;
using System.Collections.Generic;

namespace MyGameStore.BLL.Interfaces
{
    public interface IPeopleService
    {
        public List<Person> GetAll();

        public Person GetById(int id);

        public List<Person> GetByLastName(string lastName);

        public void Add(Person person);

        public void Delete(int id);

        public void Update(Person person);
    }
}
