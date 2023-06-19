using Domain.Entities;
using Domain.Repositories;


namespace Infrastructure.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : Entity
    {


        public BaseRepository()
        {
        }

        public abstract IEnumerable<TEntity> GetAll();

        public abstract TEntity GetById(int id);

        public abstract TEntity Add(TEntity entity);

        public abstract bool Delete(int id);


        //    public virtual bool Delete(int id) =>
        //        DeleteEntity(id);

        //    private TEntity AddEntity(TEntity entity)
        //    {
        //        _dataAccess.Set<TEntity>().Add(entity);
        //        if (Commit() > 0) return entity;
        //        else return null;
        //    }

        //    public virtual TEntity Update(TEntity entity)
        //    {
        //        _dataAccess.Entry(entity).State = EntityState.Modified;
        //        if (Commit() > 0) return entity;
        //        else return null;
        //    }

        //    private bool DeleteEntity(int id)
        //    {
        //        var entity = _dataAccess.Set<TEntity>().Find(id);
        //        if (entity == null) return false;
        //        else
        //        {
        //            _dataAccess.Set<TEntity>().Remove(entity);
        //            return Commit() > 0;
        //        }
        //    }

        //    public int Commit() =>
        //        _dataAccess.SaveChanges();

        //}
    }
}
