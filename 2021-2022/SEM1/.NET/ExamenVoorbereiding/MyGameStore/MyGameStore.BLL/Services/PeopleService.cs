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

            return result;
        }

        public List<Person> GetByLastName(string lastName)
        {
            var result = _unitOfWork.PeopleRepository.GetByLastName(lastName).ToList();

            return result;
        }

        public void Add(Person person)
        {
            _unitOfWork.PeopleRepository.Add(person);
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        { 
            _unitOfWork.PeopleRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public void Update(Person person)
        {
            _unitOfWork.PeopleRepository.Update(person);
            _unitOfWork.Commit();
        }
    }
}
