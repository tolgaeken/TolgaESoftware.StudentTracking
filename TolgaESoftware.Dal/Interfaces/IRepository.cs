using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Common.Enums;

namespace TolgaESoftware.Dal.Interfaces
{
    public interface IRepository<T>:IDisposable
        where T:class
    {
        void Insert(T entity);
        void Insert(IEnumerable<T> entities);
        void Update(T entity);
        void Update(T entity,IEnumerable<string> fields);
        void Update(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        string GetNewCode(CardType cardType, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null);
        string GetNewStudentNumber(Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null);
        TResult Find<TResult>(Expression<Func<T, bool>> filter,Expression<Func<T,TResult>> selector);
        int Count(Expression<Func<T, bool>> filter=null);
        IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter,Expression<Func<T,TResult>> selector);

    }
}