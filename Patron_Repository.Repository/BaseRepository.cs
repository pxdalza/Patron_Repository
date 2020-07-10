using Patron_Repository.Data;
using Patron_Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Patron_Repository.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        protected DataContext _dbContext { get; set; }

        public BaseRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public void Create(T entity)
        {
            this._dbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this._dbContext.Set<T>().Remove(entity);
        }

        public void Delete(List<T> entity)
        {
            this._dbContext.Set<T>().RemoveRange(entity);
        }

        public IQueryable<T> FindAll()
        {
            return this._dbContext.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this._dbContext.Set<T>().Where(expression);
        }

        public T FindById(int id)
        {
            return this._dbContext.Set<T>().Find(id);
        }

        public T FindOneByCondition(Expression<Func<T, bool>> expression)
        {
            return this._dbContext.Set<T>().Where(expression).SingleOrDefault();
        }

        public void Save()
        {
            this._dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            this._dbContext.Set<T>().Update(entity);
        }

    }
}
