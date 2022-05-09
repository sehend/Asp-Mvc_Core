using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IServices
{
    public interface IService<TEntity> where TEntity : class
    {
        void Save(TEntity student);
        IEnumerable<TEntity> GetAll();
        TEntity Find(object id);
        void Remove(TEntity entity);
        TEntity GetByIdAsync(int id);
        TEntity Update(TEntity entity);



    }
}
