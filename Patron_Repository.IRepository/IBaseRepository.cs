using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Patron_Repository.IRepository
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        T FindOneByCondition(Expression<Func<T, bool>> expression);
        T FindById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(List<T> entity);
        void Save();
    }
}
