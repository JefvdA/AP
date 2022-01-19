using MyGameStore.DAL.Contexts;
using MyGameStore.DAL.Repositories;

namespace MyGameStore.DAL.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private GameStoreContext _context;
        private IPeopleRepository _peopleRepository;
        private IStoreRepository _storeRepository;

        public IPeopleRepository PeopleRepository { get { return _peopleRepository; } }
        public IStoreRepository StoreRepository { get { return _storeRepository; } }

        public UnitOfWork(GameStoreContext context, IPeopleRepository peopleRepository, IStoreRepository storeRepository)
        {
            _context = context;
            _peopleRepository = peopleRepository;
            _storeRepository = storeRepository;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
