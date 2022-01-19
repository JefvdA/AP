using MyGameStore.BLL.Enums;
using MyGameStore.BLL.Interfaces;
using MyGameStore.DAL.Contexts;
using MyGameStore.DAL.Model;
using MyGameStore.DAL.Repositories;
using MyGameStore.DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyGameStore.BLL.Services
{
    public class StoreService : IStoreService
    {
        private IUnitOfWork _unitOfWork;

        public StoreService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Store> GetAll(string city, string zipCode, Sort sort, SortBy sortBy, int page = 1, int pageLength = 10)
        {
            IEnumerable<Store> result = _unitOfWork.StoreRepository.GetAll();

            if (!string.IsNullOrEmpty(city) || !string.IsNullOrEmpty(zipCode))
                result = result.Where(s => s.City == city && s.Zipcode == zipCode);

            if (sort != 0 && sortBy != 0)
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
                result = result.Skip((page - 1) * pageLength).Take(pageLength);

            return result.ToList();
        }

        public Store GetById(int id)
        {
            var result = _unitOfWork.StoreRepository.GetById(id);

            if (result == null)
                throw new Exception("Invalid id");

            return result;
        }

        public void Add(Store store)
        {
            if (_unitOfWork.StoreRepository.GetAll().Contains(store))
                throw new Exception("This store already exists");

            _unitOfWork.StoreRepository.Add(store);
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            Store store = _unitOfWork.StoreRepository.GetById(id);

            if (store == null)
                throw new Exception("Invalid id");

            _unitOfWork.StoreRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public void Update(Store store)
        {
            if (!_unitOfWork.StoreRepository.GetAll().Contains(store))
                throw new Exception("Invalid store");

            _unitOfWork.StoreRepository.Update(store);
            _unitOfWork.Commit();
        }
    }
}
