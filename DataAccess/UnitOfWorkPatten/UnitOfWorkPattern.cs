using DataAccess.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace DataAccess.UnitOfWorkPatten
{
    /// <summary>
    /// <T> almak zorundasın çünkü generic bir tip. Diğer tarafta tanıtınca burda da tanıtmak zorunasın.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class UnitOfWorkPattern<T> : IUnitOfWorkPattern<T>
    {
        private DbContext _context;

        public UnitOfWorkPattern(DbContext context)
        {
            _context = context;
        }
        public IRepositoryPattern<TEntity> RepositoryPattern<TEntity>() where TEntity : class
        {
            return new RepositoryPattern<TEntity>(_context);
        }
        public int Save()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
            /// <summary>
            /// DIPONSE : görevi biten objectleri (nesneleri) çağırarak arka planda ekstra çalışmamasını sağlar.Class tipi objectlere uygulanır.
            /// </summary>
        }
    }

}
