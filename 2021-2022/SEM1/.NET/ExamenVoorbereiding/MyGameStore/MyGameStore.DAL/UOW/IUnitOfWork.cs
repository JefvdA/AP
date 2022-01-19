using MyGameStore.DAL.Repositories;

namespace MyGameStore.DAL.UOW
{
    public interface IUnitOfWork
    {
        public int Commit();

        public IPeopleRepository PeopleRepository { get; }
        public IStoreRepository StoreRepository { get; }
    }
}
