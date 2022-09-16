using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.Dal.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;

namespace TolgaESoftware.Dal.Base
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        #region Variables

        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        #endregion

        public Repository(DbContext context)
        {
            if (context == null) return;
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Insert(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void Insert(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Added;
            }
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Update(T entity, IEnumerable<string> fields)
        {
            _dbSet.Attach(entity);
            var entry = _context.Entry(entity);
            foreach (var field in fields)
            {
                entry.Property(field).IsModified = true;
            }
        }

        public void Update(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public void Delete(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Deleted;
            }
        }

        public string GetNewCode(CardType cardType, Expression<Func<T, string>> filter,
            Expression<Func<T, bool>> where = null)
        {
            string Code()
            {
                string code = null;
                var codeArray = cardType.ToName().Split(' ');

                for (int i = 0; i < codeArray.Length - 1; i++)
                {
                    code += codeArray[i];
                    if (i + 1 < codeArray.Length - 1) code += " ";
                }

                return code += "-0000001";
            }

            string GetNewCode(string code)
            {
                var numericValues = "";

                foreach (var character in code)
                {
                    if (char.IsDigit(character)) numericValues += character;
                    else numericValues = "";
                }

                var postIncreaseValue = (int.Parse(numericValues) + 1).ToString();
                var difference = code.Length - postIncreaseValue.Length;
                if (difference < 0) difference = 0;
                var newValue = code.Substring(0, difference);
                newValue += postIncreaseValue;
                return newValue;
            }

            var maxCode = where == null ? _dbSet.Max(filter) : _dbSet.Where(where).Max(filter);
            return maxCode == null ? Code() : GetNewCode(maxCode);
        }

        public string GetNewStudentNumber(Expression<Func<T, string>> filter,
            Expression<Func<T, bool>> where = null)
        {
            string Number()
            {
                string number = null;
                var numberArray = "100000001";

                for (int i = 0; i < numberArray.Length; i++)
                {
                    number += numberArray[i];
                }

                return number;
            }

            string GetNewNumber(string number)
            {
                var numericValues = "";

                foreach (var character in number)
                {
                    if (char.IsDigit(character)) numericValues += character;
                    else numericValues = "";
                }

                var postIncreaseValue = (int.Parse(numericValues) + 1).ToString();
                var difference = number.Length - postIncreaseValue.Length;
                if (difference < 0) difference = 0;
                var newValue = number.Substring(0, difference);
                newValue += postIncreaseValue;
                return newValue;
            }

            var maxNumber = where == null ? _dbSet.Max(filter) : _dbSet.Where(where).Max(filter);
            return maxNumber == null ? Number() : GetNewNumber(maxNumber);
        }

        public TResult Find<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            return filter == null
                ? _dbSet.Select(selector).FirstOrDefault()
                : _dbSet.Where(filter).Select(selector).FirstOrDefault();
        }

        public int Count(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? _dbSet.Count() : _dbSet.Count(filter);
        }

        public IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter,
            Expression<Func<T, TResult>> selector)
        {
            return filter == null ? _dbSet.Select(selector) : _dbSet.Where(filter).Select(selector);
        }

        #region Dispose

        private bool _disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing) _context.Dispose();

                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}