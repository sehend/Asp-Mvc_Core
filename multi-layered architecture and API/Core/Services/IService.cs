using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IService<TEntity> where TEntity:class
    {

        Task<TEntity> GetByIdAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate);


        //örenek:category.SingleOrDefault(x=>x.name="kalem") sadece ıd ye göre deyil her özelige göre çagırma

        Task<TEntity> SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        //tek kayıt için 
        Task<TEntity> AddAsync(TEntity entity);

        //toplukayıt için

        Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);

        //tek kayıt silme

        void Remove(TEntity entity);

        //Çok kayıt silme

        void RemoveRange(IEnumerable<TEntity> entities);


        TEntity Update(TEntity entity);



    }
}
