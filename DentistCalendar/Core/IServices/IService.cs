using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.IServices
{
    public interface IService<TEntity> where TEntity : class
    {
        void Save(TEntity student);
        IEnumerable<TEntity> GetAll();
        TEntity Find(object id);
        void Delete(object id);
        void Update(TEntity student);
        //IEnumerable<TEntity> Get(Predicate<TEntity> predicate);

       //TEntity GetByIdAsync(string userId);

    }
}
