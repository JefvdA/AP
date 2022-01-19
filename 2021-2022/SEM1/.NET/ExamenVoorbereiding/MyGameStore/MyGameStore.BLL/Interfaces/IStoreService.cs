using MyGameStore.BLL.Enums;
using MyGameStore.DAL.Model;
using System.Collections.Generic;

namespace MyGameStore.BLL.Interfaces
{
    public interface IStoreService
    {
        public List<Store> GetAll(string city, string zipCode, Sort sort, SortBy sortBy, int page = 1, int pageLength = 10);

        public Store GetById(int id);

        public void Add(Store store);

        public void Delete(int id);

        public void Update(Store store);
    }
}
