using Domain.Entities;
using Domain.Repositories;

using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : Entity
    {

        private readonly SmartTurnstileContext _dataAccess;

        public BaseRepository()
        {
        }

        public virtual IEnumerable<TEntity> GetAll() =>
            _dataAccess.Set<TEntity>();

        public virtual TEntity GetById(int id) =>
            _dataAccess.Set<TEntity>().Find(id);

        public virtual TEntity Add(TEntity entity) =>
            AddEntity(entity);


        public virtual bool Delete(int id) =>
            DeleteEntity(id);

        private TEntity AddEntity(TEntity entity)
        {
            _dataAccess.Set<TEntity>().Add(entity);
            if (Commit() > 0) return entity;
            else return null;
        }

        public virtual TEntity Update(TEntity entity)
        {
            _dataAccess.Entry(entity).State = EntityState.Modified;
            if (Commit() > 0) return entity;
            else return null;
        }

        private bool DeleteEntity(int id)
        {
            var entity = _dataAccess.Set<TEntity>().Find(id);
            if (entity == null) return false;
            else
            {
                _dataAccess.Set<TEntity>().Remove(entity);
                return Commit() > 0;
            }
        }

        public int Commit() =>
            _dataAccess.SaveChanges();

    }
}
