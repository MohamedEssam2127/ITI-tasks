using Microsoft.EntityFrameworkCore;
using StudentDBWebApi.Context;

namespace StudentDBWebApi.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private UniversityContext _context;
        private DbSet<T> _dbSet;

        public GenericRepository(UniversityContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
