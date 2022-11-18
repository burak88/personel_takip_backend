using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        AppDbContext _context = new AppDbContext();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = _context.Set<T>();
        }

        public void Add(T entity)
        {
            var addEntity = _context.Entry(entity);
            addEntity.State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T entity)
        {
            var updateEntity = _context.Entry(entity);
            updateEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
