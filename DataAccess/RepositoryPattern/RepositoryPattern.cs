
using DataAccess.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace DataAccess.RepositoryPattern
{// Repository Pattern Veritabanına veri ekleme,
 // güncelleme ve okuma gibi CRUD (Create Read Update Delete)
 // işlemlerimiz için oluşturmuş olduğumuz kodların tekrar kullanılabilirliğini sağlamaktır.
    public class RepositoryPattern<T> : IRepositoryPattern<T> where T : class
    {
        protected DbContext _context;
        protected DbSet<T> _dbset;
        public RepositoryPattern(DbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> condition)
        {
            return _dbset.Where(condition).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbset.ToList();

        }

        public void Update(T entity)
        {
            _context.Set<T>().Attach(entity);
        }
    }
}

