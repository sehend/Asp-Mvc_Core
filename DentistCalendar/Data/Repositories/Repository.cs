using Core.Model;
using Core.Models;
using Core.Repositories;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public AppDbContext _context;
        public DbSet<TEntity>  _DbSet { get; private set; }
        public Repository(AppDbContext context)
        {
            _context = context;
            _DbSet = context.Set<TEntity>();
        }

        public void Delete(object id)
        {
            var entity = _DbSet.Find(id);

            _DbSet.Remove(entity);
        }

        public TEntity Get(object id)
        {
            return _DbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return (IEnumerable<TEntity>)_DbSet.AsEnumerable();
        }

        public void Save(TEntity student)
        {
            _DbSet.Add(student);
            
        }

        public void Update(TEntity student)
        {
            _DbSet.Update(student);
        }

      
    }
    
}
