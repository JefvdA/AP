using MyGameStore.DAL.Model;
using System.Collections.Generic;

namespace MyGameStore.DAL.Repositories
{
    public interface IStoreRepository
    {
        public IEnumerable<Store> GetAll();

        public Store GetById(int id);

        public void Add(Store store);

        public void Delete(int id);

        public void Update(Store store);
    }
}
