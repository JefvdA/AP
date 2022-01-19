using MyGameStore.BLL.Interfaces;
using MyGameStore.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using MyGameStore.DAL.UOW;

namespace MyGameStore.BLL.Services
{
    public class PeopleService : IPeopleService
    {
        private IUnitOfWork _unitOfWork;

        public PeopleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Person> GetAll()
        {
            return _unitOfWork.PeopleRepository.GetAll().ToList();
        }

        public Person GetById(int id)
        {
            var result = _unitOfWork.PeopleRepository.GetById(id);

            if (result == null)
                throw new Exception("Invalid id");

            return result;
        }

        public List<Person> GetByLastName(string lastName)
        {
            var result = _unitOfWork.PeopleRepository.GetByLastName(lastName).ToList();

            if (result.Any() == false)
                throw new Exception("Invalid id");

            return result;
        }

        public void Add(Person person)
        {
            if (_unitOfWork.PeopleRepository.GetAll().Contains(person))
                throw new Exception("This person already exists");

            _unitOfWork.PeopleRepository.Add(person);
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            Person person = _unitOfWork.PeopleRepository.GetById(id);

            if (person == null)
                throw new Exception("Invalid id");

            _unitOfWork.PeopleRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public void Update(Person person)
        {
            if (!_unitOfWork.PeopleRepository.GetAll().Contains(person))
                throw new Exception("Invalid person");

            _unitOfWork.PeopleRepository.Update(person);
            _unitOfWork.Commit();
        }
    }
}
