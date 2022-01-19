using MyGameStore.DAL.Contexts;
using MyGameStore.DAL.Model;
using System.Collections.Generic;
using System.Linq;

namespace MyGameStore.DAL.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private GameStoreContext _context;

        public StoreRepository(GameStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Store> GetAll()
        {
            return _context.Stores;
        }

        public Store GetById(int id)
        {
            return _context.Stores.Where(s => s.Id.Equals(id)).FirstOrDefault();
        }

        public void Add(Store store)
        {
            _context.Stores.Add(store);
        }

        public void Delete(int id)
        {
            Store store = new() { Id = id };
            _context.Stores.Remove(store);
        }

        public void Update(Store store)
        {
            _context.Update(store);
        }
    }
}
