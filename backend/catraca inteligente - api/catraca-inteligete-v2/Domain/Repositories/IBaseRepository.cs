using Domain.Entities;

namespace Domain.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : Entity
    {
        public TEntity GetById(int id);
        public IEnumerable<TEntity> GetAll();
        public TEntity Add(TEntity entity);
        public TEntity Update(TEntity entity);
        public bool Delete(int id);
        public int Commit();

    }
}
