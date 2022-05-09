using JWT.Core.Application.interfaces;
using JWT.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JWT.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly AppDbcontext   appDbcontext;

        public Repository(AppDbcontext appDbcontext)
        {
            this.appDbcontext = appDbcontext;
        }

        public async Task CreateAsync(T entity)
        {
           await this.appDbcontext.Set<T>().AddAsync(entity);

           await this.appDbcontext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await this.appDbcontext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await this.appDbcontext.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await this.appDbcontext.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
             this.appDbcontext.Set<T>().Remove(entity);
            await this.appDbcontext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            this.appDbcontext.Set<T>().Update(entity);
            await this.appDbcontext.SaveChangesAsync();
        }
    }
}
