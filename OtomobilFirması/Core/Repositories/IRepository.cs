using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Save(TEntity student);
        IEnumerable<TEntity> GetAll();
        TEntity Get(object id);
        void Remove(TEntity entity);
        TEntity Update(TEntity entity);

        TEntity GetByIdAsync(int id);

    }
}
