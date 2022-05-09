using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Save(TEntity student);
        IEnumerable<TEntity> GetAll();
        TEntity Get(object id);
        void Delete(object id);
        void Update(TEntity student);

        //TEntity GetByIdAsync(string userId );

    }
}
