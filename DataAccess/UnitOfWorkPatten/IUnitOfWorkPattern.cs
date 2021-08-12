using DataAccess.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWorkPatten
{
    /// <summary>
    /// Uyguamayı daha verimli hale getirir ve yapılan iş bittikten sonra bellekten temizlenir.
    /// </summary>
    /// <typeparam name="Disponable"></typeparam>
    public interface IUnitOfWorkPattern<TEntity> : IDisposable
    {
      
        IRepositoryPattern<T> RepositoryPattern<T>() where T : class;
        int Save();

    }
  


}
